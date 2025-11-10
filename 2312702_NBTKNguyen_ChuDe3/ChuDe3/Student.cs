using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuDe3
{
    [Serializable] 
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoVaTenLot { get; set; }
        public string Ten { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Lop { get; set; }
        public string SoCMND { get; set; }
        public string SoDT { get; set; }
        public string DiaChiLienLac { get; set; }
        public List<string> MonHocDangKy { get; set; }

        public SinhVien()
        {
            MonHocDangKy = new List<string>();
        }
    }
}
