using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ChuDe3
{
    public partial class frmChinh : Form
    {
        private QuanLySinhVien qlsv;
        private string dataFilePath = "students.json";
        public frmChinh()
        {
            InitializeComponent();
            qlsv = new QuanLySinhVien();

            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.lvDSSV.SelectedIndexChanged += new System.EventHandler(this.lvDSSV_SelectedIndexChanged);
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                qlsv.DocTuFile(dataFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            HienThiDanhSachLenListView(qlsv.DanhSachSinhVien);
            lvDSSV.CheckBoxes = true;
            SetupContextMenuForListView();
            SetupContextMenuForCheckedListBox();
        }
        private void HienThiDanhSachLenListView(List<SinhVien> danhSach)
        {
            lvDSSV.Items.Clear();
            foreach (var sv in danhSach)
            {
                ListViewItem item = new ListViewItem(sv.MSSV);
                item.SubItems.Add(sv.HoVaTenLot);
                item.SubItems.Add(sv.Ten);
                item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(sv.Lop);
                item.SubItems.Add(sv.SoCMND);
                item.SubItems.Add(sv.SoDT);
                item.SubItems.Add(sv.DiaChiLienLac);
                item.Tag = sv;
                lvDSSV.Items.Add(item);
            }
        }

        private void lvDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSSV.SelectedItems.Count > 0)
            {
                SinhVien sv = lvDSSV.SelectedItems[0].Tag as SinhVien;
                if (sv != null)
                {
                    HienThiThongTinSinhVien(sv);
                }
            }
        }

        private void HienThiThongTinSinhVien(SinhVien sv)
        {
            txtMSSV.Text = sv.MSSV;
            txtHoVaTenLot.Text = sv.HoVaTenLot;
            txtTen.Text = sv.Ten;
            dateTimePickerNgaySinh.Value = sv.NgaySinh;
            txtCMND.Text = sv.SoCMND;
            txtDiaChi.Text = sv.DiaChiLienLac;
            cbbLop.Text = sv.Lop;
            txtSDT.Text = sv.SoDT;
            if (sv.GioiTinh)
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }

            for (int i = 0; i < clbDSMon.Items.Count; i++)
            {
                clbDSMon.SetItemChecked(i, sv.MonHocDangKy.Contains(clbDSMon.Items[i].ToString()));
            }
        }

        private SinhVien LayThongTinSinhVienTuForm()
        {
            SinhVien sv = new SinhVien
            {
                MSSV = txtMSSV.Text.Trim(),
                HoVaTenLot = txtHoVaTenLot.Text.Trim(),
                Ten = txtTen.Text.Trim(),
                NgaySinh = dateTimePickerNgaySinh.Value,
                SoCMND = txtCMND.Text.Trim(),
                DiaChiLienLac = txtDiaChi.Text.Trim(),
                Lop = cbbLop.Text.Trim(),
                SoDT = txtSDT.Text.Trim(),
                GioiTinh = rdNam.Checked
            };

            sv.MonHocDangKy.Clear();
            foreach (var item in clbDSMon.CheckedItems)
            {
                sv.MonHocDangKy.Add(item.ToString());
            }
            return sv;
        }

        private bool KiemTraThongTinHopLe()
        {
            if (string.IsNullOrWhiteSpace(txtMSSV.Text) ||
                string.IsNullOrWhiteSpace(txtHoVaTenLot.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(txtCMND.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(cbbLop.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                (!rdNam.Checked && !rdNu.Checked))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(txtMSSV.Text, @"^\d{7}$"))
            {
                MessageBox.Show("MSSV phải gồm 7 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string lop = cbbLop.Text;
            Match namNhapHocMatch = Regex.Match(lop, @"\d{2}");
            if (!namNhapHocMatch.Success)
            {
                MessageBox.Show("Lớp phải chứa 2 chữ số cuối của năm nhập học (ví dụ: CTK45, DH21).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            

            if (!Regex.IsMatch(txtCMND.Text, @"^\d{9}$"))
            {
                MessageBox.Show("Số CMND phải gồm 9 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(txtSDT.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTinHopLe()) return;

            try
            {
                SinhVien sv = LayThongTinSinhVienTuForm();
                qlsv.Them(sv);
                qlsv.LuuVaoFile(dataFilePath);
                HienThiDanhSachLenListView(qlsv.DanhSachSinhVien);
                XoaTrangThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvDSSV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!KiemTraThongTinHopLe()) return;

            SinhVien sv = LayThongTinSinhVienTuForm();
            qlsv.CapNhat(sv);
            qlsv.LuuVaoFile(dataFilePath);
            HienThiDanhSachLenListView(qlsv.DanhSachSinhVien);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (frmTimKiem frmtimkiem = new frmTimKiem())
            {
                var danhSachLop = qlsv.DanhSachSinhVien.Select(sv => sv.Lop).Distinct().ToList();
                frmtimkiem.LoadLopData(danhSachLop);

                if (frmtimkiem.ShowDialog(this) == DialogResult.OK)
                {
                    string mssv = frmtimkiem.MSSVSearch;
                    string ten = frmtimkiem.TenSearch;
                    string lop = frmtimkiem.LopSearch;

                    var ketQua = qlsv.TimKiem(mssv, ten, lop);
                    HienThiDanhSachLenListView(ketQua);
                }
            }
        }

        private void XoaTrangThongTin()
        {
            txtCMND.Clear();
            txtHoVaTenLot.Clear();
            txtTen.Clear();
            txtCMND.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            cbbLop.SelectedIndex = -1;
            cbbLop.Text = "";
            rdNam.Checked = true;
            dateTimePickerNgaySinh.Value = DateTime.Now;

            for (int i = 0; i < clbDSMon.Items.Count; i++)
            {
                clbDSMon.SetItemChecked(i, false);
            }
        }

        private void SetupContextMenuForListView()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem deleteItem = new ToolStripMenuItem("Xóa sinh viên đã chọn");
            deleteItem.Click += DeleteItem_Click;
            contextMenu.Items.Add(deleteItem);
            lvDSSV.ContextMenuStrip = contextMenu;
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if (lvDSSV.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng tick vào ô vuông của ít nhất một sinh viên để xóa.", "Thông báo");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa {lvDSSV.CheckedItems.Count} sinh viên đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                List<string> mssvToDelete = new List<string>();
                foreach (ListViewItem item in lvDSSV.CheckedItems)
                {
                    SinhVien sv = item.Tag as SinhVien;
                    if (sv != null)
                    {
                        mssvToDelete.Add(sv.MSSV);
                    }
                }
                qlsv.Xoa(mssvToDelete);
                qlsv.LuuVaoFile(dataFilePath);
                HienThiDanhSachLenListView(qlsv.DanhSachSinhVien);
            }
        }

        private void SetupContextMenuForCheckedListBox()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem addItem = new ToolStripMenuItem("Thêm môn học");
            addItem.Click += AddCourseItem_Click;
            ToolStripMenuItem removeItem = new ToolStripMenuItem("Xóa môn học");
            removeItem.Click += RemoveCourseItem_Click;

            contextMenu.Items.Add(addItem);
            contextMenu.Items.Add(removeItem);
            clbDSMon.ContextMenuStrip = contextMenu;
        }

        private void AddCourseItem_Click(object sender, EventArgs e)
        {
            string newCourse = ShowInputDialog("Nhập tên môn học mới");
            if (!string.IsNullOrWhiteSpace(newCourse) && !clbDSMon.Items.Contains(newCourse))
            {
                clbDSMon.Items.Add(newCourse, false);
            }
        }

        private void RemoveCourseItem_Click(object sender, EventArgs e)
        {
            if (clbDSMon.SelectedItem != null)
            {
                clbDSMon.Items.Remove(clbDSMon.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một môn học trong danh sách để xóa.", "Thông báo");
            }
        }

        private string ShowInputDialog(string title)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Tên môn học:" };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (s, ev) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void mtxtMSSV_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
