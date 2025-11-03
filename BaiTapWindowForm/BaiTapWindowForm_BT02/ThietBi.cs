using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowForm_BT02
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }

        public ThietBi(string maThietBi, string tenThietBi, string nuocSanXuat, double donGia, int soLuong)
        {
            MaThietBi = maThietBi;
            TenThietBi = tenThietBi;
            NuocSanXuat = nuocSanXuat;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        public double ThanhTien()
        {
            return DonGia * SoLuong;
        }

        public void HienThi()
        {
            Console.WriteLine("Mã thiết bị: " + MaThietBi);
            Console.WriteLine("Tên thiết bị: " + TenThietBi);
            Console.WriteLine("Nước sản xuất: " + NuocSanXuat);
            Console.WriteLine("Đơn giá: " + DonGia);
            Console.WriteLine("Số lượng: " + SoLuong);
            Console.WriteLine("Thành tiền: " + ThanhTien());
        }
    }
}
