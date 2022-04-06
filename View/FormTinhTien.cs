using LamSoAddIn.Controller;
using System;
using System.Windows.Forms;

namespace LamSoAddIn
{
    public partial class FormTinhTien : Form
    {
        public FormTinhTien()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTinhTien_Click(object sender, EventArgs e)
        {
            ExportBill.XuatHoaDon();
            this.Close();
        }

        private void FormTinhTien_Load(object sender, EventArgs e)
        {
            numericUpDownHo.Maximum = Decimal.MaxValue;
            numericUpDownThaiBach.Maximum = Decimal.MaxValue;
            numericUpDownLaHau.Maximum = Decimal.MaxValue;
            numericUpDownKeDo.Maximum = Decimal.MaxValue;
            numericUpDownTamTai.Maximum = Decimal.MaxValue;
            numericUpDownHo.Text = ExportBill._costH.ToString();
            numericUpDownThaiBach.Text = ExportBill._costTB.ToString();
            numericUpDownLaHau.Text = ExportBill._costLH.ToString();
            numericUpDownKeDo.Text = ExportBill._costKD.ToString();
            numericUpDownTamTai.Text = ExportBill._costTT.ToString();
        }

        private void numericUpDownHo_ValueChanged(object sender, EventArgs e)
        {
            ExportBill._costH = (ulong)numericUpDownHo.Value;
        }

        private void numericUpDownThaiBach_ValueChanged(object sender, EventArgs e)
        {

            ExportBill._costTB = (ulong)numericUpDownThaiBach.Value;
        }

        private void numericUpDownLaHau_ValueChanged(object sender, EventArgs e)
        {
            ExportBill._costLH = (ulong)numericUpDownLaHau.Value;
        }

        private void numericUpDownKeDo_ValueChanged(object sender, EventArgs e)
        {
            ExportBill._costKD = (ulong)numericUpDownKeDo.Value;
        }

        private void numericUpDownTamTai_ValueChanged(object sender, EventArgs e)
        {
            ExportBill._costTT = (ulong)numericUpDownTamTai.Value;
        }
    }
}
