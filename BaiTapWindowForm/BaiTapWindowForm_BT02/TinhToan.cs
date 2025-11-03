using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowForm_BT02
{
    internal class TinhToan
    {
        public static void NoiChuoi(string ho, string ten, out string s)
        {
            s = ho + " " + ten;
        }

        public static long GiaiThua(int n)
        {
            long giaiThua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }
            return giaiThua;
        }
    }
}
