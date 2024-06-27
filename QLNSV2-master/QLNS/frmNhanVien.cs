using Business;
using DataObject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using Business.Transfer;
using System.Text.RegularExpressions;
using QLNS.Reports;
using DevExpress.XtraReports.UI;

namespace QLNS
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        BusinessNation nationB;
        BusinessStaff nhanvienB;
        BusinessLever leverB;
        BusinessPosition positionB;
        BusinessDepartment departmentB;
        bool create;
        int id;
        List<T_NhanVien> ls_Nhanvien;
        bool click;
        /*public bool ten = false;
        public bool sdt = false;*/

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            nationB = new BusinessNation();
            nhanvienB = new BusinessStaff();
            leverB = new BusinessLever();
            positionB = new BusinessPosition();
            departmentB = new BusinessDepartment();
            IsDisableActions(true);
            LoadData();
            Loadcombo();
            splitContainer1.Panel1Collapsed = true;
        }
        void LoadData()
        {
            gcNhanVien.DataSource = nhanvienB.getListTransfer();
            IsDisableActions2(false);
        }

        void Loadcombo()
        {
            cbDanToc.DataSource = nationB.getList();
            cbDanToc.ValueMember = "id";
            cbDanToc.DisplayMember = "nameNation";

            cbChucVu.DataSource = positionB.getList();
            cbChucVu.ValueMember = "id";
            cbChucVu.DisplayMember = "namePosition";

            cbPhongban.DataSource = departmentB.getList();
            cbPhongban.ValueMember = "id";
            cbPhongban.DisplayMember = "nameDepartment";

            cbTrinhDo.DataSource = leverB.getList();
            cbTrinhDo.ValueMember = "id";
            cbTrinhDo.DisplayMember = "nameLever";
        }

        void IsDisableActions(bool kt)
        {
            btnSave.Enabled = !kt;
            btnClose.Enabled = !kt;
            btnAdd.Enabled = kt;
            btnEdit.Enabled = kt;
            btnDelete.Enabled = kt;
            txtHoTen.Enabled = !kt;
            txtCCCD.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            txtSdt.Enabled = !kt;
            cbGender.Enabled = !kt;
            cbChucVu.Enabled = !kt;
            cbDanToc.Enabled = !kt;
            cbPhongban.Enabled = !kt;
            cbTrinhDo.Enabled = !kt;
            dtpkBirthDay.Enabled = !kt;
            cbHonNhan.Enabled = !kt;
            btnUpload.Enabled = !kt;
            txtSotaikhoan.Enabled = !kt;
            cbTrangthai.Enabled = !kt;
        }
        void IsDisableActions2(bool kt)
        {
            btnEdit.Enabled = kt;
            btnDelete.Enabled = kt;
            btnClose.Enabled = kt;
        }
        void SavesData()
        {
            if (create)
            {
                Staff nhanVien = new Staff();
                nhanVien.nameStaff = txtHoTen.Text;
                nhanVien.gender = (cbGender.SelectedIndex == 0) ? true : false;
                nhanVien.birthday = dtpkBirthDay.Value;
                nhanVien.phone = txtSdt.Text;
                nhanVien.address = txtDiaChi.Text;
                nhanVien.image = ImageToBase64(pxNhanvien.Image, pxNhanvien.Image.RawFormat);
                nhanVien.identify = txtCCCD.Text;
                nhanVien.bankNumber = txtSotaikhoan.Text;
                nhanVien.idPosition = int.Parse(cbChucVu.SelectedValue.ToString());
                nhanVien.idNation = int.Parse(cbDanToc.SelectedValue.ToString());
                nhanVien.idRoom = int.Parse(cbPhongban.SelectedValue.ToString());
                nhanVien.idLever = int.Parse(cbTrinhDo.SelectedValue.ToString());
                nhanVien.maritalStatus = (cbHonNhan.SelectedIndex == 0) ? true : false;
                nhanVien.status = (cbTrangthai.SelectedIndex == 0) ? true : false;
                //nhanVien.maritalStatus = (cbHonNhan.SelectedIndex == 0) ? 1 : 0;
                nhanvienB.createStaff(nhanVien);
            }
            else
            {
                var nhanVien = nhanvienB.getItem(id);
                nhanVien.nameStaff = txtHoTen.Text;
                nhanVien.gender = (cbGender.SelectedIndex == 0) ? true : false;
                nhanVien.birthday = dtpkBirthDay.Value;
                nhanVien.phone = txtSdt.Text;
                nhanVien.identify = txtCCCD.Text;
                nhanVien.address = txtDiaChi.Text;
                nhanVien.bankNumber = txtSotaikhoan.Text;
                nhanVien.image = ImageToBase64(pxNhanvien.Image, pxNhanvien.Image.RawFormat);
                nhanVien.idPosition = int.Parse(cbChucVu.SelectedValue.ToString());
                nhanVien.idNation = int.Parse(cbDanToc.SelectedValue.ToString());
                nhanVien.idRoom = int.Parse(cbPhongban.SelectedValue.ToString());
                nhanVien.idLever = int.Parse(cbTrinhDo.SelectedValue.ToString());
                nhanVien.maritalStatus = (cbHonNhan.SelectedIndex == 0) ? true : false;
                nhanVien.status = (cbTrangthai.SelectedIndex == 0) ? true : false;
                //nhanVien.maritalStatus = (cbHonNhan.SelectedIndex == 0) ? 1 : 0;
                nhanvienB.updateStaff(nhanVien);
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            IsDisableActions(false);
            create = true;
            emptyText();           
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (click == false)
            {
                MessageBox.Show("Bạn vui lòng chọn đối tượng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            IsDisableActions(false);
            create = false;
            //splitContainer1.Panel1Collapsed = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtCCCD.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtSdt.Text) || cbGender.SelectedItem == null || cbTrangthai.SelectedItem == null || cbPhongban.SelectedItem == null || cbDanToc.SelectedItem == null || cbChucVu.SelectedItem == null || cbTrinhDo.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin và không được để trống");
                return;
            }
            if (!Regex.IsMatch(txtHoTen.Text, "[a-zA-Z]+$"))
            {
                MessageBox.Show("Họ tên không được nhập số hoặc ký tự đặc biệt");
                return;
            }
            if (Regex.IsMatch(txtSdt.Text, "[^0-9]+"))
            {
                MessageBox.Show("Số điện thoại nhập vào phải là số");
                return;
            }
            if (txtSdt.Text.Length > 11 || txtSdt.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải là 10 hoặc 11 số");
                return;
            }
            if (Regex.IsMatch(txtCCCD.Text, "[^0-9]+"))
            {
                MessageBox.Show("CCCD nhập vào phải là số");
                return;
            }
            if (txtCCCD.Text.Length != 12)
            {
                MessageBox.Show("CCCD chỉ được có 12 số");
                return;
            }
            if (create)
            {
                if (nhanvienB.IsCheckCCCD(txtCCCD.Text))
                {
                    MessageBox.Show("Căn cước công dân đã bị trùng. Vui lòng nhập CCCD khác.");
                    return;
                }
            }
            else
            {
                if (nhanvienB.IsCheckCCCD(txtCCCD.Text, id))
                {
                    MessageBox.Show("Căn cước công dân đã tồn tại. Vui lòng nhập CCCD khác.");
                    return;
                }
            }
            if (dtpkBirthDay.Value.Year <= DateTime.Now.Year && dtpkBirthDay.Value.Year >= (DateTime.Now.Year - 18) || dtpkBirthDay.Value.Year > DateTime.Now.Year)
            {
                MessageBox.Show("Ngày sinh chọn không phù hợp");
                return;
            }
            if (Regex.IsMatch(txtSotaikhoan.Text, "[^0-9]+"))
            {
                MessageBox.Show("Số tài khoản nhập vào phải là số");
                return;
            }
            SavesData();
            LoadData();
            IsDisableActions(true);
            splitContainer1.Panel1Collapsed = false;
            emptyText();

        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nhanvienB.deleteStaff(id);
                LoadData();
                emptyText();
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsDisableActions(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void gvNhanVien_Click(object sender, EventArgs e)
        {
            click = true;
            splitContainer1.Panel1Collapsed = false;
            id = int.Parse(gvNhanVien.GetFocusedRowCellValue("id").ToString());
            var nv = nhanvienB.getItem(id);
            txtHoTen.Text = nv.nameStaff;
            dtpkBirthDay.Value = nv.birthday.Value;
            txtSdt.Text = nv.phone;
            txtDiaChi.Text = nv.address;
            pxNhanvien.Image = Base64ToImage(nv.image);
            txtCCCD.Text = nv.identify;
            txtSotaikhoan.Text = nv.bankNumber;
            cbGender.SelectedIndex = (nv.gender.Value == true) ? 0 : 1;
            cbChucVu.SelectedValue = nv?.idPosition ?? -1;
            cbDanToc.SelectedValue = nv?.idNation ?? -1;
            cbPhongban.SelectedValue = nv?.idRoom ?? -1;
            cbTrinhDo.SelectedValue = nv?.idLever ?? -1;
            cbHonNhan.SelectedIndex = (nv.maritalStatus.Value == true) ? 0 : 1;
            cbTrangthai.SelectedIndex = (nv.status.Value == true) ? 0 : 1;
            IsDisableActions(true);
            btnClose.Enabled = true;
        }

        void emptyText()
        {
            txtHoTen.Text = string.Empty;
            txtSdt.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            cbGender.SelectedIndex = -1;
            cbTrangthai.SelectedIndex = -1;
            cbChucVu.SelectedIndex = -1;
            cbDanToc.SelectedIndex = -1;
            cbTrinhDo.SelectedIndex = -1;
            cbPhongban.SelectedIndex = -1;
            dtpkBirthDay.Value = DateTime.Now;
            cbTrangthai.Text = string.Empty;
            txtSotaikhoan.Text = string.Empty;
            Image image = Properties.Resources.no_image;
            pxNhanvien.Image = image;
        }

        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }

        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png, .jpg)|*.png;*.jpg";
            openFile.Title = "Chọn ảnh hồ sơ";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pxNhanvien.Image = Image.FromFile(openFile.FileName);
                pxNhanvien.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnPrintList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ls_Nhanvien = nhanvienB.getListTransfer();
            RDSNhanVien rpNV = new RDSNhanVien(ls_Nhanvien);// tạo một đt rpNV, RDSNhavien(ls_Nhanvien) là pp lấy ds ls_Nhanvien 
            rpNV.ShowPreview();
        }

        private void btnPrintListStop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ls_Nhanvien = nhanvienB.getListStaffStop();
            RDSNhanVienNghiViec rpNV = new RDSNhanVienNghiViec(ls_Nhanvien);
            rpNV.ShowPreview();
        }
    }
}