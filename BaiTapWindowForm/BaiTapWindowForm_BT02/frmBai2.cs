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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoThuNhat.Text);
            int b = int.Parse(txtSoThuHai.Text);
            
            if (rdCong.Checked)
            {
                lblKetQua.Text = (a + b).ToString();
            }
            else if (rdTru.Checked)
            {
                lblKetQua.Text = (a - b).ToString();
            }
            else if (rdNhan.Checked)
            {
                lblKetQua.Text = (a * b).ToString();
            }
            else if (rdChia.Checked)
            {
                if (b != 0)
                {
                    lblKetQua.Text = (a / b).ToString();
                }
                else
                {
                    MessageBox.Show("Không thể chia cho 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
