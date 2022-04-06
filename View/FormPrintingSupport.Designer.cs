
namespace LamSoAddIn
{
    partial class FormPrintingSupport
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
            this.dataGridViewKhach = new System.Windows.Forms.DataGridView();
            this.buttonPrintOut = new System.Windows.Forms.Button();
            this.dataGridViewFeature = new System.Windows.Forms.DataGridView();
            this.dataGridViewFamilies = new System.Windows.Forms.DataGridView();
            this.numericUpDownLimitRow = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSheetsList = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamilies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimitRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSheetsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKhach
            // 
            this.dataGridViewKhach.AllowUserToAddRows = false;
            this.dataGridViewKhach.AllowUserToDeleteRows = false;
            this.dataGridViewKhach.AllowUserToResizeColumns = false;
            this.dataGridViewKhach.AllowUserToResizeRows = false;
            this.dataGridViewKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhach.Location = new System.Drawing.Point(12, 350);
            this.dataGridViewKhach.MultiSelect = false;
            this.dataGridViewKhach.Name = "dataGridViewKhach";
            this.dataGridViewKhach.ReadOnly = true;
            this.dataGridViewKhach.RowHeadersVisible = false;
            this.dataGridViewKhach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKhach.Size = new System.Drawing.Size(451, 199);
            this.dataGridViewKhach.TabIndex = 19;
            // 
            // buttonPrintOut
            // 
            this.buttonPrintOut.Location = new System.Drawing.Point(783, 321);
            this.buttonPrintOut.Name = "buttonPrintOut";
            this.buttonPrintOut.Size = new System.Drawing.Size(75, 23);
            this.buttonPrintOut.TabIndex = 22;
            this.buttonPrintOut.Text = "In sớ";
            this.buttonPrintOut.UseVisualStyleBackColor = true;
            this.buttonPrintOut.Click += new System.EventHandler(this.ButtonPrintOut_Click);
            // 
            // dataGridViewFeature
            // 
            this.dataGridViewFeature.AllowUserToAddRows = false;
            this.dataGridViewFeature.AllowUserToDeleteRows = false;
            this.dataGridViewFeature.AllowUserToResizeColumns = false;
            this.dataGridViewFeature.AllowUserToResizeRows = false;
            this.dataGridViewFeature.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFeature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFeature.Location = new System.Drawing.Point(469, 350);
            this.dataGridViewFeature.MultiSelect = false;
            this.dataGridViewFeature.Name = "dataGridViewFeature";
            this.dataGridViewFeature.ReadOnly = true;
            this.dataGridViewFeature.RowHeadersVisible = false;
            this.dataGridViewFeature.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFeature.Size = new System.Drawing.Size(400, 199);
            this.dataGridViewFeature.TabIndex = 25;
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
            this.dataGridViewFamilies.ReadOnly = true;
            this.dataGridViewFamilies.RowHeadersVisible = false;
            this.dataGridViewFamilies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFamilies.Size = new System.Drawing.Size(663, 306);
            this.dataGridViewFamilies.TabIndex = 23;
            // 
            // numericUpDownLimitRow
            // 
            this.numericUpDownLimitRow.Location = new System.Drawing.Point(704, 324);
            this.numericUpDownLimitRow.Name = "numericUpDownLimitRow";
            this.numericUpDownLimitRow.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownLimitRow.TabIndex = 26;
            this.numericUpDownLimitRow.ValueChanged += new System.EventHandler(this.numericUpDownLimitRow_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(701, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Giới hạn dòng:";
            // 
            // dataGridViewSheetsList
            // 
            this.dataGridViewSheetsList.AllowUserToAddRows = false;
            this.dataGridViewSheetsList.AllowUserToDeleteRows = false;
            this.dataGridViewSheetsList.AllowUserToResizeColumns = false;
            this.dataGridViewSheetsList.AllowUserToResizeRows = false;
            this.dataGridViewSheetsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSheetsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSheetsList.Location = new System.Drawing.Point(681, 12);
            this.dataGridViewSheetsList.MultiSelect = false;
            this.dataGridViewSheetsList.Name = "dataGridViewSheetsList";
            this.dataGridViewSheetsList.RowHeadersVisible = false;
            this.dataGridViewSheetsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSheetsList.Size = new System.Drawing.Size(188, 293);
            this.dataGridViewSheetsList.TabIndex = 28;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(534, 9);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 29;
            this.buttonSearch.Text = "Tìm Tiếp";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.Location = new System.Drawing.Point(74, 12);
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.Size = new System.Drawing.Size(454, 20);
            this.textBoxKeyword.TabIndex = 30;
            // 
            // FormPrintingSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.textBoxKeyword);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridViewSheetsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownLimitRow);
            this.Controls.Add(this.dataGridViewFeature);
            this.Controls.Add(this.dataGridViewFamilies);
            this.Controls.Add(this.buttonPrintOut);
            this.Controls.Add(this.dataGridViewKhach);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrintingSupport";
            this.Text = "     ";
            this.Load += new System.EventHandler(this.FormPrintingSupport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamilies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimitRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSheetsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewKhach;
        private System.Windows.Forms.Button buttonPrintOut;
        private System.Windows.Forms.DataGridView dataGridViewFeature;
        private System.Windows.Forms.DataGridView dataGridViewFamilies;
        private System.Windows.Forms.NumericUpDown numericUpDownLimitRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSheetsList;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxKeyword;
    }
}