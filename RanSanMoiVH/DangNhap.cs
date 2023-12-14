using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using RanSanMoi;
using RanSanMoiVH;

namespace RanSanMoi
{
    public partial class DangNhap : Form
    {
        private Form2player form;
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-42J40F9\SQLEXPRESS;Initial Catalog=RANSANMOI;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from PLAYER";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
        }
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            command = connection.CreateCommand();
            command.CommandText = "select * from PLAYER where username = '"+textBox1.Text+ "' AND password = '"+textBox2.Text+"'";
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                // Đăng nhập thành công
                form = new Form2player(username);
                form.Show();
                this.Hide();
            }
            else
            {
                reader.Close();
                MessageBox.Show("Thông tin đăng nhập không đúng. Vui lòng thử lại!");
            }
            loaddata();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sign sign = new Sign();
            sign.Show();
            this.Close();
        }
    }
}
