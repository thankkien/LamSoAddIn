using LamSoAddIn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LamSoAddIn.Controller
{
    class Property
    {
        public static string GenerateID()
        {
            string _year = (DateTime.Now.Year % 100).ToString();
            string _month = DateTime.Now.Month.ToString("D2");
            string _day = DateTime.Now.Day.ToString("D2");
            string _hour = DateTime.Now.Hour.ToString("D2");
            string _minute = DateTime.Now.Minute.ToString("D2");
            string _second = DateTime.Now.Second.ToString("D2");
            string ms = DateTime.Now.Millisecond.ToString();
            string _msecond = (ms.Length == 1) ? "00" + ms : (ms.Length == 2) ? "0" + ms : ms;
            return _year + _month + _day + "-" + _hour + _minute + _second + "-" + _msecond;
        }

        public static int TuoiMu(int _namSinh)
        {
            int _namHienTai = DateTime.Now.Year;
            return _namHienTai - _namSinh + 1;
        }

        public static int TuoiMu(Customers _customers)
        {
            return TuoiMu(_customers.YearOfBirth);
        }

        public static string DoiSo(int _dauVao)
        {
            Dictionary<int, string> _so = new Dictionary<int, string>()
            {{0,""}, {1,"Nhất"},  {2,"Nhị"},  {3,"Tam"}, {4,"Tứ"}, {5,"Ngũ"}, {6,"Lục"}, {7,"Thất"}, {8,"Bát"}, {9,"Cửu"}};
            if (_dauVao < 10000000 || _dauVao > 0)
            {
                string _dauRa = "";
                string[] _hang = { "Triệu", "Ức", "Vạn", "Thiên", "Bách", "Thập", "" };
                string _strDauVao = _dauVao.ToString();
                int j = 6;
                for (int i = _strDauVao.Length - 1; i >= 0; i--)
                {
                    if (_strDauVao[i] == '1')
                    {
                        if (j == 6) _dauRa = _so[int.Parse(_strDauVao[i].ToString())] + " " + _dauRa;
                        else _dauRa = _hang[j] + " " + _dauRa;
                    }
                    else if (_strDauVao[i] != '0')
                    {
                        _dauRa = _so[int.Parse(_strDauVao[i].ToString())] + " " + _hang[j] + " " + _dauRa;
                    }
                    j--;
                }
                return _dauRa;
            }
            return "";
        }

        public static string ThienCan(int _namSinh)
        {
            XDocument DB = XDocument.Parse(Properties.Resources.XMLres);
            string ketqua = DB.Root
                .Element("dsThienCan")
                .Elements("ThienCan")
                .Where(x => x.Attribute("MaSo").Value == (_namSinh % 10).ToString())
                .FirstOrDefault().Value;
            return ketqua;
        }

        public static string ThienCan(Customers _customers)
        {
            return ThienCan(_customers.YearOfBirth);
        }

        public static string DiaChi(int _namSinh)
        {
            XDocument DB = XDocument.Parse(Properties.Resources.XMLres);
            string ketqua = DB.Root
                .Element("dsDiaChi")
                .Elements("DiaChi").Where(x => x.Attribute("MaSo").Value == (_namSinh % 12).ToString())
                .FirstOrDefault().Value;
            return ketqua;
        }

        public static string DiaChi(Customers _customers)
        {
            return DiaChi(_customers.YearOfBirth);
        }

        public static string CanChi(int _namSinh)
        {
            return ThienCan(_namSinh) + " " + DiaChi(_namSinh);
        }

        public static string CanChi(Customers _customers)
        {
            return CanChi(_customers.YearOfBirth);
        }

        public static string Sao(int _namSinh, string _gioiTinh)
        {
            XDocument DB = XDocument.Parse(Properties.Resources.XMLres);
            string ketqua = DB.Root
                .Element("dsSao")
                .Elements("Sao")
                .Where(x => x.Attribute("MaSo").Value == (TuoiMu(_namSinh) % 9).ToString() && x.Attribute("GioiTinh").Value == _gioiTinh)
                .FirstOrDefault().Value;
            return ketqua;
        }

        public static string Sao(Customers _customers)
        {
            return Sao(_customers.YearOfBirth, _customers.Sex);
        }

        public static string Han(int _namSinh, string _gioiTinh)
        {
            int temp = TuoiMu(_namSinh), flag;
            while (temp > 17)
            {
                flag = temp % 10;
                if (flag == 8 || flag == 9) temp -= 8;
                else temp -= 9;
            };
            if (temp < 10) return "";
            XDocument DB = XDocument.Parse(Properties.Resources.XMLres);
            string ketqua = DB.Root
                .Element("dsHan")
                .Elements("Han")
                .Where(x => x.Attribute("MaSo").Value == (temp).ToString() && x.Attribute("GioiTinh").Value == _gioiTinh)
                .FirstOrDefault().Value;
            return ketqua;
        }

        public static string Han(Customers _customers)
        {
            return Han(_customers.YearOfBirth, _customers.Sex);
        }

        public static string Van(int _namSinh, string _gioiTinh)
        {
            XDocument DB = XDocument.Parse(Properties.Resources.XMLres);
            string ketqua = DB.Root
                .Element("dsVan")
                .Elements("Van")
                .Where(x => x.Attribute("MaSo").Value == (_namSinh % 12).ToString() && x.Attribute("GioiTinh").Value == _gioiTinh)
                .FirstOrDefault().Value;
            return ketqua;
        }

        public static string Van(Customers _customers)
        {
            return Van(_customers.YearOfBirth, _customers.Sex);
        }

        public static string ChuMenh(int _namSinh)
        {
            XDocument DB = XDocument.Parse(Properties.Resources.XMLres);
            string ketqua = DB.Root
                .Element("dsChuMenh")
                .Elements("ChuMenh")
                .Where(x => x.Attribute("MaSo").Value == (_namSinh % 12).ToString())
                .FirstOrDefault().Value;
            return ketqua;
        }

        public static string ChuMenh(Customers _customers)
        {
            return ChuMenh(_customers.YearOfBirth);
        }

        public static string DongLam(int _namSinh, string _gioiTinh)
        {
            XDocument DB = XDocument.Parse(Properties.Resources.XMLres);
            string ketqua = DB.Root
                .Element("dsDongLam")
                .Elements("DongLam")
                .Where(x => x.Attribute("MaSo").Value == (TuoiMu(_namSinh) % 8).ToString() && x.Attribute("GioiTinh").Value == _gioiTinh)
                .FirstOrDefault().Value;
            return ketqua;
        }

        public static string DongLam(Customers _customers)
        {
            return DongLam(_customers.YearOfBirth, _customers.Sex);
        }

        public static bool LaHau(int _namSinh, string _gioiTinh)
        {
            if (_gioiTinh == "Nam" && TuoiMu(_namSinh) % 9 == 1) return true;
            return false;
        }

        public static bool LaHau(Customers _customers)
        {
            return LaHau(_customers.YearOfBirth, _customers.Sex);
        }

        public static bool KeDo(int _namSinh, string _gioiTinh)
        {
            if (_gioiTinh == "Nữ" && TuoiMu(_namSinh) % 9 == 1) return true;
            return false;
        }

        public static bool KeDo(Customers _customers)
        {
            return KeDo(_customers.YearOfBirth, _customers.Sex);
        }

        public static bool ThaiBach(int _namSinh, string _gioiTinh)
        {
            if (_gioiTinh == "Nữ" && TuoiMu(_namSinh) % 9 == 8) return true;
            else if (_gioiTinh == "Nam" && TuoiMu(_namSinh) % 9 == 4) return true;
            return false;
        }

        public static bool ThaiBach(Customers _customers)
        {
            return ThaiBach(_customers.YearOfBirth, _customers.Sex);
        }

        public static bool TamTai(int _namSinh)
        {
            int chiNam = DateTime.Now.Year % 12;
            int chiTuoi = _namSinh % 12;
            if ((chiTuoi == 0 || chiTuoi == 4 || chiTuoi == 8) && (chiNam == 6 || chiNam == 7 || chiNam == 8))
                return true;
            else if ((chiTuoi == 6 || chiTuoi == 10 || chiTuoi == 2) && (chiNam == 0 || chiNam == 1 || chiNam == 2))
                return true;
            else if ((chiTuoi == 9 || chiTuoi == 1 || chiTuoi == 5) && (chiNam == 3 || chiNam == 4 || chiNam == 5))
                return true;
            else if ((chiTuoi == 3 || chiTuoi == 7 || chiTuoi == 1) && (chiNam == 9 || chiNam == 10 || chiNam == 11))
                return true;
            return false;
        }

        public static bool TamTai(Customers _customers)
        {
            return TamTai(_customers.YearOfBirth);
        }

        public static string BanMenh(int _namSinh)
        {
            XDocument DB = XDocument.Parse(Properties.Resources.XMLres);
            string ketqua = DB.Root
                .Element("dsBanMenh")
                .Elements("BanMenh")
                .Where(x => x.Attribute("MaSo").Value == (_namSinh % 60).ToString())
                .FirstOrDefault().Value;
            return ketqua;
        }
        public static string BanMenh(Customers _customers)
        {
            return BanMenh(_customers.YearOfBirth);
        }

        public static string Menh(int _namSinh, string _gioiTinh)
        {
            XDocument DB = XDocument.Parse(Properties.Resources.XMLres);
            string ketqua = DB.Root
                .Element("dsMenh")
                .Elements("Menh")
                .Where(x => x.Attribute("MaSo").Value == (_namSinh % 60).ToString() && x.Attribute("GioiTinh").Value == _gioiTinh)
                .FirstOrDefault().Value;
            return ketqua;
        }
        public static string Menh(Customers _customers)
        {
            return Menh(_customers.YearOfBirth, _customers.Sex);
        }

        public static string Tien(int _namSinh)
        {
            XDocument DB = XDocument.Parse(Properties.Resources.XMLres);
            string ketqua = DB.Root
                .Element("dsTQTien")
                .Elements("TQTien")
                .Where(x => x.Attribute("MaSo").Value == (_namSinh % 60).ToString())
                .FirstOrDefault().Value;
            return ketqua;
        }

        public static string Tien(Customers _customers)
        {
            return Tien(_customers.YearOfBirth);
        }

        public static string Kinh(int _namSinh)
        {
            XDocument DB = XDocument.Parse(Properties.Resources.XMLres);
            string ketqua = DB.Root
                .Element("dsTQKinh")
                .Elements("TQKinh")
                .Where(x => x.Attribute("MaSo").Value == (_namSinh % 60).ToString())
                .FirstOrDefault().Value;
            return ketqua;
        }
        public static string Kinh(Customers _customers)
        {
            return Kinh(_customers.YearOfBirth);
        }

        public static string Kho(int _namSinh)
        {
            XDocument DB = XDocument.Parse(Properties.Resources.XMLres);
            string ketqua = DB.Root
                .Element("dsTQKho")
                .Elements("TQKho")
                .Where(x => x.Attribute("MaSo").Value == (_namSinh % 60).ToString())
                .FirstOrDefault().Value;
            return ketqua;
        }
        public static string Kho(Customers _customers)
        {
            return Kho(_customers.YearOfBirth);
        }

        public static string Chu(int _namSinh)
        {
            XDocument DB = XDocument.Parse(Properties.Resources.XMLres);
            string ketqua = DB.Root
                .Element("dsTQChuKho")
                .Elements("TQChuKho")
                .Where(x => x.Attribute("MaSo").Value == (_namSinh % 60).ToString())
                .FirstOrDefault().Value;
            return ketqua;
        }
        public static string Chu(Customers _customers)
        {
            return Chu(_customers.YearOfBirth);
        }

        public static string Them(int _namSinh)
        {
            XDocument DB = XDocument.Parse(Properties.Resources.XMLres);
            string ketqua = DB.Root
                .Element("dsTQTraThem")
                .Elements("TQTraThem")
                .Where(x => x.Attribute("MaSo").Value == (_namSinh % 60).ToString())
                .FirstOrDefault().Value;
            return ketqua;
        }
        public static string Them(Customers _customers)
        {
            return Them(_customers.YearOfBirth);
        }
    }
}