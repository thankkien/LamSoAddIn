using LamSoAddIn.Model;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LamSoAddIn.Controller
{
    class ExportBill
    {
        public static ulong _costH = 0, _costTT = 0, _costTB = 0, _costLH = 0, _costKD = 0;

        private enum ColInBill
        {
            STT = 1,
            MaSo = 2,
            HoTen = 3,
            NamSinh = 4,
            GioiTinh = 5,
            ThaiBach = 6,
            LaHau = 7,
            KeDo = 8,
            TamTai = 9,
            TongTien = 10
        }

        public static Worksheet HoaDonSheet
        {
            get
            {
                Workbook _Wb = (Workbook)Globals.ThisAddIn.Application.ActiveWorkbook;
                Worksheet _Ws = new Worksheet();
                bool found = false;
                foreach (Worksheet sheet in _Wb.Sheets)
                {
                    if (sheet.Name == "HoaDon")
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    _Ws = _Wb.Sheets["HoaDon"];
                }
                else
                {
                    _Ws = _Wb.Sheets.Add();
                    _Ws.Name = "HoaDon";
                }
                return _Ws;
            }
        }

        public static void XuatHoaDon()
        {
            try
            {
                Worksheet _Ws = HoaDonSheet;
                _Ws.Cells.Clear();
                int _titleRow = 0, _totolRow = 0;
                ulong _total = 0;
                int _TTnamTotalCount = 0,
                    _TTnuTotalCount = 0,
                    _TBnamTotalCount = 0,
                    _TBnuTotalCount = 0,
                    _LHTotalCount = 0,
                    _KDTotalCount = 0,
                    _ctmTotalCount = 0;
                List<Families> _fs = XDoc.ReadFamilies();
                foreach (Families _f in _fs)
                {//Đọc và duyệt danh sách các hộ
                    List<Customers> _cs = XDoc.ReadCustomerF(_f.ID);
                    _ctmTotalCount += _cs.Count;
                    //Đọc và duyệt danh sách khách của hộ đang duyệt
                    _titleRow = _totolRow + 2; _totolRow += _cs.Count + 5;
                    int _customersCount = -1;
                    int _firtDataRow = _titleRow + 1,
                        _lastDataRow = _titleRow + _cs.Count,
                        _counterRow = _lastDataRow + 1,
                        _familyCostRow = _counterRow + 1;
                    int _TTnamCount = 0,
                        _TTnuCount = 0,
                        _TBnamCount = 0,
                        _TBnuCount = 0,
                        _LHCount = 0,
                        _KDCount = 0;
                    ulong _billTotal = 0;
                    for (int _crrRow = _titleRow; _crrRow <= _totolRow; _crrRow++)
                    {
                        ulong _totalCol = 0;
                        if (_crrRow == _titleRow)
                        {//In hang tieu de hoa don
                            _Ws.Cells[_crrRow, ColInBill.STT].Value = "STT";
                            _Ws.Cells[_crrRow, ColInBill.MaSo].Value = "Mã số";
                            _Ws.Cells[_crrRow, ColInBill.HoTen].Value = "Họ và tên";
                            _Ws.Cells[_crrRow, ColInBill.NamSinh].Value = "Năm sinh";
                            _Ws.Cells[_crrRow, ColInBill.GioiTinh].Value = "Giới tính";
                            _Ws.Cells[_crrRow, ColInBill.ThaiBach].Value = "Thái Bạch";
                            _Ws.Cells[_crrRow, ColInBill.LaHau].Value = "La Hầu";
                            _Ws.Cells[_crrRow, ColInBill.KeDo].Value = "Kế Đô";
                            _Ws.Cells[_crrRow, ColInBill.TamTai].Value = "Tam Tai";
                            _Ws.Cells[_crrRow, ColInBill.TongTien].Value = "Tổng Tiền";
                        }
                        else if (_firtDataRow <= _crrRow && _crrRow <= _lastDataRow)
                        {
                            if (_customersCount < _cs.Count) _customersCount++;
                            Customers _c = _cs[_customersCount];
                            _Ws.Cells[_crrRow, ColInBill.STT].Value = _customersCount + 1;
                            _Ws.Cells[_crrRow, ColInBill.MaSo].Value = _c.ID;
                            _Ws.Cells[_crrRow, ColInBill.HoTen].Value = _c.Fullname;
                            _Ws.Cells[_crrRow, ColInBill.NamSinh].Value = _c.YearOfBirth;
                            _Ws.Cells[_crrRow, ColInBill.GioiTinh].Value = _c.Gender.Sex;
                            if (Property.ThaiBach(_c))
                            {
                                if (_c.Gender.IsMale)
                                {
                                    _TBnamTotalCount++;
                                    _TBnamCount++;
                                }
                                else
                                {
                                    _TBnuTotalCount++;
                                    _TBnuCount++;
                                }
                                _Ws.Cells[_crrRow, ColInBill.ThaiBach].Value = _costTB;
                                _totalCol += _costTB;
                            }
                            else if (Property.LaHau(_c))
                            {
                                _LHTotalCount++;
                                _LHCount++;
                                _Ws.Cells[_crrRow, ColInBill.LaHau].Value = _costLH;
                                _totalCol += _costLH;
                            }
                            else if (Property.KeDo(_c))
                            {
                                _KDTotalCount++;
                                _KDCount++;
                                _Ws.Cells[_crrRow, ColInBill.KeDo].Value = _costKD;
                                _totalCol += _costKD;
                            }
                            if (Property.TamTai(_c))
                            {
                                if (_c.Gender.IsMale)
                                {
                                    _TTnamTotalCount++;
                                    _TTnamCount++;
                                }
                                else
                                {
                                    _TTnuTotalCount++;
                                    _TTnuCount++;
                                }
                                _Ws.Cells[_crrRow, ColInBill.TamTai].Value = _costTT;
                                _totalCol += _costTT;
                            }
                            _Ws.Cells[_crrRow, ColInBill.TongTien].Value = _totalCol;
                            _billTotal += _totalCol;
                        }
                        else if (_crrRow == _counterRow)
                        {//Dòng đếm số sao theo giới tính, tính thành tiền
                            _Ws.Cells[_crrRow, 5].Value = "Thành Tiền";
                            _Ws.Cells[_crrRow, ColInBill.ThaiBach].Value = "Nam:" + _TBnamCount + "/Nữ:" + _TBnuCount;
                            _Ws.Cells[_crrRow, ColInBill.LaHau].Value = "Nam:" + _LHCount;
                            _Ws.Cells[_crrRow, ColInBill.KeDo].Value = "Nữ:" + _KDCount;
                            _Ws.Cells[_crrRow, ColInBill.TamTai].Value = "Nam:" + _TTnamCount + "/Nữ:" + _TTnuCount;
                            _Ws.Cells[_crrRow, ColInBill.TongTien].Value = _billTotal;
                        }
                        else if (_crrRow == _familyCostRow)
                        {//Dòng tiền sớ 1 hộ
                            _Ws.Cells[_crrRow, 5].Value = "Tiền hộ:";
                            _Ws.Cells[_crrRow, 6].Value = _f.FamilyName;
                            _Ws.Cells[_crrRow, ColInBill.TongTien].Value = _costH;
                            _billTotal += _costH;
                            _total += _billTotal;
                        }
                        else if (_crrRow == _totolRow)
                        {//Dòng tổng tiền
                            _Ws.Cells[_crrRow, 5].Value = "Tổng Tiền:";
                            _Ws.Cells[_crrRow, ColInBill.TongTien].Value = _billTotal;
                        }
                    }
                    //Khai báo kiểu dữ liệu của các ô
                    _Ws.Range[_Ws.Cells[_firtDataRow, ColInBill.ThaiBach], _Ws.Cells[_lastDataRow, ColInBill.TamTai]].NumberFormat = "#.##0 ₫";
                    _Ws.Range[_Ws.Cells[_firtDataRow, ColInBill.TongTien], _Ws.Cells[_totolRow, ColInBill.TongTien]].NumberFormat = "#.##0 ₫";
                    _Ws.Range[_Ws.Cells[_firtDataRow, ColInBill.MaSo], _Ws.Cells[_totolRow, ColInBill.MaSo]].NumberFormat = "######## #####0";
                    _Ws.Range[_Ws.Cells[_firtDataRow, ColInBill.STT], _Ws.Cells[_totolRow, ColInBill.STT]].NumberFormat = "#.##0";
                    _Ws.Range[_Ws.Cells[_firtDataRow, ColInBill.NamSinh], _Ws.Cells[_totolRow, ColInBill.NamSinh]].NumberFormat = "0";
                    //Chỉnh kiểu phông chữ, màu ô, nét đậm
                    _Ws.Range[_Ws.Cells[_titleRow, ColInBill.STT], _Ws.Cells[_totolRow, ColInBill.TongTien]].Interior.ColorIndex = 36;
                    _Ws.Range[_Ws.Cells[_titleRow, ColInBill.STT], _Ws.Cells[_totolRow, ColInBill.TongTien]].Font.Name = "Consolas";
                    _Ws.Range[_Ws.Cells[_titleRow, ColInBill.STT], _Ws.Cells[_titleRow, ColInBill.TongTien]].Font.Bold = true;
                    _Ws.Range[_Ws.Cells[_titleRow, ColInBill.TongTien], _Ws.Cells[_totolRow, ColInBill.TongTien]].Font.Bold = true;
                    _Ws.Range[_Ws.Cells[_counterRow, 5], _Ws.Cells[_totolRow, 5]].Font.Bold = true;
                    _Ws.Range[_Ws.Cells[_counterRow, ColInBill.TongTien], _Ws.Cells[_totolRow, ColInBill.TongTien]].Font.Bold = true;
                    //Kẻ khung bảng hoá đơn
                    _Ws.Range[_Ws.Cells[_firtDataRow, ColInBill.STT], _Ws.Cells[_firtDataRow, ColInBill.TongTien]].Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
                    _Ws.Range[_Ws.Cells[_firtDataRow, ColInBill.STT], _Ws.Cells[_lastDataRow, ColInBill.TongTien]].Borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlDot;
                    _Ws.Range[_Ws.Cells[_lastDataRow, ColInBill.STT], _Ws.Cells[_lastDataRow, ColInBill.TongTien]].Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
                    _Ws.Range[_Ws.Cells[_titleRow, ColInBill.STT], _Ws.Cells[_counterRow, ColInBill.TongTien]].Borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlDot;
                }
                _Ws.Cells[1, 2].Value = "Hoá đơn tạo lúc:";
                _Ws.Cells[1, 3].Value = DateTime.Now.ToString();
                _Ws.Cells[1, 4].Value = _fs.Count + " hộ GD";
                _Ws.Cells[1, 5].Value = +_ctmTotalCount + " khách";
                _Ws.Cells[1, ColInBill.ThaiBach].Value = "Nam:" + _TBnamTotalCount + "/Nữ:" + _TBnuTotalCount;
                _Ws.Cells[1, ColInBill.LaHau].Value = "Nam:" + _LHTotalCount;
                _Ws.Cells[1, ColInBill.KeDo].Value = "Nữ:" + _KDTotalCount;
                _Ws.Cells[1, ColInBill.TamTai].Value = "Nam:" + _TTnamTotalCount + "/Nữ:" + _TTnuTotalCount;
                _Ws.Cells[1, ColInBill.TongTien].Value = _total;
                _Ws.Cells[1, ColInBill.TongTien].NumberFormat = "#.##0 ₫";
                _Ws.Range[_Ws.Cells[1, 1], _Ws.Cells[1, 10]].Interior.ColorIndex = 43;
                _Ws.Range[_Ws.Cells[1, 1], _Ws.Cells[1, 10]].Font.Bold = true;
                _Ws.Columns.AutoFit();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Có Lỗi!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}