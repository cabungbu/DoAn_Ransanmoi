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
    public partial class Form2player : Form
    {
        string playerName;
        public Form2player(string username)
        {
            InitializeComponent();
            playerName = username;
        }

        private void Form2player_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMuc formMuc = new FormMuc(playerName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
