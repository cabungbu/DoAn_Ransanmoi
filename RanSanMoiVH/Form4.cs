using RanSanMoi;
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
    public partial class Form4 : Form
    {
        string name1, name2;
        int diem1, diem2;

        private void button1_Click(object sender, EventArgs e)
        {
            Sign form = new Sign();
            form.Show();
            this.Close();
        }

        public Form4(string u1, string u2, int d1, int d2)
        {
            InitializeComponent();
            name1 = u1;
            name2 = u2; 
            diem1 = d1;
            diem2 = d2;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label3.Text = name1;
            label4.Text = name2;
            label7.Text = diem1.ToString();
            label8.Text = diem2.ToString();
        }
    }
}
