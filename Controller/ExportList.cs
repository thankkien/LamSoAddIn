using LamSoAddIn.Model;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;

namespace LamSoAddIn.Controller
{
    class ExportList
    {
        public static bool HoGD = true;
        public static bool NoiO = true;
        public static bool TuoiMu1 = false;
        public static bool TuoiMu2 = false;
        public static bool CanChi = false;
        public static bool Sao = false;
        public static bool Han = false;
        public static bool Van = false;
        public static bool ChuMenh = false;
        public static bool DongLam = false;
        public static bool BanMenh = false;
        public static bool Menh = false;
        public static bool Tien = false;
        public static bool Kinh = false;
        public static bool Kho = false;
        public static bool Chu = false;
        public static bool Them = false;
        public static int RowCount = 0;
        public static int ColCount = 0;

        public static Worksheet DanhSachSheet
        {
            get
            {
                Workbook _Wb = (Workbook)Globals.ThisAddIn.Application.ActiveWorkbook;
                Worksheet _Ws = new Worksheet();
                bool found = false;
                foreach (Worksheet sheet in _Wb.Sheets)
                {
                    if (sheet.Name == "DanhSach")
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    _Ws = _Wb.Sheets["DanhSach"];
                }
                else
                {
                    _Ws = _Wb.Sheets.Add();
                    _Ws.Name = "DanhSach";
                }
                return _Ws;
            }
        }

        public static void XuatDanhSach()
        {
            Worksheet _Ws = DanhSachSheet;
            List<Customers> _cs = XDoc.ReadCustomers();
            _Ws.Cells.Clear();
            int _cCount = 4;
            int _titleRow = 1;
            RowCount = _cs.Count + _titleRow;
            for (int _rCount = _titleRow; _rCount <= RowCount; _rCount++)
            {
                int _csIndex = _rCount - _titleRow - 1;
                if (_rCount == _titleRow)
                {
                    _Ws.Cells[_rCount, 1].Value = "Mã số";
                    _Ws.Cells[_rCount, 2].Value = "Họ và tên";
                    _Ws.Cells[_rCount, 3].Value = "Năm sinh";
                    _Ws.Cells[_rCount, 4].Value = "Giới tính";
                }
                else if (_rCount <= RowCount)
                {
                    _Ws.Cells[_rCount, 1].Value = _cs[_csIndex].ID.ToString();
                    _Ws.Cells[_rCount, 2].Value = _cs[_csIndex].Fullname;
                    _Ws.Cells[_rCount, 3].Value = _cs[_csIndex].YearOfBirth;
                    _Ws.Cells[_rCount, 4].Value = _cs[_csIndex].Gender.Sex;
                }
                if (_rCount == RowCount)
                {
                    _Ws.Columns[1].Style.NumberFormat = "#";
                    _Ws.Columns[1].AutoFit();
                    _Ws.Columns[2].AutoFit();
                    _Ws.Columns[3].AutoFit();
                    _Ws.Columns[4].AutoFit();
                }
                if (HoGD)
                {
                    _cCount++;
                    if (_rCount == _titleRow) _Ws.Cells[_rCount, _cCount].Value = "Hộ gia đình";
                    else if (_rCount <= RowCount) _Ws.Cells[_rCount, _cCount].Value = _cs[_csIndex].Family.FamilyName;
                    if (_rCount == RowCount) _Ws.Columns[_cCount].AutoFit();
                }
                if (NoiO)
                {
                    _cCount++;
                    if (_rCount == _titleRow) _Ws.Cells[_rCount, _cCount].Value = "Nơi ở";
                    else if (_rCount <= RowCount) _Ws.Cells[_rCount, _cCount].Value = _cs[_csIndex].Address.Living;
                }
                if (TuoiMu1)
                {
                    _cCount++;
                    if (_rCount == _titleRow) _Ws.Cells[_rCount, _cCount].Value = "Tuổi mụ 1";
                    else if (_rCount <= RowCount) _Ws.Cells[_rCount, _cCount].Value = Property.TuoiMu(_cs[_csIndex]);
                    if (_rCount == RowCount) _Ws.Columns[_cCount].AutoFit();
                }
                if (TuoiMu2)
                {
                    _cCount++;
                    if (_rCount == _titleRow) _Ws.Cells[_rCount, _cCount].Value = "Tuổi mụ 2";
                    else if (_rCount <= RowCount) _Ws.Cells[_rCount, _cCount].Value = Property.DoiSo(Property.TuoiMu(_cs[_csIndex]));
                    if (_rCount == RowCount) _Ws.Columns[_cCount].AutoFit();
                }
                if (CanChi)
                {
                    _cCount++;
                    if (_rCount == _titleRow) _Ws.Cells[_rCount, _cCount].Value = "Can chi";
                    else if (_rCount <= RowCount) _Ws.Cells[_rCount, _cCount].Value = Property.CanChi(_cs[_csIndex]);
                    if (_rCount == RowCount) _Ws.Columns[_cCount].AutoFit();
                }
                if (Sao)
                {
                    _cCount++;
                    if (_rCount == _titleRow) _Ws.Cells[_rCount, _cCount].Value = "Sao";
                    else if (_rCount <= RowCount) _Ws.Cells[_rCount, _cCount].Value = Property.Sao(_cs[_csIndex]);
                    if (_rCount == RowCount) _Ws.Columns[_cCount].AutoFit();
                }
                if (Han)
                {
                    _cCount++;
                    if (_rCount == _titleRow) _Ws.Cells[_rCount, _cCount].Value = "Hạn";
                    else if (_rCount <= RowCount) _Ws.Cells[_rCount, _cCount].Value = Property.Han(_cs[_csIndex]);
                    if (_rCount == RowCount) _Ws.Columns[_cCount].AutoFit();
                }
                if (Van)
                {
                    _cCount++;
                    if (_rCount == _titleRow) _Ws.Cells[_rCount, _cCount].Value = "Vận";
                    else if (_rCount <= RowCount) _Ws.Cells[_rCount, _cCount].Value = Property.Van(_cs[_csIndex]);
                    if (_rCount == RowCount) _Ws.Columns[_cCount].AutoFit();
                }
                if (ChuMenh)
                {
                    _cCount++;
                    if (_rCount == _titleRow) _Ws.Cells[_rCount, _cCount].Value = "Chủ mệnh";
                    else if (_rCount <= RowCount) _Ws.Cells[_rCount, _cCount].Value = Property.ChuMenh(_cs[_csIndex]);
                    if (_rCount == RowCount) _Ws.Columns[_cCount].AutoFit();
                }
                if (DongLam)
                {
                    _cCount++;
                    if (_rCount == _titleRow) _Ws.Cells[_rCount, _cCount].Value = "Động lâm";
                    else if (_rCount <= RowCount) _Ws.Cells[_rCount, _cCount].Value = Property.DongLam(_cs[_csIndex]);
                    if (_rCount == RowCount) _Ws.Columns[_cCount].AutoFit();
                }
                if (BanMenh)
                {
                    _cCount++;
                    if (_rCount == _titleRow) _Ws.Cells[_rCount, _cCount].Value = "Bản Mệnh";
                    else if (_rCount <= RowCount) _Ws.Cells[_rCount, _cCount].Value = Property.BanMenh(_cs[_csIndex]);
                    if (_rCount == RowCount) _Ws.Columns[_cCount].AutoFit();
                }
                if (Menh)
                {
                    _cCount++;
                    if (_rCount == _titleRow) _Ws.Cells[_rCount, _cCount].Value = "Mệnh";
                    else if (_rCount <= RowCount) _Ws.Cells[_rCount, _cCount].Value = Property.Menh(_cs[_csIndex]);
                    if (_rCount == RowCount) _Ws.Columns[_cCount].AutoFit();
                }
                if (Tien)
                {
                    _cCount++;
                    if (_rCount == _titleRow) _Ws.Cells[_rCount, _cCount].Value = "Tào Quan:Tiền";
                    else if (_rCount <= RowCount) _Ws.Cells[_rCount, _cCount].Value = Property.Tien(_cs[_csIndex]);
                    if (_rCount == RowCount) _Ws.Columns[_cCount].AutoFit();
                }
                if (Kinh)
                {
                    _cCount++;
                    if (_rCount == _titleRow) _Ws.Cells[_rCount, _cCount].Value = "Tào Quan:Kinh";
                    else if (_rCount <= RowCount) _Ws.Cells[_rCount, _cCount].Value = Property.Kinh(_cs[_csIndex]);
                    if (_rCount == RowCount) _Ws.Columns[_cCount].AutoFit();
                }
                if (Kho)
                {
                    _cCount++;
                    if (_rCount == _titleRow) _Ws.Cells[_rCount, _cCount].Value = "Tào Quan:Kho";
                    else if (_rCount <= RowCount) _Ws.Cells[_rCount, _cCount].Value = Property.Kho(_cs[_csIndex]);
                    if (_rCount == RowCount) _Ws.Columns[_cCount].AutoFit();
                }
                if (Chu)
                {
                    _cCount++;
                    if (_rCount == _titleRow) _Ws.Cells[_rCount, _cCount].Value = "Tào Quan:Chủ";
                    else if (_rCount <= RowCount) _Ws.Cells[_rCount, _cCount].Value = Property.Chu(_cs[_csIndex]);
                    if (_rCount == RowCount) _Ws.Columns[_cCount].AutoFit();
                }
                if (Them)
                {
                    _cCount++;
                    if (_rCount == _titleRow) _Ws.Cells[_rCount, _cCount].Value = "Tào Quan:Thêm";
                    else if (_rCount <= RowCount) _Ws.Cells[_rCount, _cCount].Value = Property.Them(_cs[_csIndex]);
                    if (_rCount == RowCount) _Ws.Columns[_cCount].AutoFit();
                }
                ColCount = _cCount;
                _cCount = 4;
            }
            Range _range = _Ws.Range[_Ws.Cells[_titleRow, 1], _Ws.Cells[RowCount, ColCount]];
            ListObject _invoice = (ListObject)_Ws.ListObjects.AddEx(XlListObjectSourceType.xlSrcRange,
                _range,
                Type.Missing,
                XlYesNoGuess.xlYes);
            _invoice.Name = _Ws.Name;
        }
    }
}
