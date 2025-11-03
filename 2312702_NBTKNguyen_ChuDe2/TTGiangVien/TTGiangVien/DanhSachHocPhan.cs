using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTGiangVien
{
    public class DanhMucHocPhan
    {
        public List<HocPhan> ds;
        public DanhMucHocPhan()
        {
            ds = new List<HocPhan>();
        }
        public HocPhan this[int index]
        {
            get { return ds[index] as HocPhan; }
            set { ds[index] = value; }
        }
        public void Them(HocPhan hp)
        {
            ds.Add(hp);
        }
        public override string ToString()
        {
            string s = "Danh sach mon hoc";
            foreach (object mh in ds)
            {
                s += mh as HocPhan + ";";
            }
            return s;
        }
    }

}
