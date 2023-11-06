using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RanSanMoi
{
    public partial class Sign : Form
    {
        public Sign()
        {
            InitializeComponent();
        }

        private void Sign_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhap DN = new DangNhap();
            DN.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangKy DK  = new DangKy();
            DK.Show();
            this.Hide();
        }
    }
}
