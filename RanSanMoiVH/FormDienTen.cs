using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RanSanMoiVH
{
    public partial class FormDienTen : Form
    {
        public FormDienTen()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(textBox1.Text, textBox3.Text);
            f3.Show();
            this.Close();
        }
    }
}
