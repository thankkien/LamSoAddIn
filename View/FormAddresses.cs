using LamSoAddIn.Controller;
using LamSoAddIn.Model;
using System;
using System.Windows.Forms;


namespace LamSoAddIn
{
    public partial class FormAddresses : Form
    {
        private bool _isDel = false;
        private readonly BindingSource addressesBS = new BindingSource(XDoc.ReadAddresses(), null);

        public FormAddresses()
        {
            InitializeComponent();
        }

        private void FormInputAddress_Load(object sender, EventArgs e)
        {
            dataGridViewAddresses.DataSource = addressesBS;
            dataGridViewAddresses.Columns[0].Width = 150;
            dataGridViewAddresses.Columns[0].ReadOnly = true;
            addressesBS.CurrentItemChanged += Bs_CurrentItemChanged;
        }

        private void Bs_CurrentItemChanged(object sender, EventArgs e)
        {
            if (addressesBS.Count != 0 && ((Addresses)addressesBS.Current).ID != "")
                if (!_isDel)
                {
                    Addresses _now = new Addresses()
                    {
                        ID = ((Addresses)addressesBS.Current).ID,
                        Living = ((Addresses)addressesBS.Current).Living
                    };
                    XDoc.UpdateAddress(_now);
                    _isDel = false;
                }
        }

        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            if (addressesBS.Count != 0)
            {
                _isDel = true;
                XDoc.RemoveAddress(((Addresses)addressesBS.Current).ID);
                addressesBS.RemoveCurrent();
            }
        }

        private void ButtonThem_Click_1(object sender, EventArgs e)
        {
            addressesBS.AddNew();
        }

        private void ButtonLuu_Click(object sender, EventArgs e)
        {
            XDoc.Save();
        }

        private void FormAddresses_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XDoc.Changed)
            {
                if (e.CloseReason == CloseReason.WindowsShutDown) XDoc.BackupSave();
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (MessageBox.Show("Thoát mà không lưu dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        e.Cancel = false;
                    }
                }
            }
        }

        private void toolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            addressesBS.AddNew();
        }

        private void toolStripMenuItemDel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Nhấn yes để xóa địa chỉ và các hộ gia đình, khách liên quan", "Xác nhận xóa địa chỉ này?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (addressesBS.Count != 0)
                {
                    _isDel = true;
                    XDoc.RemoveAddress(((Addresses)addressesBS.Current).ID);
                    addressesBS.RemoveCurrent();
                }
            }
        }

        private void dataGridViewAddresses_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    dataGridViewAddresses.Rows[e.RowIndex].Selected = true;
                    toolStripMenuItemDel.Visible = true;
                }
                else toolStripMenuItemDel.Visible = false;
                contextMenuStrip.Show(dataGridViewAddresses, e.Location);
                contextMenuStrip.Show(Cursor.Position);
            }
        }
    }
}
