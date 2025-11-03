using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowForm_BT02
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi("TB001", "Laptop Dell", "Mỹ", 1500.0, 5);
            lblThongBao.Text = $"Mã thiết bị: {tb.MaThietBi}\n" +
                                   $"Tên thiết bị: {tb.TenThietBi}\n" +
                                   $"Nước sản xuất: {tb.NuocSanXuat}\n" +
                                   $"Đơn giá: {tb.DonGia}\n" +
                                   $"Số lượng: {tb.SoLuong}\n" +
                                   $"Thành tiền: {tb.ThanhTien()}";
        }
    }
}
