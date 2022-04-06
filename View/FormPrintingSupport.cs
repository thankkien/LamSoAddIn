using LamSoAddIn.Controller;
using LamSoAddIn.Model;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LamSoAddIn
{
    public partial class FormPrintingSupport : Form
    {
        public FormPrintingSupport()
        {
            InitializeComponent();
        }
        private readonly BindingSource familiesBS = new BindingSource(XDoc.ReadFamilies(), null);
        private readonly BindingSource customersBS = new BindingSource(new List<Customers>(), null);
        List<SheetItem> sheetsList = new List<SheetItem>();
        private Customers _now = new Customers();
        private string _cusList = "";
        private int findedPos = -1;

        private void FormPrintingSupport_Load(object sender, EventArgs e)
        {
            dataGridViewFamilies.DataSource = familiesBS;
            dataGridViewFamilies.Columns[2].Visible = false;
            dataGridViewFamilies.Columns[0].Width = 150;
            dataGridViewFamilies.Columns[1].Width = 150;
            familiesBS.CurrentChanged += BsHoGiaDinh_CurrentChanged;
            customersBS.CurrentChanged += BsKhach_CurrentChanged;
            customersBS.DataSourceChanged += BsKhach_DataSourceChanged;

            dataGridViewKhach.DataSource = customersBS;
            dataGridViewKhach.Columns[3].Visible = false;
            dataGridViewKhach.Columns[5].Visible = false;
            dataGridViewKhach.Columns[6].Visible = false;
            dataGridViewKhach.Columns[7].Visible = false;
            dataGridViewKhach.Columns[8].Visible = false;
            dataGridViewKhach.Columns[2].Width = 40;
            dataGridViewKhach.Columns[4].Width = 40;

            numericUpDownLimitRow.Value = PrinterProperty.limitNumberRow;
            numericUpDownLimitRow.Minimum = 10;
            numericUpDownLimitRow.Maximum = 100;

            Workbook _Wb = Globals.ThisAddIn.Application.ActiveWorkbook;

            foreach (Worksheet sheet in _Wb.Sheets.Application.Worksheets)
            {
                sheetsList.Add(new SheetItem(sheet));
            }
            dataGridViewSheetsList.DataSource = sheetsList;
            dataGridViewSheetsList.Columns[0].ReadOnly = true;
        }

        private void BsKhach_DataSourceChanged(object sender, EventArgs e)
        {
            customersBS.ResetBindings(false);
        }

        private void BsHoGiaDinh_CurrentChanged(object sender, EventArgs e)
        {
            string _id = ((Families)familiesBS.Current).ID;
            customersBS.DataSource = XDoc.ReadCustomerF(_id);
            _cusList = string.Join(" ", (XDoc.DB.Root.Elements("Customers").Elements("Customer")
                                    .Where(x => x.Attribute("FamilyID").Value.Equals(_id))
                                    .Select(x => x.Element("Fullname").Value + " Tuổi " + Property.TuoiMu(int.Parse(x.Element("YearOfBirth").Value))))
                                    .ToArray());
        }

        public static Worksheet ShowSheet
        {
            get
            {
                Workbook _Wb = Globals.ThisAddIn.Application.ActiveWorkbook;
                Worksheet _Ws = new Worksheet();
                bool found = false;
                foreach (Worksheet sheet in _Wb.Sheets)
                {
                    if (sheet.Name == "TrangHienThi")
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    _Ws = _Wb.Sheets["TrangHienThi"];
                }
                else
                {
                    _Ws = _Wb.Sheets.Add();
                    _Ws.Name = "TrangHienThi";
                }
                return _Ws;
            }
        }

        public static void ToVertical(string _input, int _fromRow = 2, int _toRow = 7, int _fromCol = 1, int _toCol = 1)
        {
            string[] _output = _input.Split(' ');
            int _dCount = 0;
            for (int _cCount = _toCol; _cCount >= _fromCol; _cCount--)
            {
                for (int _rCount = _fromRow; _rCount <= _toRow; _rCount++)
                {
                    if (_dCount >= _output.Length) break;
                    ShowSheet.Cells[_rCount, _cCount].Value = _output[_dCount];
                    _dCount++;
                }
            }
        }

        private class FeatsList
        {
            public struct Feat
            {
                private string _name;
                private string _value;

                public Feat(string featName, string value)
                {
                    _name = featName;
                    _value = value;
                }

                [DisplayName("Chức năng")]
                public string Name { get => _name; set => _name = value; }

                [DisplayName("Giá trị")]
                public string Value { get => _value; set => _value = value; }
            }

            public static List<Feat> GetList(Customers _customer)
            {
                if (_customer != null) return new List<Feat>()
                {
                    new Feat("Tuổi mụ 1", Property.TuoiMu(_customer).ToString()),
                    new Feat("Tuổi mụ 2", Property.DoiSo(Property.TuoiMu(_customer))),
                    new Feat("Can chi", Property.CanChi(_customer)),
                    new Feat("Sao", Property.Sao(_customer)),
                    new Feat("Tam tai", (Property.TamTai(_customer))?"Bị":"Không bị"),
                    new Feat("Hạn", Property.Han(_customer)),
                    new Feat("Vận", Property.Van(_customer)),
                    new Feat("Chủ mệnh", Property.ChuMenh(_customer)),
                    new Feat("Động lâm", Property.DongLam(_customer)),
                    new Feat("Bản mệnh", Property.BanMenh(_customer)),
                    new Feat("Mệnh", Property.Menh(_customer)),
                    new Feat("Tiền", Property.Tien(_customer)),
                    new Feat("Kinh", Property.Kinh(_customer)),
                    new Feat("Kho", Property.Kho(_customer)),
                    new Feat("Chủ kho", Property.Chu(_customer)),
                    new Feat("Thêm", Property.Them(_customer))
                };
                return null;
            }
        }
        private void BsKhach_CurrentChanged(object sender, EventArgs e)
        {
            _now = (Customers)customersBS.Current;
            dataGridViewFeature.DataSource = FeatsList.GetList(_now);
        }

        private void ButtonPrintOut_Click(object sender, EventArgs e)
        {
            ShowSheet.Cells.Clear();
            ShowSheet.Range["A1:W1"].Font.Bold = true;
            ShowSheet.Cells[1, 1].Value = "Họ tên";
            ShowSheet.Cells[1, 2].Value = "Năm sinh";
            ShowSheet.Cells[1, 3].Value = "Giới tính";
            ShowSheet.Cells[1, 4].Value = "Tuổi mụ 1";
            ShowSheet.Cells[1, 5].Value = "Tuổi mụ 2";
            ShowSheet.Cells[1, 6].Value = "Can chi";
            ShowSheet.Cells[1, 7].Value = "Sao";
            ShowSheet.Cells[1, 8].Value = "Hạn";
            ShowSheet.Cells[1, 9].Value = "Vận";
            ShowSheet.Cells[1, 10].Value = "Chủ mệnh";
            ShowSheet.Cells[1, 11].Value = "Động lâm";
            ShowSheet.Cells[1, 12].Value = "Bản mệnh";
            ShowSheet.Cells[1, 13].Value = "Mệnh";
            ShowSheet.Cells[1, 14].Value = "Tào Quan:Tiền";
            ShowSheet.Cells[1, 15].Value = "Tào Quan:Kinh";
            ShowSheet.Cells[1, 16].Value = "Tào Quan:Kho";
            ShowSheet.Cells[1, 17].Value = "Tào Quan:Chủ";
            ShowSheet.Cells[1, 18].Value = "Tào Quan:Thêm";
            ShowSheet.Cells[1, 19].Value = "Hộ";
            ShowSheet.Cells[1, 20].Value = "Nơi ở";
            ShowSheet.Cells[1, 21].Value = "Ds khách";
            ShowSheet.Cells[1, 23].Value = "Tam tai";
            if (_now != null)
            {
                int _fromRow = 2, _toRow = (int)numericUpDownLimitRow.Value;
                ToVertical(_now.Fullname, _fromRow, _toRow, 1, 1);
                ToVertical(_now.YearOfBirth.ToString(), _fromRow, _toRow, 2, 2);
                ToVertical(_now.Gender.Sex, _fromRow, _toRow, 3, 3);
                ToVertical(Property.TuoiMu(_now).ToString(), _fromRow, _toRow, 4, 4);
                ToVertical(Property.DoiSo(Property.TuoiMu(_now)), _fromRow, _toRow, 5, 5);
                ToVertical(Property.CanChi(_now), _fromRow, _toRow, 6, 6);
                ToVertical(Property.Sao(_now), _fromRow, _toRow, 7, 7);
                ToVertical(Property.Han(_now), _fromRow, _toRow, 8, 8);
                ToVertical(Property.Van(_now), _fromRow, _toRow, 9, 9);
                ToVertical(Property.ChuMenh(_now), _fromRow, _toRow, 10, 10);
                ToVertical(Property.DongLam(_now), _fromRow, _toRow, 11, 11);
                ToVertical(Property.BanMenh(_now), _fromRow, _toRow, 12, 12);
                ToVertical(Property.Menh(_now), _fromRow, _toRow, 13, 13);
                ToVertical(Property.Tien(_now), _fromRow, _toRow, 14, 14);
                ToVertical(Property.Kinh(_now), _fromRow, _toRow, 15, 15);
                ToVertical(Property.Kho(_now), _fromRow, _toRow, 16, 16);
                ToVertical(Property.Chu(_now), _fromRow, _toRow, 17, 17);
                ToVertical(Property.Them(_now), _fromRow, _toRow, 18, 18);
                ToVertical(_now.FamilyName, _fromRow, _toRow, 19, 19);
                ToVertical(_now.Address.Living, _fromRow, _toRow, 20, 20);
                ToVertical(_cusList, _fromRow, _toRow, 21, 22);
                ToVertical(Property.TamTai(_now) ? "Bị" : "Không Bị", _fromRow, _toRow, 23, 23);

                foreach (SheetItem sheetItem in sheetsList)
                {
                    if (sheetItem.Checked) sheetItem.Sheet.PrintOutEx(From: 1, To: 1, Copies: 1, Preview: false);
                }
            }
        }

        private void numericUpDownLimitRow_ValueChanged(object sender, EventArgs e)
        {
            PrinterProperty.limitNumberRow = (int)numericUpDownLimitRow.Value;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<Customers> customers = XDoc.ReadCustomers();
            string keyword = Regex.Replace(textBoxKeyword.Text.Trim().ToLower(), @"\s+", " ");
            findedPos = customers.FindIndex(findedPos + 1, c => Regex.Replace(c.Fullname.Trim().ToLower(), @"\s+", " ").Contains(keyword) ||
                                                      Regex.Replace(c.FamilyName.Trim().ToLower(), @"\s+", " ").Contains(keyword));
            if (findedPos == -1) MessageBox.Show("Không tìm thấy!!");
            else
            {
                familiesBS.Position = ((List<Families>)familiesBS.List).FindIndex(f => f == customers[findedPos].Family);
                customersBS.Position = ((List<Customers>)customersBS.List).FindIndex(c => c == customers[findedPos]);
            }
        }
    }
}
