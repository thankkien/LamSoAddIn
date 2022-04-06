
namespace LamSoAddIn
{
    partial class FormXemThe
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
            this.numericUpDownSoThe = new System.Windows.Forms.NumericUpDown();
            this.labelSoThe = new System.Windows.Forms.Label();
            this.labelHang = new System.Windows.Forms.Label();
            this.labelXamChu = new System.Windows.Forms.Label();
            this.labelYNghia = new System.Windows.Forms.Label();
            this.labelNoiDungThem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoThe)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownSoThe
            // 
            this.numericUpDownSoThe.Location = new System.Drawing.Point(12, 12);
            this.numericUpDownSoThe.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSoThe.Name = "numericUpDownSoThe";
            this.numericUpDownSoThe.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSoThe.TabIndex = 0;
            this.numericUpDownSoThe.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSoThe.ValueChanged += new System.EventHandler(this.numericUpDownSoThe_ValueChanged);
            // 
            // labelSoThe
            // 
            this.labelSoThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoThe.Location = new System.Drawing.Point(138, 12);
            this.labelSoThe.Name = "labelSoThe";
            this.labelSoThe.Size = new System.Drawing.Size(123, 20);
            this.labelSoThe.TabIndex = 1;
            this.labelSoThe.Text = "Số thẻ:";
            // 
            // labelHang
            // 
            this.labelHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHang.Location = new System.Drawing.Point(267, 12);
            this.labelHang.Name = "labelHang";
            this.labelHang.Size = new System.Drawing.Size(192, 21);
            this.labelHang.TabIndex = 2;
            this.labelHang.Text = "Hạng:";
            // 
            // labelXamChu
            // 
            this.labelXamChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXamChu.Location = new System.Drawing.Point(9, 35);
            this.labelXamChu.Name = "labelXamChu";
            this.labelXamChu.Size = new System.Drawing.Size(297, 91);
            this.labelXamChu.TabIndex = 3;
            this.labelXamChu.Text = "Xâm chữ:";
            // 
            // labelYNghia
            // 
            this.labelYNghia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYNghia.Location = new System.Drawing.Point(312, 36);
            this.labelYNghia.Name = "labelYNghia";
            this.labelYNghia.Size = new System.Drawing.Size(297, 90);
            this.labelYNghia.TabIndex = 4;
            this.labelYNghia.Text = "Ý nghĩa:";
            // 
            // labelNoiDungThem
            // 
            this.labelNoiDungThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoiDungThem.Location = new System.Drawing.Point(9, 126);
            this.labelNoiDungThem.Name = "labelNoiDungThem";
            this.labelNoiDungThem.Size = new System.Drawing.Size(597, 207);
            this.labelNoiDungThem.TabIndex = 5;
            this.labelNoiDungThem.Text = "<ND>";
            // 
            // FormXemThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 348);
            this.Controls.Add(this.labelNoiDungThem);
            this.Controls.Add(this.labelYNghia);
            this.Controls.Add(this.labelXamChu);
            this.Controls.Add(this.labelHang);
            this.Controls.Add(this.labelSoThe);
            this.Controls.Add(this.numericUpDownSoThe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormXemThe";
            this.Text = "Xem Thẻ Xâm Linh Ứng";
            this.Load += new System.EventHandler(this.FormXemThe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoThe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownSoThe;
        private System.Windows.Forms.Label labelSoThe;
        private System.Windows.Forms.Label labelHang;
        private System.Windows.Forms.Label labelXamChu;
        private System.Windows.Forms.Label labelYNghia;
        private System.Windows.Forms.Label labelNoiDungThem;
    }
}