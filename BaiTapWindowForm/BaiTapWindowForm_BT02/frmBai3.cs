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
    public partial class frmBai3 : Form
    {
        
        public frmBai3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kq = "";
            TinhToan.NoiChuoi(txtHo.Text, txtTen.Text, out kq);
            lblHoTen.Text = kq;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);  
            long kq = TinhToan.GiaiThua(n);
            lblGiaiThua.Text = kq.ToString();
        }
    }
}
