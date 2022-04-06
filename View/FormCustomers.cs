using LamSoAddIn.Controller;
using LamSoAddIn.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace LamSoAddIn
{
    public partial class FormCustomer : Form
    {
        private bool _isDel = false;
        private int findedPos = -1;
        private readonly BindingSource addressesBS = new BindingSource(XDoc.ReadAddresses(), null);
        private readonly BindingSource familiesBS = new BindingSource(XDoc.ReadFamilies(), null);
        private readonly BindingSource customersBS = new BindingSource(new List<Customers>(), null);

        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormKhach_Load(object sender, EventArgs e)
        {
            dataGridViewFamilies.AutoGenerateColumns = false;
            dataGridViewFamilies.DataSource = familiesBS;
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.ReadOnly = true;
            idColumn.HeaderText = "Mã số";
            idColumn.DataPropertyName = "ID";

            DataGridViewTextBoxColumn familyColumn = new DataGridViewTextBoxColumn();
            familyColumn.HeaderText = "Tên hộ";
            familyColumn.DataPropertyName = "FamilyName";

            DataGridViewComboBoxColumn addressColumn = new DataGridViewComboBoxColumn();
            addressColumn.DataSource = XDoc.ReadAddresses();
            addressColumn.HeaderText = "Địa chỉ";
            addressColumn.DisplayMember = "Living";
            addressColumn.ValueMember = "ID";
            addressColumn.DataPropertyName = "AddressID";
            addressColumn.FlatStyle = FlatStyle.Flat;
            dataGridViewFamilies.Columns.AddRange(idColumn, familyColumn, addressColumn);

            dataGridViewFamilies.Columns[0].Width = 150;
            dataGridViewFamilies.Columns[1].Width = 150;

            familiesBS.AddingNew += FamiliesBS_AddingNew;
            familiesBS.CurrentItemChanged += FamiliesBS_CurrentChanged;
            familiesBS.CurrentItemChanged += FamiliesBS_CurrentItemChanged;

            if (familiesBS.Position != -1) customersBS.DataSource = XDoc.ReadCustomerF(((Families)familiesBS.Current).ID);
            dataGridViewCustomers.DataSource = customersBS;
            customersBS.AddingNew += CustomersBS_AddingNew;
            customersBS.DataSourceChanged += CustomersBS_DataSourceChanged;
            customersBS.CurrentItemChanged += CustomersBS_CurrentItemChanged;

            dataGridViewCustomers.Columns[0].ReadOnly = true;
            dataGridViewCustomers.Columns[4].Visible = false;
            dataGridViewCustomers.Columns[5].Visible = false;
            dataGridViewCustomers.Columns[6].Visible = false;
            dataGridViewCustomers.Columns[7].Visible = false;
            dataGridViewCustomers.Columns[8].Visible = false;

            dataGridViewCustomers.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCustomers.DefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridViewCustomers.Columns[2].Width = 40;
            dataGridViewCustomers.Columns[3].Width = 40;
        }

        private void FamiliesBS_CurrentChanged(object sender, EventArgs e)
        {
            string _id = ((Families)familiesBS.Current).ID;
            customersBS.DataSource = XDoc.ReadCustomerF(_id);
        }
        private void FamiliesBS_CurrentItemChanged(object sender, EventArgs e)
        {
            if (familiesBS.Count != 0 && ((Families)familiesBS.Current).ID != "")
                if (!_isDel)
                {
                    Families _now = new Families()
                    {
                        ID = ((Families)familiesBS.Current).ID,
                        FamilyName = ((Families)familiesBS.Current).FamilyName,
                        Address = ((Families)familiesBS.Current).Address,
                    };
                    XDoc.UpdateFamily(_now);
                    XDoc.Save();
                    _isDel = false;
                }
        }

        private void FamiliesBS_AddingNew(object sender, AddingNewEventArgs e)
        {
            if (addressesBS.Count != 0)
            {
                Families _newFamilies = new Families()
                {
                    AddressID = ((Addresses)addressesBS[0]).ID,
                    Living = ((Addresses)addressesBS[0]).Living
                };
                e.NewObject = _newFamilies;
            }
        }

        private void CustomersBS_DataSourceChanged(object sender, EventArgs e)
        {
            customersBS.ResetBindings(false);
        }

        private void CustomersBS_AddingNew(object sender, AddingNewEventArgs e)
        {
            Customers _newCustomer = new Customers()
            {
                FamilyID = ((Families)familiesBS.Current).ID,
                FamilyName = ((Families)familiesBS.Current).FamilyName
            };
            e.NewObject = _newCustomer;
        }

        private void CustomersBS_CurrentItemChanged(object sender, EventArgs e)
        {
            if (customersBS.Count != 0 && ((Customers)customersBS.Current).ID != "")
                if (!_isDel)
                {
                    Customers currCustomer = new Customers()
                    {
                        ID = ((Customers)customersBS.Current).ID,
                        Fullname = ((Customers)customersBS.Current).Fullname,
                        YearOfBirth = ((Customers)customersBS.Current).YearOfBirth,
                        Gender = ((Customers)customersBS.Current).Gender,
                        Family = ((Families)familiesBS.Current)
                    };
                    XDoc.UpdateCustomer(currCustomer);
                    XDoc.Save();
                    _isDel = false;
                }
        }

        private void ButtonLuu_Click(object sender, EventArgs e)
        {
            XDoc.Save();
        }

        private void FormCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XDoc.Changed)
            {
                if (e.CloseReason == CloseReason.WindowsShutDown) XDoc.BackupSave();
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (MessageBox.Show("Thoát mà không lưu dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        e.Cancel = false;
                    }
                }
            }
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<Customers> customers = XDoc.ReadCustomers();
            string keyword = Regex.Replace(textBoxKeyword.Text.Trim().ToLower(), @"\s+", " ");
            findedPos = customers.FindIndex(findedPos + 1, c => Regex.Replace(c.FamilyName.Trim().ToLower(), @"\s+", " ").Contains(keyword) ||
                                                      Regex.Replace(c.Fullname.Trim().ToLower(), @"\s+", " ").Contains(keyword));
            if (findedPos == -1) MessageBox.Show("Không tìm thấy!!");
            else
            {
                familiesBS.Position = ((List<Families>)familiesBS.List).FindIndex(f => f == customers[findedPos].Family);
                customersBS.Position = ((List<Customers>)customersBS.List).FindIndex(c => c == customers[findedPos]);
            }
        }

        private void dataGridViewFamilies_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    dataGridViewFamilies.Rows[e.RowIndex].Selected = true;
                    toolStripMenuItemDelFa.Visible = true;
                }
                else toolStripMenuItemDelFa.Visible = false;
                contextMenuStripFamilies.Show(dataGridViewFamilies, e.Location);
                contextMenuStripFamilies.Show(Cursor.Position);
            }
        }

        private void dataGridViewCustomers_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    dataGridViewCustomers.Rows[e.RowIndex].Selected = true;
                    toolStripMenuItemDelCus.Visible = true;
                }
                else toolStripMenuItemDelCus.Visible = false;
                if (familiesBS.Count != 0) toolStripMenuItemParseCus.Visible = true;
                else toolStripMenuItemParseCus.Visible = false;
                contextMenuStripCustomers.Show(dataGridViewCustomers, e.Location);
                contextMenuStripCustomers.Show(Cursor.Position);
            }
        }

        private void toolStripMenuItemDelCus_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Nhấn yes để xóa khách", "Xác nhận xóa khách này?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (customersBS.Count != 0)
                {
                    _isDel = true;
                    XDoc.RemoveCustomer(((Customers)customersBS.Current).ID);
                    customersBS.RemoveCurrent();
                }
            }
        }

        private void toolStripMenuItemDelFa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Nhấn yes để xóa hộ gia đình và các khách liên quan", "Xác nhận xóa hộ này?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (familiesBS.Count != 0)
                {
                    _isDel = true;
                    XDoc.RemoveFamily(((Families)familiesBS.Current).ID);
                    familiesBS.RemoveCurrent();
                }
            }
        }

        private void toolStripMenuItemAddFa_Click(object sender, EventArgs e)
        {
            familiesBS.AddNew();
        }

        private void toolStripMenuItemAddCus_Click(object sender, EventArgs e)
        {
            customersBS.AddNew();
        }

        private void toolStripMenuItemParseCus_Click(object sender, EventArgs e)
        {
            try
            {
                String[] clb = Clipboard.GetText().Split('\n');
                for (int it = 0; it < clb.Length; it++)
                {
                    string record = clb[it];
                    if (record.Length != 0)
                    {
                        string[] fields = record.Split('\t');
                        Customers cus = new Customers() { Family = (Families)familiesBS.Current };
                        if (fields.Length == 1)
                        {
                            cus.Fullname = fields[0];
                            cus.YearOfBirth = DateTimeOffset.Now.Year;
                            cus.IsMale = true;
                        }
                        if (fields.Length == 2)
                        {
                            cus.Fullname = fields[0];
                            bool isNumeric = int.TryParse(fields[1], out int n);
                            cus.YearOfBirth = isNumeric ? n : DateTimeOffset.Now.Year;
                            cus.IsMale = true;
                        }
                        else if (fields.Length == 3)
                        {
                            cus.Fullname = fields[0]; 
                            bool isNumeric = int.TryParse(fields[1], out int n);
                            cus.YearOfBirth = isNumeric ? n : DateTimeOffset.Now.Year;
                            if (fields[2].Trim().ToLower() == "nam")
                                cus.IsMale = true;
                            else if (fields[2].Trim().ToLower() == "nữ")
                                cus.IsMale = false;
                            else if (fields[2].Trim().ToLower() == "true" || fields[2].Trim().ToLower() == "false")
                                cus.IsMale = bool.Parse(fields[2].Trim().ToLower());
                            else cus.IsMale = true;
                        }
                        else if (fields.Length == 4)
                        {
                            if (fields[0].Length == 20 && fields[0].Contains("KH-")) cus.ID = fields[0];
                            else cus.ID = "KH-" + Property.GenerateID();
                            cus.Fullname = fields[1];
                            bool isNumeric = int.TryParse(fields[2], out int n);
                            cus.YearOfBirth = isNumeric ? n : DateTimeOffset.Now.Year;
                            if (fields[3].Trim().ToLower() == "nam")
                                cus.IsMale = true;
                            else if (fields[3].Trim().ToLower() == "nữ")
                                cus.IsMale = false;
                            else if (fields[3].Trim().ToLower() == "true" || fields[3].Trim().ToLower() == "false")
                                cus.IsMale = bool.Parse(fields[3].Trim().ToLower());
                            else cus.IsMale = true;
                        }
                        customersBS.Add(cus);
                        XDoc.UpdateCustomer(cus);
                        Thread.Sleep(1);
                    }
                }
                XDoc.Save();
            }
            catch
            {
                MessageBox.Show("Có lỗi trong lúc dán dữ liệu...\n Chắc chắn rằng có đủ các cột tên hoặc tên/năm sinh hoặc tên, năm sinh, giới tính hoặc năm sinh phải là kiểu số hoặc giới tính nhận đúng một trong các giá trị: Nam/Nữ/True/False");
            }
        }
    }
}