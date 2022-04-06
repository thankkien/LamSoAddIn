
namespace LamSoAddIn
{
    partial class FormAddresses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelID = new System.Windows.Forms.Label();
            this.dataGridViewAddresses = new System.Windows.Forms.DataGridView();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddresses)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(88, 490);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 3;
            // 
            // dataGridViewAddresses
            // 
            this.dataGridViewAddresses.AllowUserToAddRows = false;
            this.dataGridViewAddresses.AllowUserToDeleteRows = false;
            this.dataGridViewAddresses.AllowUserToResizeColumns = false;
            this.dataGridViewAddresses.AllowUserToResizeRows = false;
            this.dataGridViewAddresses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddresses.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAddresses.MultiSelect = false;
            this.dataGridViewAddresses.Name = "dataGridViewAddresses";
            this.dataGridViewAddresses.RowHeadersVisible = false;
            this.dataGridViewAddresses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewAddresses.Size = new System.Drawing.Size(710, 475);
            this.dataGridViewAddresses.TabIndex = 18;
            this.dataGridViewAddresses.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAddresses_CellMouseUp);
            // 
            // buttonLuu
            // 
            this.buttonLuu.Location = new System.Drawing.Point(647, 503);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(75, 23);
            this.buttonLuu.TabIndex = 20;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.ButtonLuu_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDel,
            this.toolStripMenuItemAdd});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(143, 48);
            // 
            // toolStripMenuItemDel
            // 
            this.toolStripMenuItemDel.Name = "toolStripMenuItemDel";
            this.toolStripMenuItemDel.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItemDel.Text = "Xóa địa chỉ";
            this.toolStripMenuItemDel.Click += new System.EventHandler(this.toolStripMenuItemDel_Click);
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItemAdd.Text = "Thêm địa chỉ";
            this.toolStripMenuItemAdd.Click += new System.EventHandler(this.toolStripMenuItemAdd_Click);
            // 
            // FormAddresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 538);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.dataGridViewAddresses);
            this.Controls.Add(this.labelID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddresses";
            this.Text = "Quản Lý Địa Chỉ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddresses_FormClosing);
            this.Load += new System.EventHandler(this.FormInputAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddresses)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.DataGridView dataGridViewAddresses;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;
    }
}