
namespace LamSoAddIn
{
    partial class FormTinhTien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonTinhTien = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownHo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownThaiBach = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLaHau = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKeDo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTamTai = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThaiBach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLaHau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTamTai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thái Bạch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "La Hầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kế Đô";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tam Tai";
            // 
            // buttonTinhTien
            // 
            this.buttonTinhTien.Location = new System.Drawing.Point(17, 164);
            this.buttonTinhTien.Name = "buttonTinhTien";
            this.buttonTinhTien.Size = new System.Drawing.Size(75, 23);
            this.buttonTinhTien.TabIndex = 5;
            this.buttonTinhTien.Text = "Tính Tiền";
            this.buttonTinhTien.UseVisualStyleBackColor = true;
            this.buttonTinhTien.Click += new System.EventHandler(this.buttonTinhTien_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(101, 164);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 6;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hộ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nhập số tiền đơn vị";
            // 
            // numericUpDownHo
            // 
            this.numericUpDownHo.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownHo.Location = new System.Drawing.Point(76, 35);
            this.numericUpDownHo.Name = "numericUpDownHo";
            this.numericUpDownHo.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownHo.TabIndex = 0;
            this.numericUpDownHo.ValueChanged += new System.EventHandler(this.numericUpDownHo_ValueChanged);
            // 
            // numericUpDownThaiBach
            // 
            this.numericUpDownThaiBach.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownThaiBach.Location = new System.Drawing.Point(76, 61);
            this.numericUpDownThaiBach.Name = "numericUpDownThaiBach";
            this.numericUpDownThaiBach.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownThaiBach.TabIndex = 1;
            this.numericUpDownThaiBach.ValueChanged += new System.EventHandler(this.numericUpDownThaiBach_ValueChanged);
            // 
            // numericUpDownLaHau
            // 
            this.numericUpDownLaHau.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLaHau.Location = new System.Drawing.Point(76, 86);
            this.numericUpDownLaHau.Name = "numericUpDownLaHau";
            this.numericUpDownLaHau.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownLaHau.TabIndex = 2;
            this.numericUpDownLaHau.ValueChanged += new System.EventHandler(this.numericUpDownLaHau_ValueChanged);
            // 
            // numericUpDownKeDo
            // 
            this.numericUpDownKeDo.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownKeDo.Location = new System.Drawing.Point(76, 112);
            this.numericUpDownKeDo.Name = "numericUpDownKeDo";
            this.numericUpDownKeDo.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownKeDo.TabIndex = 3;
            this.numericUpDownKeDo.ValueChanged += new System.EventHandler(this.numericUpDownKeDo_ValueChanged);
            // 
            // numericUpDownTamTai
            // 
            this.numericUpDownTamTai.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTamTai.Location = new System.Drawing.Point(76, 139);
            this.numericUpDownTamTai.Name = "numericUpDownTamTai";
            this.numericUpDownTamTai.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownTamTai.TabIndex = 4;
            this.numericUpDownTamTai.ValueChanged += new System.EventHandler(this.numericUpDownTamTai_ValueChanged);
            // 
            // FormTinhTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 200);
            this.Controls.Add(this.numericUpDownTamTai);
            this.Controls.Add(this.numericUpDownKeDo);
            this.Controls.Add(this.numericUpDownLaHau);
            this.Controls.Add(this.numericUpDownThaiBach);
            this.Controls.Add(this.numericUpDownHo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonTinhTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTinhTien";
            this.Text = "Tính Tiền Sớ Tết";
            this.Load += new System.EventHandler(this.FormTinhTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThaiBach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLaHau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTamTai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonTinhTien;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownHo;
        private System.Windows.Forms.NumericUpDown numericUpDownThaiBach;
        private System.Windows.Forms.NumericUpDown numericUpDownLaHau;
        private System.Windows.Forms.NumericUpDown numericUpDownKeDo;
        private System.Windows.Forms.NumericUpDown numericUpDownTamTai;
    }
}