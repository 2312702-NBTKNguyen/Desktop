using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ChuDe3
{
    public class QuanLySinhVien
    {
        public List<SinhVien> DanhSachSinhVien { get; private set; }

        public QuanLySinhVien()
        {
            DanhSachSinhVien = new List<SinhVien>();
        }

        public void Them(SinhVien sv)
        {
            if (DanhSachSinhVien.Any(s => s.MSSV == sv.MSSV))
            {
                throw new Exception("MSSV đã tồn tại.");
            }
            DanhSachSinhVien.Add(sv);
        }

        public void CapNhat(SinhVien sv)
        {
            int index = DanhSachSinhVien.FindIndex(s => s.MSSV == sv.MSSV);
            if (index != -1)
            {
                DanhSachSinhVien[index] = sv;
            }
        }

        public void Xoa(List<string> mssvList)
        {
            DanhSachSinhVien.RemoveAll(sv => mssvList.Contains(sv.MSSV));
        }

        public List<SinhVien> TimKiem(string mssv, string ten, string lop)
        {
            var ketQua = DanhSachSinhVien.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(mssv))
            {
                ketQua = ketQua.Where(s => s.MSSV.Contains(mssv));
            }

            if (!string.IsNullOrWhiteSpace(ten))
            {
                ketQua = ketQua.Where(s => s.Ten.ToLower().Contains(ten.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(lop))
            {
                ketQua = ketQua.Where(s => s.Lop.Equals(lop, StringComparison.OrdinalIgnoreCase));
            }

            return ketQua.ToList();
        }

        public void DocTuFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                DanhSachSinhVien = new List<SinhVien>();
                return;
            }

            string extension = Path.GetExtension(filePath).ToLower();
            switch (extension)
            {
                case ".txt":
                    DocTuTxt(filePath);
                    break;
                case ".json":
                    string json = File.ReadAllText(filePath);
                    DanhSachSinhVien = JsonConvert.DeserializeObject<List<SinhVien>>(json) ?? new List<SinhVien>();
                    break;
                case ".xml":
                    XmlSerializer serializer = new XmlSerializer(typeof(List<SinhVien>));
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    {
                        DanhSachSinhVien = (List<SinhVien>)serializer.Deserialize(fs) ?? new List<SinhVien>();
                    }
                    break;
                default:
                    throw new Exception("Định dạng file không được hỗ trợ.");
            }
        }

        public void LuuVaoFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            switch (extension)
            {
                case ".txt":
                    LuuVaoTxt(filePath);
                    break;
                case ".json":
                    string json = JsonConvert.SerializeObject(DanhSachSinhVien, Formatting.Indented);
                    File.WriteAllText(filePath, json);
                    break;
                case ".xml":
                    XmlSerializer serializer = new XmlSerializer(typeof(List<SinhVien>));
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        serializer.Serialize(fs, DanhSachSinhVien);
                    }
                    break;
            }
        }

        private void DocTuTxt(string filePath)
        {
            DanhSachSinhVien.Clear();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(';');
                if (parts.Length == 10)
                {
                    SinhVien sv = new SinhVien
                    {
                        MSSV = parts[0],
                        HoVaTenLot = parts[1],
                        Ten = parts[2],
                        GioiTinh = bool.Parse(parts[3]),
                        NgaySinh = DateTime.Parse(parts[4]),
                        Lop = parts[5],
                        SoCMND = parts[6],
                        SoDT = parts[7],
                        DiaChiLienLac = parts[8],
                        MonHocDangKy = parts[9].Split(',').ToList()
                    };
                    DanhSachSinhVien.Add(sv);
                }
            }
        }

        private void LuuVaoTxt(string filePath)
        {
            List<string> lines = new List<string>();
            foreach (var sv in DanhSachSinhVien)
            {
                string monHoc = string.Join(",", sv.MonHocDangKy);
                lines.Add($"{sv.MSSV};{sv.HoVaTenLot};{sv.Ten};{sv.GioiTinh};{sv.NgaySinh:yyyy-MM-dd};{sv.Lop};{sv.SoCMND};{sv.SoDT};{sv.DiaChiLienLac};{monHoc}");
            }
            File.WriteAllLines(filePath, lines);
        }
    }
}
