using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTGiangVien
{
    public partial class frmGiangVien : Form
    {
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            string lienHe = "https://cntt.dlu.edu.vn/";
            this.linklbLienHe.Links.Add(0, lienHe.Length, lienHe);
            this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDanhSachHP.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbHocPhanDay.Items.Add(lbDanhSachHP.SelectedItems[i]);
                this.lbDanhSachHP.Items.Remove(lbDanhSachHP.SelectedItems[i]);
                i--;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbHocPhanDay.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbDanhSachHP.Items.Add(lbHocPhanDay.SelectedItems[i]);
                this.lbHocPhanDay.Items.Remove(lbHocPhanDay.SelectedItems[i]);
                i--;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
        public void Reset()
        {
            this.cboMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.mtxtSoDT.Text = "";
            this.rdNam.Checked = true;
            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
                chklbNgoaiNgu.SetItemChecked(i, false);
            foreach (object ob in this.lbHocPhanDay.Items)
            {
                this.lbDanhSachHP.Items.Add(ob);
            }
            this.lbHocPhanDay.Items.Clear();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            frmTBGiangVien frm = new frmTBGiangVien();
            frm.SetText(GetGiangVien().ToString());
            frm.ShowDialog();
        }
        public GiangVien GetGiangVien()
        {
            string gt = "Nam";
            if (rdNu.Checked)
                gt = "Nữ";
            GiangVien gv = new GiangVien();
            gv.MaSo = this.cboMaSo.Text;
            gv.GioiTinh = gt;
            gv.HoTen = this.txtHoTen.Text;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.SoDT = this.mtxtSoDT.Text;
            gv.Email = this.txtMail.Text;
            string ngoaiNgu = "";
            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
            {
                if (chklbNgoaiNgu.GetItemChecked(i))
                    ngoaiNgu += chklbNgoaiNgu.Items[i] + "; ";
            }
            gv.NgoaiNgu = ngoaiNgu.Split(';');
            DanhMucHocPhan dshp = new DanhMucHocPhan();
            foreach (object hp in lbHocPhanDay.Items)
            {
                dshp.Them(new HocPhan(hp.ToString()));
            }
            gv.dsHocPhan = dshp;
            return gv;
        }

        private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strlink = e.Link.LinkData.ToString();
            Process.Start(strlink);
        }
    }
}
