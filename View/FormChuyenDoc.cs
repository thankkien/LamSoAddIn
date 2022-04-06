using LamSoAddIn.Controller;
using System;
using System.Windows.Forms;

namespace LamSoAddIn
{
    public partial class FormChuyenDoc : Form
    {
        private int Content = (int)Transpose.Loai.TENKHACH;
        private int Align = (int)Transpose.CanLe.TRAIsangPHAI;
        private int RowCount = 10;
        public FormChuyenDoc()
        {
            InitializeComponent();
        }

        private void FormChuyenDoc_Load(object sender, EventArgs e)
        {
            numericUpDownHang.Text = RowCount.ToString();
            numericUpDownHang.Minimum = 10;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChuyenDoc_Click(object sender, EventArgs e)
        {
            Transpose.ChuyenDoc(Content, Align, RowCount);
            this.Close();
        }

        private void radioButtonHoten_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHoten.Checked == true) Content = (int)Transpose.Loai.TENKHACH;
        }

        private void radioButtonDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDiaChi.Checked == true) Content = (int)Transpose.Loai.DIACHI;
        }

        private void radioButtonFamilies_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFamilies.Checked == true) Content = (int)Transpose.Loai.CHUHO;
        }

        private void radioButtonCanTrai_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCanTrai.Checked == true) Align = (int)Transpose.CanLe.TRAIsangPHAI;
        }

        private void radioButtonCanPhai_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCanPhai.Checked == true) Align = (int)Transpose.CanLe.PHAIsangTRAI;
        }

        private void numericUpDownHang_ValueChanged(object sender, EventArgs e)
        {
            RowCount = (int)numericUpDownHang.Value;
        }
    }
}
