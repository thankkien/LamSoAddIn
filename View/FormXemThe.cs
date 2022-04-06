using LamSoAddIn.Controller;
using LamSoAddIn.Model;
using System;
using System.Windows.Forms;

namespace LamSoAddIn
{
    public partial class FormXemThe : Form
    {
        public FormXemThe()
        {
            InitializeComponent();
        }

        private void TheXam_Load(int value)
        {
            if (value >= 1 && value <= 100)
            {
                TheXamLinhUng the = XemTheXam.XemThe((int)numericUpDownSoThe.Value);
                labelSoThe.Text = "Số thẻ: " + the.SoThe;
                labelHang.Text = "Hạng: " + the.XepHang();
                labelXamChu.Text = "Xâm chữ:\r\n" + the.XamChu;
                labelYNghia.Text = "Ý nghĩa:\r\n" + the.YNghia;
                labelNoiDungThem.Text = "Thánh ý: " + the.ThanhY + "\r\nChiếu nghiệm: " + the.ChieuNghiem + "\r\nCổ nhân: " + the.CoNhan + "\r\nLời bàn của dịch giả: " + the.LoiBanCuaDichGia;
            }
        }

        private void numericUpDownSoThe_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericUpDownSoThe.Value > 100) numericUpDownSoThe.Value = 100;
            else if ((int)numericUpDownSoThe.Value < 1) numericUpDownSoThe.Value = 1;
            else TheXam_Load((int)numericUpDownSoThe.Value);
        }

        private void FormXemThe_Load(object sender, EventArgs e)
        {
            TheXam_Load(1);
        }
    }
}
