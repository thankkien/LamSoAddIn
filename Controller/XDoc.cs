using LamSoAddIn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LamSoAddIn.Controller
{
    class XDoc
    {
        private static string _path = "";
        private static XDocument _DB;
        private static bool _changed = false;
        public static string Path
        {
            get { return _path; }
            set { if (_path != value) _path = value; }
        }

        public static XDocument DB
        {
            get { return _DB; }
            set { if (_DB != value) _DB = value; }
        }

        public static bool Changed
        {
            get { return _changed; }
            set { if (_changed != value) _changed = value; }
        }

        public static bool Open()
        {
            OpenFileDialog dlg = new OpenFileDialog()
            {
                Title = "Chọn tệp tin XML chứa cơ sở dữ liệu",
                Filter = "XML files (*.xml)|*.xml",
                FilterIndex = 1
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Path = dlg.FileName;
                DB = XDocument.Load(Path);
                Changed = false;
                return true;
            }
            return false;
        }

        public static bool New()
        {
            SaveFileDialog dlg = new SaveFileDialog()
            {
                Title = "Tạo cơ sở dữ liệu mới bằng tệp tin XML ",
                Filter = "XML files (*.xml)|*.xml",
                FilterIndex = 1
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.FileName.Length != 0)
                {
                    XDocument _db = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                                                  new XElement("Root", new XElement("Customers"),
                                                                       new XElement("Families"),
                                                                       new XElement("Addresses")));
                    _db.Save(dlg.FileName);
                    Path = dlg.FileName;
                    DB = _db;
                    Changed = false;
                    return true;
                }
            }
            return false;
        }

        public static bool Save()
        {
            if (Changed)
            {
                DB.Save(Path);
                Changed = false;
                return true;
            }
            return false;
        }

        public static bool BackupSave()
        {
            if (Changed)
            {
                DB.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\backup-" + Property.GenerateID().ToString() + ".xml");
                Changed = false;
                return true;
            }
            return false;
        }

        public static bool SaveAs()
        {
            if (Path.Length != 0)
            {
                SaveFileDialog dlg = new SaveFileDialog()
                {
                    Title = "Lưu cơ sở dữ liệu thành tệp tin XML ",
                    Filter = "XML files (*.xml)|*.xml",
                    FilterIndex = 1
                };
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (dlg.FileName.Length != 0 && dlg.FileName != Path)
                    {
                        DB.Save(dlg.FileName);
                        return true;
                    }
                }
            }
            return false;
        }

        public static List<Families> ReadFamilies()
        {
            List<Families> _families = new List<Families>();
            try
            {
                if (DB.Root.Elements("Families").Count() != 0)
                {
                    _families = new List<Families>(from _f in DB.Root.Elements("Families").Elements("Family")
                                                   join _a in DB.Root.Elements("Addresses").Elements("Address")
                                                   on (string)_f.Attribute("AddressID") equals (string)_a.Attribute("ID")
                                                   select new Families()
                                                   {
                                                       ID = (string)_f.Attribute("ID"),
                                                       FamilyName = (string)_f.Element("FamilyName"),
                                                       Address = new Addresses()
                                                       {
                                                           ID = (string)_f.Attribute("AddressID"),
                                                           Living = (string)_a.Element("Living")
                                                       }
                                                   });
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Có Lỗi!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _families;
        }

        public static string UpdateFamily(Families _input)
        {
            try
            {
                List<Families> _families = new List<Families>(from _f in DB.Root.Elements("Families").Elements("Family")
                                                              where _f.Attribute("ID").Value.Equals(_input.ID.ToString())
                                                              join _a in DB.Root.Elements("Addresses").Elements("Address")
                                                              on (string)_f.Attribute("AddressID") equals (string)_a.Attribute("ID")
                                                              select new Families()
                                                              {
                                                                  ID = (string)_f.Attribute("ID"),
                                                                  FamilyName = (string)_f.Element("FamilyName"),
                                                                  Address = new Addresses()
                                                                  {
                                                                      ID = (string)_a.Attribute("ID"),
                                                                      Living = (string)_a.Element("Living")
                                                                  }
                                                              });
                if (_families.Count() != 0)
                {
                    if (_families[0] != _input)
                    {
                        var families = DB.Root.Descendants("Families").Descendants("Family").Where(_f => _f.Attribute("ID").Value.Equals(_input.ID.ToString()));
                        families.FirstOrDefault().Element("FamilyName").Value = _input.FamilyName;
                        families.FirstOrDefault().Attribute("AddressID").Value = _input.AddressID;
                        Changed = true;
                        return _input.ID;
                    }
                }
                else
                {
                    XElement _newFamily = new XElement("Family",
                                                        new XElement("FamilyName", _input.FamilyName));
                    _newFamily.SetAttributeValue("ID", _input.ID);
                    _newFamily.SetAttributeValue("AddressID", _input.AddressID);
                    DB.Root.Element("Families").Add(_newFamily);
                    Changed = true;
                    return _input.ID;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Có Lỗi!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }

        public static void RemoveFamily(string _inputID)
        {
            try
            {
                var fa = DB.Root.Descendants("Families").Descendants("Family").Where(f => f.Attribute("ID").Value.Equals(_inputID));
                if (fa.Count() >= 1)
                {
                    fa.Remove();
                    DB.Root.Descendants("Customers").Descendants("Customer").Where(c => c.Attribute("FamilyID").Value.Equals(_inputID)).Remove();
                }
                Changed = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Có Lỗi!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static List<Addresses> ReadAddresses()
        {
            List<Addresses> _addresses = new List<Addresses>();
            try
            {
                if (DB.Root.Elements("Addresses").Count() != 0)
                {
                    _addresses = new List<Addresses>(from _a in DB.Root.Elements("Addresses").Elements("Address")
                                                     select new Addresses()
                                                     {
                                                         ID = (string)_a.Attribute("ID"),
                                                         Living = (string)_a.Element("Living")
                                                     });
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Có Lỗi!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _addresses;
        }

        public static string UpdateAddress(Addresses _input)
        {
            try
            {
                List<Addresses> _addresses = new List<Addresses>(from _a in DB.Root.Elements("Addresses").Elements("Address")
                                                                 where _a.Attribute("ID").Value.Equals(_input.ID.ToString())
                                                                 select new Addresses()
                                                                 {
                                                                     ID = (string)_a.Attribute("ID"),
                                                                     Living = (string)_a.Element("Living")
                                                                 });
                if (_addresses.Count() != 0)
                {
                    if (_addresses[0] != _input)
                    {
                        DB.Root.Descendants("Addresses").Descendants("Address")
                            .Where(_a => _a.Attribute("ID").Value.Equals(_input.ID.ToString()))
                            .FirstOrDefault().Element("Living").Value = _input.Living;
                        Changed = true;
                        return _input.ID;
                    }
                }
                else
                {
                    XElement _newFamily = new XElement("Address",
                                                        new XElement("Living", _input.Living));
                    _newFamily.SetAttributeValue("ID", _input.ID);
                    DB.Root.Element("Addresses").Add(_newFamily);
                    Changed = true;
                    return _input.ID;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Có Lỗi!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }

        public static void RemoveAddress(string _inputID)
        {
            try
            {
                var ad = DB.Root.Descendants("Addresses").Descendants("Address").Where(a => a.Attribute("ID").Value.Equals(_inputID));
                if (ad.Count() >= 1)
                {
                    ad.Remove();
                    var fa = DB.Root.Descendants("Families").Descendants("Family").Where(f => f.Attribute("AddressID").Value.Equals(_inputID));
                    foreach (var f in fa)
                        DB.Root.Descendants("Customers").Descendants("Customer").Where(c => c.Attribute("FamilyID").Value.Equals(f.Attribute("ID"))).Remove();
                    fa.Remove();
                }
                Changed = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Có Lỗi!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<Customers> ReadCustomerF(string _inputFamilyID)
        {
            List<Customers> _customers = new List<Customers>();
            try
            {
                if (DB.Root.Elements("Customers").Count() != 0)
                {
                    _customers = new List<Customers>(from _c in DB.Root.Elements("Customers").Elements("Customer")
                                                     join _f in DB.Root.Elements("Families").Elements("Family")
                                                         on (string)_c.Attribute("FamilyID") equals (string)_f.Attribute("ID")
                                                     join _a in DB.Root.Elements("Addresses").Elements("Address")
                                                         on (string)_f.Attribute("AddressID") equals (string)_a.Attribute("ID")
                                                     where _c.Attribute("FamilyID").Value == _inputFamilyID.ToString()
                                                     select new Customers()
                                                     {
                                                         ID = (string)_c.Attribute("ID"),
                                                         Fullname = (string)_c.Element("Fullname"),
                                                         YearOfBirth = (int)_c.Element("YearOfBirth"),
                                                         Gender = new Gender((bool)_c.Element("Sex")),
                                                         Family = new Families()
                                                         {
                                                             ID = (string)_f.Attribute("ID"),
                                                             FamilyName = (string)_f.Element("FamilyName"),
                                                             Address = new Addresses()
                                                             {
                                                                 ID = (string)_a.Attribute("ID"),
                                                                 Living = (string)_a.Element("Living")
                                                             }
                                                         }
                                                     });
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Có Lỗi!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _customers;
        }

        public static List<Customers> ReadCustomers()
        {
            List<Customers> _customers = new List<Customers>();
            try
            {
                if (DB.Root.Elements("Customers").Count() != 0)
                {
                    _customers = new List<Customers>(from _c in DB.Root.Elements("Customers").Elements("Customer")
                                                     join _f in DB.Root.Elements("Families").Elements("Family")
                                                         on (string)_c.Attribute("FamilyID") equals (string)_f.Attribute("ID")
                                                     join _a in DB.Root.Elements("Addresses").Elements("Address")
                                                         on (string)_f.Attribute("AddressID") equals (string)_a.Attribute("ID")
                                                     select new Customers()
                                                     {
                                                         ID = (string)_c.Attribute("ID"),
                                                         Fullname = (string)_c.Element("Fullname"),
                                                         YearOfBirth = (int)_c.Element("YearOfBirth"),
                                                         Gender = new Gender((bool)_c.Element("Sex")),
                                                         Family = new Families()
                                                         {
                                                             ID = (string)_f.Attribute("ID"),
                                                             FamilyName = (string)_f.Element("FamilyName"),
                                                             Address = new Addresses()
                                                             {
                                                                 ID = (string)_a.Attribute("ID"),
                                                                 Living = (string)_a.Element("Living")
                                                             }
                                                         },
                                                     });
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Có Lỗi!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _customers;
        }

        public static string UpdateCustomer(Customers _input)
        {
            try
            {
                List<Customers> _customers = new List<Customers>(from _c in DB.Root.Elements("Customers").Elements("Customer")
                                                                 where _c.Attribute("ID").Value.Equals(_input.ID.ToString())
                                                                 join _f in DB.Root.Elements("Families").Elements("Family")
                                                                     on (string)_c.Attribute("FamilyID") equals (string)_f.Attribute("ID")
                                                                 join _a in DB.Root.Elements("Addresses").Elements("Address")
                                                                     on (string)_f.Attribute("AddressID") equals (string)_a.Attribute("ID")
                                                                 select new Customers()
                                                                 {
                                                                     ID = (string)_c.Attribute("ID"),
                                                                     Fullname = (string)_c.Element("Fullname"),
                                                                     YearOfBirth = (int)_c.Element("YearOfBirth"),
                                                                     Gender = new Gender((bool)_c.Element("Sex")),
                                                                     Family = new Families()
                                                                     {
                                                                         ID = (string)_c.Attribute("FamilyID"),
                                                                         FamilyName = (string)_f.Element("FamilyName"),
                                                                         Address = new Addresses()
                                                                         {
                                                                             ID = (string)_f.Attribute("AddressID"),
                                                                             Living = (string)_a.Element("Living")
                                                                         }
                                                                     }
                                                                 });

                if (_customers.Count() != 0)
                {
                    if (_customers[0] != _input)
                    {
                        var customers = DB.Root.Descendants("Customers").Descendants("Customer").Where(_c => _c.Attribute("ID").Value.Equals(_input.ID.ToString()));
                        customers.FirstOrDefault().Element("Fullname").Value = _input.Fullname;
                        customers.FirstOrDefault().Element("YearOfBirth").Value = _input.YearOfBirth.ToString();
                        customers.FirstOrDefault().Element("Sex").Value = _input.Gender.IsMale.ToString();
                        customers.FirstOrDefault().Attribute("FamilyID").Value = _input.FamilyID;
                        Changed = true;
                        return _input.ID;
                    }
                }
                else
                {
                    XElement _newCustomer = new XElement("Customer",
                                                        new XElement("Fullname", _input.Fullname),
                                                        new XElement("YearOfBirth", _input.YearOfBirth),
                                                        new XElement("Sex", _input.Gender.IsMale.ToString()));
                    _newCustomer.SetAttributeValue("ID", _input.ID);
                    _newCustomer.SetAttributeValue("FamilyID", _input.FamilyID);
                    DB.Root.Element("Customers").Add(_newCustomer);
                    Changed = true;
                    return _input.ID;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Có Lỗi!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }

        public static void RemoveCustomer(string _inputID)
        {
            try
            {
                var _cus = DB.Root.Descendants("Customers").Descendants("Customer").Where(_c => _c.Attribute("ID").Value.Equals(_inputID));
                if (_cus.Count() >= 1) _cus.Remove();
                Changed = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Có Lỗi!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
