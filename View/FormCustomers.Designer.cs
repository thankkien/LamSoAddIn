
namespace LamSoAddIn
{
    partial class FormCustomer
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
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewFamilies = new System.Windows.Forms.DataGridView();
            this.contextMenuStripCustomers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDelCus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddCus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemParseCus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelFa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddFa = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripFamilies = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamilies)).BeginInit();
            this.contextMenuStripCustomers.SuspendLayout();
            this.contextMenuStripFamilies.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            this.dataGridViewCustomers.AllowUserToResizeColumns = false;
            this.dataGridViewCustomers.AllowUserToResizeRows = false;
            this.dataGridViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(778, 37);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowHeadersVisible = false;
            this.dataGridViewCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(394, 511);
            this.dataGridViewCustomers.TabIndex = 2;
            this.dataGridViewCustomers.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCustomers_CellMouseUp);
            // 
            // buttonLuu
            // 
            this.buttonLuu.Location = new System.Drawing.Point(941, 9);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(75, 23);
            this.buttonLuu.TabIndex = 9;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.ButtonLuu_Click);
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.Location = new System.Drawing.Point(119, 11);
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.Size = new System.Drawing.Size(454, 20);
            this.textBoxKeyword.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(579, 8);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Tìm Tiếp";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewFamilies
            // 
            this.dataGridViewFamilies.AllowUserToAddRows = false;
            this.dataGridViewFamilies.AllowUserToDeleteRows = false;
            this.dataGridViewFamilies.AllowUserToResizeColumns = false;
            this.dataGridViewFamilies.AllowUserToResizeRows = false;
            this.dataGridViewFamilies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFamilies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFamilies.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewFamilies.MultiSelect = false;
            this.dataGridViewFamilies.Name = "dataGridViewFamilies";
            this.dataGridViewFamilies.RowHeadersVisible = false;
            this.dataGridViewFamilies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewFamilies.Size = new System.Drawing.Size(760, 513);
            this.dataGridViewFamilies.TabIndex = 24;
            this.dataGridViewFamilies.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFamilies_CellMouseUp);
            // 
            // contextMenuStripCustomers
            // 
            this.contextMenuStripCustomers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDelCus,
            this.toolStripMenuItemAddCus,
            this.toolStripMenuItemParseCus});
            this.contextMenuStripCustomers.Name = "contextMenuStripCustomers";
            this.contextMenuStripCustomers.Size = new System.Drawing.Size(140, 70);
            // 
            // toolStripMenuItemDelCus
            // 
            this.toolStripMenuItemDelCus.Name = "toolStripMenuItemDelCus";
            this.toolStripMenuItemDelCus.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItemDelCus.Text = "Xóa khách";
            this.toolStripMenuItemDelCus.Click += new System.EventHandler(this.toolStripMenuItemDelCus_Click);
            // 
            // toolStripMenuItemAddCus
            // 
            this.toolStripMenuItemAddCus.Name = "toolStripMenuItemAddCus";
            this.toolStripMenuItemAddCus.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItemAddCus.Text = "Thêm khách";
            this.toolStripMenuItemAddCus.Click += new System.EventHandler(this.toolStripMenuItemAddCus_Click);
            // 
            // toolStripMenuItemParseCus
            // 
            this.toolStripMenuItemParseCus.Name = "toolStripMenuItemParseCus";
            this.toolStripMenuItemParseCus.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItemParseCus.Text = "Dán";
            this.toolStripMenuItemParseCus.Click += new System.EventHandler(this.toolStripMenuItemParseCus_Click);
            // 
            // toolStripMenuItemDelFa
            // 
            this.toolStripMenuItemDelFa.Name = "toolStripMenuItemDelFa";
            this.toolStripMenuItemDelFa.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItemDelFa.Text = "Xóa hộ";
            this.toolStripMenuItemDelFa.Click += new System.EventHandler(this.toolStripMenuItemDelFa_Click);
            // 
            // toolStripMenuItemAddFa
            // 
            this.toolStripMenuItemAddFa.Name = "toolStripMenuItemAddFa";
            this.toolStripMenuItemAddFa.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItemAddFa.Text = "Thêm hộ";
            this.toolStripMenuItemAddFa.Click += new System.EventHandler(this.toolStripMenuItemAddFa_Click);
            // 
            // contextMenuStripFamilies
            // 
            this.contextMenuStripFamilies.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDelFa,
            this.toolStripMenuItemAddFa});
            this.contextMenuStripFamilies.Name = "contextMenuStripFamilies";
            this.contextMenuStripFamilies.Size = new System.Drawing.Size(122, 48);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.dataGridViewFamilies);
            this.Controls.Add(this.textBoxKeyword);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.dataGridViewCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCustomer";
            this.Text = "Quản lý khách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCustomer_FormClosing);
            this.Load += new System.EventHandler(this.FormKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamilies)).EndInit();
            this.contextMenuStripCustomers.ResumeLayout(false);
            this.contextMenuStripFamilies.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.TextBox textBoxKeyword;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewFamilies;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCustomers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelCus;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelFa;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddFa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFamilies;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddCus;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemParseCus;
    }
}