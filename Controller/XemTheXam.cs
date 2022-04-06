using LamSoAddIn.Model;
using System.Linq;
using System.Xml.Linq;

namespace LamSoAddIn.Controller
{
    class XemTheXam
    {
        public static TheXamLinhUng XemThe(int _soThe)
        {
            XDocument DB = XDocument.Parse(Properties.Resources.XMLres);
            TheXamLinhUng ketqua = (from _theXam in DB.Root.Elements("DanhSachTheXam").Elements("TheXam")
                                    where _theXam.Attribute("SoThe").Value == _soThe.ToString()
                                    select new TheXamLinhUng()
                                    {
                                        SoThe = (int)_theXam.Attribute("SoThe"),
                                        XetHang = (int)_theXam.Element("Hang"),
                                        XamChu = (string)_theXam.Element("XamChu"),
                                        YNghia = (string)_theXam.Element("YNghia"),
                                        ThanhY = (string)_theXam.Element("ThanhY"),
                                        ChieuNghiem = (string)_theXam.Element("ChieuNghiem"),
                                        CoNhan = (string)_theXam.Element("CoNhan"),
                                        LoiBanCuaDichGia = (string)_theXam.Element("LoiBanCuaDichGia")
                                    }).FirstOrDefault();
            return ketqua;
        }
    }
}
