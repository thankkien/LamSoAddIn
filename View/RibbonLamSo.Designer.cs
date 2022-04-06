
namespace LamSoAddIn
{
    partial class RibbonLamSo : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonLamSo()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonLamSo));
            this.tabLamSo = this.Factory.CreateRibbonTab();
            this.groupLuuTru = this.Factory.CreateRibbonGroup();
            this.buttonThemMoi = this.Factory.CreateRibbonButton();
            this.buttonTaiDL = this.Factory.CreateRibbonButton();
            this.buttonLuu = this.Factory.CreateRibbonButton();
            this.buttonSaoLuu = this.Factory.CreateRibbonButton();
            this.groupQuanLy = this.Factory.CreateRibbonGroup();
            this.buttonDiaChi = this.Factory.CreateRibbonButton();
            this.buttonKhach = this.Factory.CreateRibbonButton();
            this.groupCongCu = this.Factory.CreateRibbonGroup();
            this.buttonHoTroIn = this.Factory.CreateRibbonButton();
            this.buttonXuatDs = this.Factory.CreateRibbonButton();
            this.buttonChuyenDoc = this.Factory.CreateRibbonButton();
            this.buttonTinhTien = this.Factory.CreateRibbonButton();
            this.buttonXemThe = this.Factory.CreateRibbonButton();
            this.groupTinhNhanh = this.Factory.CreateRibbonGroup();
            this.dropDownNamSinh = this.Factory.CreateRibbonDropDown();
            this.dropDownGioiTinh = this.Factory.CreateRibbonDropDown();
            this.buttonTinhNhanh = this.Factory.CreateRibbonButton();
            this.tabLamSo.SuspendLayout();
            this.groupLuuTru.SuspendLayout();
            this.groupQuanLy.SuspendLayout();
            this.groupCongCu.SuspendLayout();
            this.groupTinhNhanh.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLamSo
            // 
            this.tabLamSo.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabLamSo.Groups.Add(this.groupLuuTru);
            this.tabLamSo.Groups.Add(this.groupQuanLy);
            this.tabLamSo.Groups.Add(this.groupCongCu);
            this.tabLamSo.Groups.Add(this.groupTinhNhanh);
            this.tabLamSo.Label = "Làm Sớ";
            this.tabLamSo.Name = "tabLamSo";
            // 
            // groupLuuTru
            // 
            this.groupLuuTru.Items.Add(this.buttonThemMoi);
            this.groupLuuTru.Items.Add(this.buttonTaiDL);
            this.groupLuuTru.Items.Add(this.buttonLuu);
            this.groupLuuTru.Items.Add(this.buttonSaoLuu);
            this.groupLuuTru.Label = "Lưu Trữ";
            this.groupLuuTru.Name = "groupLuuTru";
            // 
            // buttonThemMoi
            // 
            this.buttonThemMoi.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("buttonThemMoi.Image")));
            this.buttonThemMoi.Label = "Tạo Mới";
            this.buttonThemMoi.Name = "buttonThemMoi";
            this.buttonThemMoi.ShowImage = true;
            this.buttonThemMoi.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonThemMoi_Click);
            // 
            // buttonTaiDL
            // 
            this.buttonTaiDL.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonTaiDL.Image = global::LamSoAddIn.Properties.Resources.refresh;
            this.buttonTaiDL.Label = "Tải Dữ Liệu";
            this.buttonTaiDL.Name = "buttonTaiDL";
            this.buttonTaiDL.ShowImage = true;
            this.buttonTaiDL.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonTaiDL_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonLuu.Image = global::LamSoAddIn.Properties.Resources.complete;
            this.buttonLuu.Label = "Lưu";
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.ShowImage = true;
            this.buttonLuu.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonLuu_Click);
            // 
            // buttonSaoLuu
            // 
            this.buttonSaoLuu.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonSaoLuu.Image = global::LamSoAddIn.Properties.Resources.storage;
            this.buttonSaoLuu.Label = "Tạo Bản Sao";
            this.buttonSaoLuu.Name = "buttonSaoLuu";
            this.buttonSaoLuu.ShowImage = true;
            this.buttonSaoLuu.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonSaoLuu_Click);
            // 
            // groupQuanLy
            // 
            this.groupQuanLy.Items.Add(this.buttonDiaChi);
            this.groupQuanLy.Items.Add(this.buttonKhach);
            this.groupQuanLy.Label = "Quản Lý";
            this.groupQuanLy.Name = "groupQuanLy";
            // 
            // buttonDiaChi
            // 
            this.buttonDiaChi.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonDiaChi.Image = global::LamSoAddIn.Properties.Resources.house;
            this.buttonDiaChi.Label = "Địa Chỉ";
            this.buttonDiaChi.Name = "buttonDiaChi";
            this.buttonDiaChi.ShowImage = true;
            this.buttonDiaChi.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonDiaChi_Click);
            // 
            // buttonKhach
            // 
            this.buttonKhach.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonKhach.Description = "Thêm, sửa, xoá khách";
            this.buttonKhach.Image = global::LamSoAddIn.Properties.Resources.man;
            this.buttonKhach.Label = "Gia Đình và Khách";
            this.buttonKhach.Name = "buttonKhach";
            this.buttonKhach.ShowImage = true;
            this.buttonKhach.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonKhach_Click);
            // 
            // groupCongCu
            // 
            this.groupCongCu.Items.Add(this.buttonHoTroIn);
            this.groupCongCu.Items.Add(this.buttonXuatDs);
            this.groupCongCu.Items.Add(this.buttonChuyenDoc);
            this.groupCongCu.Items.Add(this.buttonTinhTien);
            this.groupCongCu.Items.Add(this.buttonXemThe);
            this.groupCongCu.Label = "Công Cụ";
            this.groupCongCu.Name = "groupCongCu";
            // 
            // buttonHoTroIn
            // 
            this.buttonHoTroIn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonHoTroIn.Image = global::LamSoAddIn.Properties.Resources.printer;
            this.buttonHoTroIn.Label = "Hỗ Trợ In";
            this.buttonHoTroIn.Name = "buttonHoTroIn";
            this.buttonHoTroIn.ShowImage = true;
            this.buttonHoTroIn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonHoTroIn_Click);
            // 
            // buttonXuatDs
            // 
            this.buttonXuatDs.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonXuatDs.Image = global::LamSoAddIn.Properties.Resources.contract;
            this.buttonXuatDs.Label = "Xuất Danh Sách";
            this.buttonXuatDs.Name = "buttonXuatDs";
            this.buttonXuatDs.ShowImage = true;
            this.buttonXuatDs.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonXuatDs_Click);
            // 
            // buttonChuyenDoc
            // 
            this.buttonChuyenDoc.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonChuyenDoc.Image = global::LamSoAddIn.Properties.Resources.transpose;
            this.buttonChuyenDoc.Label = "Chuyển Dọc";
            this.buttonChuyenDoc.Name = "buttonChuyenDoc";
            this.buttonChuyenDoc.ShowImage = true;
            this.buttonChuyenDoc.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonChuyenDoc_Click);
            // 
            // buttonTinhTien
            // 
            this.buttonTinhTien.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonTinhTien.Image = global::LamSoAddIn.Properties.Resources.invoice;
            this.buttonTinhTien.Label = "Tính Tiền Sớ Tết";
            this.buttonTinhTien.Name = "buttonTinhTien";
            this.buttonTinhTien.ShowImage = true;
            this.buttonTinhTien.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonTinhTien_Click);
            // 
            // buttonXemThe
            // 
            this.buttonXemThe.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonXemThe.Image = global::LamSoAddIn.Properties.Resources.chinese_coin;
            this.buttonXemThe.Label = "Xem Thẻ Xăm";
            this.buttonXemThe.Name = "buttonXemThe";
            this.buttonXemThe.ShowImage = true;
            this.buttonXemThe.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonXemThe_Click);
            // 
            // groupTinhNhanh
            // 
            this.groupTinhNhanh.Items.Add(this.dropDownNamSinh);
            this.groupTinhNhanh.Items.Add(this.dropDownGioiTinh);
            this.groupTinhNhanh.Items.Add(this.buttonTinhNhanh);
            this.groupTinhNhanh.Label = "Tính Nhanh";
            this.groupTinhNhanh.Name = "groupTinhNhanh";
            // 
            // dropDownNamSinh
            // 
            this.dropDownNamSinh.Label = "Năm Sinh";
            this.dropDownNamSinh.Name = "dropDownNamSinh";
            // 
            // dropDownGioiTinh
            // 
            this.dropDownGioiTinh.Label = "Giới Tính";
            this.dropDownGioiTinh.Name = "dropDownGioiTinh";
            // 
            // buttonTinhNhanh
            // 
            this.buttonTinhNhanh.Label = "Tính Nhanh";
            this.buttonTinhNhanh.Name = "buttonTinhNhanh";
            this.buttonTinhNhanh.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonTinhNhanh_Click);
            // 
            // RibbonLamSo
            // 
            this.Name = "RibbonLamSo";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tabLamSo);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonLamSo_Load);
            this.tabLamSo.ResumeLayout(false);
            this.tabLamSo.PerformLayout();
            this.groupLuuTru.ResumeLayout(false);
            this.groupLuuTru.PerformLayout();
            this.groupQuanLy.ResumeLayout(false);
            this.groupQuanLy.PerformLayout();
            this.groupCongCu.ResumeLayout(false);
            this.groupCongCu.PerformLayout();
            this.groupTinhNhanh.ResumeLayout(false);
            this.groupTinhNhanh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabLamSo;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupQuanLy;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonKhach;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupLuuTru;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonSaoLuu;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonTaiDL;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupTinhNhanh;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDownNamSinh;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDownGioiTinh;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupCongCu;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonXuatDs;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonChuyenDoc;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonThemMoi;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonTinhTien;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonXemThe;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonTinhNhanh;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonDiaChi;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonLuu;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonHoTroIn;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonLamSo RibbonLamSo
        {
            get { return this.GetRibbon<RibbonLamSo>(); }
        }
    }
}
