
namespace LamSoAddIn
{
    partial class FormChuyenDoc
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
            this.radioButtonHoten = new System.Windows.Forms.RadioButton();
            this.radioButtonDiaChi = new System.Windows.Forms.RadioButton();
            this.radioButtonCanTrai = new System.Windows.Forms.RadioButton();
            this.radioButtonCanPhai = new System.Windows.Forms.RadioButton();
            this.label = new System.Windows.Forms.Label();
            this.buttonChuyenDoc = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownHang = new System.Windows.Forms.NumericUpDown();
            this.groupBoxNoiDung = new System.Windows.Forms.GroupBox();
            this.groupBoxCanLe = new System.Windows.Forms.GroupBox();
            this.radioButtonFamilies = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHang)).BeginInit();
            this.groupBoxNoiDung.SuspendLayout();
            this.groupBoxCanLe.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonHoten
            // 
            this.radioButtonHoten.AutoSize = true;
            this.radioButtonHoten.Checked = true;
            this.radioButtonHoten.Location = new System.Drawing.Point(13, 19);
            this.radioButtonHoten.Name = "radioButtonHoten";
            this.radioButtonHoten.Size = new System.Drawing.Size(90, 17);
            this.radioButtonHoten.TabIndex = 0;
            this.radioButtonHoten.TabStop = true;
            this.radioButtonHoten.Text = "Họ tên khách";
            this.radioButtonHoten.UseVisualStyleBackColor = true;
            this.radioButtonHoten.CheckedChanged += new System.EventHandler(this.radioButtonHoten_CheckedChanged);
            // 
            // radioButtonDiaChi
            // 
            this.radioButtonDiaChi.AutoSize = true;
            this.radioButtonDiaChi.Location = new System.Drawing.Point(105, 19);
            this.radioButtonDiaChi.Name = "radioButtonDiaChi";
            this.radioButtonDiaChi.Size = new System.Drawing.Size(58, 17);
            this.radioButtonDiaChi.TabIndex = 0;
            this.radioButtonDiaChi.Text = "Địa chỉ";
            this.radioButtonDiaChi.UseVisualStyleBackColor = true;
            this.radioButtonDiaChi.CheckedChanged += new System.EventHandler(this.radioButtonDiaChi_CheckedChanged);
            // 
            // radioButtonCanTrai
            // 
            this.radioButtonCanTrai.AutoSize = true;
            this.radioButtonCanTrai.Checked = true;
            this.radioButtonCanTrai.Location = new System.Drawing.Point(14, 19);
            this.radioButtonCanTrai.Name = "radioButtonCanTrai";
            this.radioButtonCanTrai.Size = new System.Drawing.Size(72, 17);
            this.radioButtonCanTrai.TabIndex = 0;
            this.radioButtonCanTrai.TabStop = true;
            this.radioButtonCanTrai.Text = "Căn lề trái";
            this.radioButtonCanTrai.UseVisualStyleBackColor = true;
            this.radioButtonCanTrai.CheckedChanged += new System.EventHandler(this.radioButtonCanTrai_CheckedChanged);
            // 
            // radioButtonCanPhai
            // 
            this.radioButtonCanPhai.AutoSize = true;
            this.radioButtonCanPhai.Location = new System.Drawing.Point(105, 19);
            this.radioButtonCanPhai.Name = "radioButtonCanPhai";
            this.radioButtonCanPhai.Size = new System.Drawing.Size(78, 17);
            this.radioButtonCanPhai.TabIndex = 0;
            this.radioButtonCanPhai.Text = "Căn lề phải";
            this.radioButtonCanPhai.UseVisualStyleBackColor = true;
            this.radioButtonCanPhai.CheckedChanged += new System.EventHandler(this.radioButtonCanPhai_CheckedChanged);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(200, 30);
            this.label.TabIndex = 2;
            this.label.Text = "Lựa chọn các mục phù hợp với nội dung cần thiết.";
            // 
            // buttonChuyenDoc
            // 
            this.buttonChuyenDoc.Location = new System.Drawing.Point(22, 189);
            this.buttonChuyenDoc.Name = "buttonChuyenDoc";
            this.buttonChuyenDoc.Size = new System.Drawing.Size(82, 23);
            this.buttonChuyenDoc.TabIndex = 3;
            this.buttonChuyenDoc.Text = "Chuyển dọc";
            this.buttonChuyenDoc.UseVisualStyleBackColor = true;
            this.buttonChuyenDoc.Click += new System.EventHandler(this.buttonChuyenDoc_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(120, 189);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 4;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số hàng";
            // 
            // numericUpDownHang
            // 
            this.numericUpDownHang.Location = new System.Drawing.Point(75, 163);
            this.numericUpDownHang.Name = "numericUpDownHang";
            this.numericUpDownHang.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownHang.TabIndex = 6;
            this.numericUpDownHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownHang.ValueChanged += new System.EventHandler(this.numericUpDownHang_ValueChanged);
            // 
            // groupBoxNoiDung
            // 
            this.groupBoxNoiDung.Controls.Add(this.radioButtonHoten);
            this.groupBoxNoiDung.Controls.Add(this.radioButtonFamilies);
            this.groupBoxNoiDung.Controls.Add(this.radioButtonDiaChi);
            this.groupBoxNoiDung.Location = new System.Drawing.Point(12, 42);
            this.groupBoxNoiDung.Name = "groupBoxNoiDung";
            this.groupBoxNoiDung.Size = new System.Drawing.Size(200, 63);
            this.groupBoxNoiDung.TabIndex = 7;
            this.groupBoxNoiDung.TabStop = false;
            this.groupBoxNoiDung.Text = "Nội dung";
            // 
            // groupBoxCanLe
            // 
            this.groupBoxCanLe.Controls.Add(this.radioButtonCanPhai);
            this.groupBoxCanLe.Controls.Add(this.radioButtonCanTrai);
            this.groupBoxCanLe.Location = new System.Drawing.Point(12, 111);
            this.groupBoxCanLe.Name = "groupBoxCanLe";
            this.groupBoxCanLe.Size = new System.Drawing.Size(200, 46);
            this.groupBoxCanLe.TabIndex = 8;
            this.groupBoxCanLe.TabStop = false;
            this.groupBoxCanLe.Text = "Căn lề";
            // 
            // radioButtonFamilies
            // 
            this.radioButtonFamilies.AutoSize = true;
            this.radioButtonFamilies.Location = new System.Drawing.Point(13, 42);
            this.radioButtonFamilies.Name = "radioButtonFamilies";
            this.radioButtonFamilies.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFamilies.TabIndex = 0;
            this.radioButtonFamilies.Text = "Chủ hộ";
            this.radioButtonFamilies.UseVisualStyleBackColor = true;
            this.radioButtonFamilies.CheckedChanged += new System.EventHandler(this.radioButtonFamilies_CheckedChanged);
            // 
            // FormChuyenDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(225, 225);
            this.Controls.Add(this.groupBoxCanLe);
            this.Controls.Add(this.groupBoxNoiDung);
            this.Controls.Add(this.numericUpDownHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonChuyenDoc);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChuyenDoc";
            this.Text = "Chuyển dọc";
            this.Load += new System.EventHandler(this.FormChuyenDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHang)).EndInit();
            this.groupBoxNoiDung.ResumeLayout(false);
            this.groupBoxNoiDung.PerformLayout();
            this.groupBoxCanLe.ResumeLayout(false);
            this.groupBoxCanLe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonHoten;
        private System.Windows.Forms.RadioButton radioButtonDiaChi;
        private System.Windows.Forms.RadioButton radioButtonCanTrai;
        private System.Windows.Forms.RadioButton radioButtonCanPhai;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonChuyenDoc;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownHang;
        private System.Windows.Forms.GroupBox groupBoxNoiDung;
        private System.Windows.Forms.GroupBox groupBoxCanLe;
        private System.Windows.Forms.RadioButton radioButtonFamilies;
    }
}