namespace LamSoAddIn.Model
{
    class TheXamLinhUng
    {
        public enum Hang
        {
            KhongRo,
            DaiKiet,
            ThuongKiet,
            TrungKiet,
            HaHa,
            TrungBinh,
            ThuongThuong,
        }
        private int _soThe;
        private int _xepHang;
        private string _xamChu;
        private string _yNghia;
        private string _thanhY;
        private string _chieuNghiem;
        private string _coNhan;
        private string _loiBanCuaDichGia;
        public int SoThe
        {
            set { _soThe = value; }
            get { return _soThe; }
        }
        public int XetHang
        {
            set { _xepHang = value; }
            get { return _xepHang; }
        }

        public string XepHang()
        {
            if (_xepHang == (int)Hang.KhongRo) return "Không Rõ";
            else if (_xepHang == (int)Hang.DaiKiet) return "Đại Kiết";
            else if (_xepHang == (int)Hang.ThuongKiet) return "Thượng Kiết";
            else if (_xepHang == (int)Hang.TrungKiet) return "Trung Kiết";
            else if (_xepHang == (int)Hang.HaHa) return "Hạ Hạ";
            else if (_xepHang == (int)Hang.TrungBinh) return "Trung Bình";
            else return "Thượng Thượng";
        }
        public string XamChu
        {
            set { _xamChu = value; }
            get { return _xamChu; }
        }
        public string YNghia
        {
            set { _yNghia = value; }
            get { return _yNghia; }
        }
        public string ThanhY
        {
            set { _thanhY = value; }
            get { return _thanhY; }
        }
        public string ChieuNghiem
        {
            set { _chieuNghiem = value; }
            get { return _chieuNghiem; }
        }
        public string CoNhan
        {
            set { _coNhan = value; }
            get { return _coNhan; }
        }
        public string LoiBanCuaDichGia
        {
            set { _loiBanCuaDichGia = value; }
            get { return _loiBanCuaDichGia; }
        }
    }
}
