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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bai1 = new frmBai1();
            bai1.Show();
        }

        private void msBai2_Click(object sender, EventArgs e)
        {
            var bai2 = new frmBai2();
            bai2.Show();
        }

        private void msBai3_Click(object sender, EventArgs e)
        {
            var bai3 = new frmBai3();
            bai3.Show();
        }
    }
}
