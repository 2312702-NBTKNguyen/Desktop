using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTGiangVien
{
    public partial class frmTBGiangVien : Form
    {
        public frmTBGiangVien()
        {
            InitializeComponent();
        }

        public void SetText(string s)
        {
            this.lblThongBao.Text = s;
        }
        private void frmTBGiangVien_Load(object sender, EventArgs e)
        {
            
        }

    }
}
