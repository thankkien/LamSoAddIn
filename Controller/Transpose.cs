using Microsoft.Office.Interop.Excel;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LamSoAddIn.Controller
{
    class Transpose
    {
        public enum CanLe { TRAIsangPHAI, PHAIsangTRAI };
        public enum Loai { TENKHACH, DIACHI, CHUHO };

        public static Worksheet ChuyenDocSheet
        {
            get
            {
                Workbook _Wb = (Workbook)Globals.ThisAddIn.Application.ActiveWorkbook;
                Worksheet _Ws = new Worksheet();
                bool found = false;
                foreach (Worksheet sheet in _Wb.Sheets)
                {
                    if (sheet.Name == "DanhSachDoc")
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    _Ws = _Wb.Sheets["DanhSachDoc"];
                }
                else
                {
                    _Ws = _Wb.Sheets.Add();
                    _Ws.Name = "DanhSachDoc";
                }
                return _Ws;
            }
        }

        private static (int, int, int) GenFLU(int align, int columnsStart, int columnsCount)
        {
            //firt, last, unit
            switch (align)
            {
                case (int)CanLe.TRAIsangPHAI: return (columnsStart, columnsCount, 1);
                case (int)CanLe.PHAIsangTRAI: return (columnsCount, columnsStart, -1);
            }
            return (0, 0, 0);
        }

        public static void ChuyenDoc(int Content, int Align, int RowCount = 10)
        {
            try
            {
                string[] _data = new string[0];
                Worksheet _Ws = ChuyenDocSheet;
                _Ws.Cells.Clear();
                int _dataCount = 0;
                if (Content == (int)Loai.DIACHI)
                {
                    _data = (XDoc.DB.Root.Elements("Addresses").Elements("Address").Select(x => x.Element("Living").Value)).ToArray();
                    string[] _temp = new string[0];
                    int _col = 0;
                    for (int i = 0; i < _data.Length; i++)
                    {
                        _temp = _data[1].Split();
                        _col += (_temp.Length / RowCount) + 1;
                    }
                    (int _first, int _last, int _unit) = GenFLU(Align, 1, _col);
                    int _tempCount = 0;
                    for (int _cCount = _first; (Align == (int)CanLe.TRAIsangPHAI) ? (_cCount <= _last) : (_cCount >= _last); _cCount += _unit)
                    {
                        if (_dataCount < _data.Length)
                        {
                            _temp = _data[_dataCount].Split();
                            for (int _rCount = 1; _rCount <= RowCount; _rCount++)
                            {
                                if (_tempCount < _temp.Length)
                                {
                                    Range _Cell = _Ws.Cells[_rCount, _cCount];
                                    _Cell.Value = _temp[_tempCount];
                                    _tempCount++;
                                }
                                else break;
                            }
                            if (_tempCount == _temp.Length)
                            {
                                _dataCount++;
                                _tempCount = 0;
                            }
                        }
                    }
                }
                else
                {
                    if (Content == (int)Loai.TENKHACH)
                    {
                        _data = (XDoc.DB.Root.Elements("Families").Elements("Family")
                            .Select(x => x.Attribute("ID").Value))
                            .ToArray();
                        for (int i = 0; i < _data.Length; i++)
                        {
                            _data[i] = string.Join(" ", (XDoc.DB.Root
                                .Elements("Customers").Elements("Customer")
                                .Where(x => x.Attribute("FamilyID").Value.Equals(_data[i]))
                                .Select(x => x.Element("Fullname").Value + " Tuổi " + Property.TuoiMu(int.Parse(x.Element("YearOfBirth").Value))))
                                .ToArray()) + " *";
                        }
                    }
                    else
                    {
                        _data = (XDoc.DB.Root.Elements("Families").Elements("Family")
                            .Select(x => x.Element("FamilyName").Value + " *"))
                            .ToArray();
                    }
                    _data = String.Join(" ", _data).Split(' ');
                    int _col = _data.Length / RowCount + 1;
                    (int _first, int _last, int _unit) = GenFLU(Align, 1, _col);
                    for (int _cCount = _first; (Align == (int)CanLe.TRAIsangPHAI) ? (_cCount <= _last) : (_cCount >= _last); _cCount += _unit)
                    {
                        for (int _rCount = 1; _rCount <= RowCount; _rCount++)
                        {
                            if (_dataCount < _data.Length)
                            {
                                Range _Cell = _Ws.Cells[_rCount, _cCount];
                                _Cell.Value = _data[_dataCount];
                                _dataCount++;
                            }
                            else break;
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Có Lỗi!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
