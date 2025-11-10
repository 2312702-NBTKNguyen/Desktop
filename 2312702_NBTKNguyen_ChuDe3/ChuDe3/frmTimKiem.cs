using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuDe3
{
    public partial class frmTimKiem : Form
    {
        public string MSSVSearch { get; private set; }
        public string TenSearch { get; private set; }
        public string LopSearch { get; private set; }
        public frmTimKiem()
        {
            InitializeComponent();
        }

        public void LoadLopData(List<string> danhSachLop)
        {
            danhSachLop.Insert(0, "");
            cbbTimLop.DataSource = danhSachLop;
            cbbTimLop.SelectedIndex = 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
