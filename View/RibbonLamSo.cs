using LamSoAddIn.Controller;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Threading;
using System.Windows.Forms;

namespace LamSoAddIn
{
    public partial class RibbonLamSo
    {
        private void RibbonLamSo_Load(object sender, RibbonUIEventArgs e)
        {
            RibbonDropDownItem _genderItemMale = Factory.CreateRibbonDropDownItem();
            _genderItemMale.Label = "Nam";
            dropDownGioiTinh.Items.Add(_genderItemMale);
            RibbonDropDownItem _genderItemFemale = Factory.CreateRibbonDropDownItem();
            _genderItemFemale.Label = "Nữ";
            dropDownGioiTinh.Items.Add(_genderItemFemale);
            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 100; i--)
            {
                RibbonDropDownItem _yearItem = Factory.CreateRibbonDropDownItem();
                _yearItem.Label = i.ToString();
                dropDownNamSinh.Items.Add(_yearItem);
            }
        }

        private void ButtonTinhNhanh_Click(object sender, RibbonControlEventArgs e)
        {
            int _namSinh = int.Parse(dropDownNamSinh.SelectedItem.Label.ToString());
            string _gioiTinh = dropDownGioiTinh.SelectedItem.Label.ToString();
            string content = _gioiTinh + " sinh năm " + _namSinh +
                "\nTuổi " + Property.DoiSo(Property.TuoiMu(_namSinh)) +
                "(" + Property.TuoiMu(_namSinh).ToString() +
                ")\nCan chi: " + Property.CanChi(_namSinh) +
                ")\nSao: " + Property.Sao(_namSinh, _gioiTinh) +
                "\nTam tai: " + (Property.TamTai(_namSinh) ? "Bị" : "Không Bị") +
                "\nHạn: " + Property.Han(_namSinh, _gioiTinh) +
                "\nVận: " + Property.Van(_namSinh, _gioiTinh) +
                "\nChủ mệnh: " + Property.ChuMenh(_namSinh) +
                "\nĐộng lâm: " + Property.DongLam(_namSinh, _gioiTinh) +
                "\nBản mệnh: " + Property.BanMenh(_namSinh) +
                "\nMệnh: " + Property.Menh(_namSinh, _gioiTinh) +
                "\nTiền: " + Property.Tien(_namSinh) +
                "\nKinh: " + Property.Kinh(_namSinh) +
                "\nKho: " + Property.Kho(_namSinh) +
                "\nChủ kho: " + Property.Chu(_namSinh) +
                "\nThêm " + Property.Them(_namSinh);
            MessageBox.Show(content, "Tính nhanh..");
        }

        private void ButtonTaiDL_Click(object sender, RibbonControlEventArgs e)
        {
            if (XDoc.Open()) MessageBox.Show("Tải dữ liệu thành công", "Thành Công!!");
        }
        private void ButtonThemMoi_Click(object sender, RibbonControlEventArgs e)
        {
            if (XDoc.New()) MessageBox.Show("Tạo dữ liệu mới thành công", "Thành Công!!");
        }

        private void ButtonSaoLuu_Click(object sender, RibbonControlEventArgs e)
        {
            if (XDoc.DB != null)
            {
                if (XDoc.SaveAs()) MessageBox.Show("Tạo bản sao dữ liệu thành công", "Thành Công!!");
            }
            else MessageBox.Show("Hãy tải dữ liệu trước..", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonLuu_Click(object sender, RibbonControlEventArgs e)
        {
            if (XDoc.DB != null)
            {
                if (XDoc.Save()) MessageBox.Show("Lưu dữ liệu thành công", "Thành Công!!");
            }
            else MessageBox.Show("Hãy tải dữ liệu trước..", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonHoTroIn_Click(object sender, RibbonControlEventArgs e)
        {
            if (XDoc.DB != null)
            {
                FormPrintingSupport formInputAddress = new FormPrintingSupport();
                formInputAddress.ShowDialog();
            }
            else MessageBox.Show("Hãy tải dữ liệu trước..", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonKhach_Click(object sender, RibbonControlEventArgs e)
        {
            if (XDoc.DB != null)
            {
                if (XDoc.ReadAddresses().Count == 0)
                {
                    MessageBox.Show("Địa chỉ đang trống hãy bổ sung trước khi thêm hộ và khách", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    FormCustomer formKhach = new FormCustomer();
                    formKhach.ShowDialog();
                }
            }
            else MessageBox.Show("Hãy tải dữ liệu trước..", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonDiaChi_Click(object sender, RibbonControlEventArgs e)
        {
            if (XDoc.DB != null)
            {
                FormAddresses formInputAddress = new FormAddresses();
                formInputAddress.ShowDialog();
            }
            else MessageBox.Show("Hãy tải dữ liệu trước..", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonXuatDs_Click(object sender, RibbonControlEventArgs e)
        {
            if (XDoc.DB != null)
            {
                FormXuatDs formXuatDs = new FormXuatDs();
                formXuatDs.Show();
            }
            else MessageBox.Show("Hãy tải dữ liệu trước..", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonTinhTien_Click(object sender, RibbonControlEventArgs e)
        {
            if (XDoc.DB != null)
            {
                FormTinhTien formTinhTien = new FormTinhTien();
                formTinhTien.Show();
            }
            else MessageBox.Show("Hãy tải dữ liệu trước..", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonChuyenDoc_Click(object sender, RibbonControlEventArgs e)
        {
            if (XDoc.DB != null)
            {
                FormChuyenDoc formChuyenDoc = new FormChuyenDoc();
                formChuyenDoc.Show();
            }
            else MessageBox.Show("Hãy tải dữ liệu trước..", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonXemThe_Click(object sender, RibbonControlEventArgs e)
        {
            /*FormXemThe formXemThe = new FormXemThe();
            formXemThe.Show();*/
            MessageBox.Show("Tính năng đang lỗi :) đợi fix...");
        }
    }
}
