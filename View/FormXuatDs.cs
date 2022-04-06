using LamSoAddIn.Controller;
using System;
using System.Windows.Forms;
namespace LamSoAddIn
{
    public partial class FormXuatDs : Form
    {
        public FormXuatDs()
        {
            InitializeComponent();
        }

        private void FormXuatDs_Load(object sender, EventArgs e)
        {
            checkBoxHoGD.Checked = ExportList.HoGD;
            checkBoxDiaChi.Checked = ExportList.NoiO;
            checkBoxTuoiMu1.Checked = ExportList.TuoiMu1;
            checkBoxTuoiMu2.Checked = ExportList.TuoiMu2;
            checkBoxCanChi.Checked = ExportList.CanChi;
            checkBoxSao.Checked = ExportList.Sao;
            checkBoxHan.Checked = ExportList.Han;
            checkBoxVan.Checked = ExportList.Van;
            checkBoxChuMenh.Checked = ExportList.ChuMenh;
            checkBoxDongLam.Checked = ExportList.DongLam;
            checkBoxBanMenh.Checked = ExportList.BanMenh;
            checkBoxMenh.Checked = ExportList.Menh;
            checkBoxTien.Checked = ExportList.Tien;
            checkBoxKinh.Checked = ExportList.Kinh;
            checkBoxKho.Checked = ExportList.Kho;
            checkBoxChu.Checked = ExportList.Chu;
            checkBoxThem.Checked = ExportList.Them;
        }

        private void checkBoxHoGD_CheckedChanged(object sender, EventArgs e)
        {
            ExportList.HoGD = checkBoxHoGD.Checked;
        }

        private void checkBoxDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            ExportList.NoiO = checkBoxDiaChi.Checked;
        }

        private void checkBoxTuoiMu1_CheckedChanged(object sender, EventArgs e)
        {
            ExportList.TuoiMu1 = checkBoxTuoiMu1.Checked;
        }

        private void checkBoxTuoiMu2_CheckedChanged(object sender, EventArgs e)
        {
            ExportList.TuoiMu2 = checkBoxTuoiMu2.Checked;
        }

        private void checkBoxCanChi_CheckedChanged(object sender, EventArgs e)
        {
            ExportList.CanChi = checkBoxCanChi.Checked;
        }

        private void checkBoxSao_CheckedChanged(object sender, EventArgs e)
        {
            ExportList.Sao = checkBoxSao.Checked;
        }

        private void checkBoxHan_CheckedChanged(object sender, EventArgs e)
        {
            ExportList.Han = checkBoxHan.Checked;
        }

        private void checkBoxVan_CheckedChanged(object sender, EventArgs e)
        {
            ExportList.Van = checkBoxVan.Checked;
        }

        private void checkBoxChuMenh_CheckedChanged(object sender, EventArgs e)
        {
            ExportList.ChuMenh = checkBoxChuMenh.Checked;
        }

        private void checkBoxBanMenh_CheckedChanged(object sender, EventArgs e)
        {
            ExportList.BanMenh = checkBoxBanMenh.Checked;
        }

        private void checkBoxMenh_CheckedChanged(object sender, EventArgs e)
        {
            ExportList.Menh = checkBoxMenh.Checked;
        }

        private void checkBoxTien_CheckedChanged(object sender, EventArgs e)
        {
            ExportList.Tien = checkBoxTien.Checked;
        }

        private void checkBoxKinh_CheckedChanged(object sender, EventArgs e)
        {
            ExportList.Kinh = checkBoxKinh.Checked;
        }

        private void checkBoxKho_CheckedChanged(object sender, EventArgs e)
        {
            ExportList.Kho = checkBoxKho.Checked;
        }

        private void checkBoxChu_CheckedChanged(object sender, EventArgs e)
        {
            ExportList.Chu = checkBoxChu.Checked;
        }

        private void checkBoxThem_CheckedChanged(object sender, EventArgs e)
        {
            ExportList.Them = checkBoxThem.Checked;
        }

        private void checkBoxDongLam_CheckedChanged(object sender, EventArgs e)
        {
            ExportList.DongLam = checkBoxDongLam.Checked;
        }

        private void buttonXuat_Click(object sender, EventArgs e)
        {
            ExportList.XuatDanhSach();
            this.Close();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
