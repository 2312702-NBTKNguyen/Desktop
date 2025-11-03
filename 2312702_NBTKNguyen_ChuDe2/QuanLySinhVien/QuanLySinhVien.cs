using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public delegate int SoSanh(object sv1, object sv2);

    class QuanLySinhVien
    {
        public List<SinhVien> dsSinhVien;

        public QuanLySinhVien()
        {
            dsSinhVien = new List<SinhVien>();
        }

        public SinhVien this[int index]
        {
            get { return this.dsSinhVien[index]; }
            set { dsSinhVien[index] = value; }
        }
               
        public void Them(SinhVien sv)
        {
            this.dsSinhVien.Add(sv);
        }
        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien svresult = null;
            foreach (SinhVien sv in dsSinhVien)
                if (ss(obj, sv) == 0)
                {
                    svresult = sv;
                    break;
                }
            return svresult;
        }
                
        public bool Sua(SinhVien svsua, object obj, SoSanh ss)
        {
            bool kq = false;
            int count = this.dsSinhVien.Count - 1;

            for (int i = 0; i < count; i++)
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = svsua;
                    kq = true;
                    break;
                }
            return kq;
        }
                
        public void Xoa(object obj, SoSanh ss)
        {
            for (int i = dsSinhVien.Count - 1; i >= 0; i--)
                if (ss(obj, this[i]) == 0)
                    this.dsSinhVien.RemoveAt(i);
        }
        public void DocTuFile(string filename, bool hasHeader = true)
        {
            using (StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open)))
            {
                string line;
                bool first = hasHeader;

                while ((line = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    // Bỏ qua header
                    if (first)
                    {
                        first = false;
                        // an toàn hơn: nếu dòng đầu có "MSSV" thì skip
                        if (line.StartsWith("MSSV")) continue;
                    }

                    string[] s = line.Split('\t');
                    if (s.Length < 8) continue; // thiếu cột thì bỏ qua

                    var sv = new SinhVien
                    {
                        MaSo = s[0].Trim(),
                        HoTen = s[1].Trim(),
                        DiaChi = s[3].Trim(),
                        Lop = s[4].Trim(),
                        Hinh = s[5].Trim(),
                        GioiTinh = s[6].Trim() == "1"
                    };

                    // Parse ngày sinh an toàn
                    DateTime dob;
                    string[] formats = { "d/M/yyyy", "dd/M/yyyy", "d/MM/yyyy", "dd/MM/yyyy",
                                 "M/d/yyyy", "MM/d/yyyy", "M/dd/yyyy", "MM/dd/yyyy" };
                    if (!DateTime.TryParseExact(s[2].Trim(), formats,
                            CultureInfo.InvariantCulture, DateTimeStyles.None, out dob))
                    {
                        // nếu vẫn không parse được, bạn có thể continue; hoặc đặt giá trị mặc định
                        // continue;
                        dob = DateTime.MinValue;
                    }
                    sv.NgaySinh = dob;

                    // Chuyên ngành
                    sv.ChuyenNganh = s[7]
                        .Split(',')
                        .Select(x => x.Trim())
                        .Where(x => x.Length > 0)
                        .ToList();

                    this.Them(sv);
                }
            }
        }

    }
}
