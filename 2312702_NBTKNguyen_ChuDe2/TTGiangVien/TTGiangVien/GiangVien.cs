using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTGiangVien
{
    public class GiangVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public DanhMucHocPhan dsHocPhan;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string SoDT;
        public string Email;
        public GiangVien()
        {
            dsHocPhan = new DanhMucHocPhan();
            NgoaiNgu = new string[20];
        }
        public GiangVien(string maso, string sdt, string email, string hoten, DateTime ngaysinh, DanhMucHocPhan ds, string gt, string[] nn)
        {
            this.MaSo = maso;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.dsHocPhan = ds;
            this.NgoaiNgu = nn;
            this.SoDT = sdt;
            this.Email = email;
            this.GioiTinh = gt;
        }
        public override string ToString()
        {
            string s = "Mã số: " + MaSo + "\n"
                + "Họ tên: " + HoTen + "\n"
                + "Ngày sinh: " + NgaySinh + "\n"
                + "Giới tính: " + GioiTinh + "\n"
                + "Số ĐT: " + SoDT + "\n"
                + "Email: " + Email + "\n";
            string sngoaingu = "Ngoại ngữ: ";
            foreach (string t in NgoaiNgu)
            {
                sngoaingu += t + "; ";
            }
            string monDay = "Danh sách môn dạy: ";
            foreach (HocPhan hp in dsHocPhan.ds)
            {
                monDay += hp + "; ";
            }
            s += "\n" + sngoaingu + "\n" + monDay;
            return s;
        }
    } 
} 
