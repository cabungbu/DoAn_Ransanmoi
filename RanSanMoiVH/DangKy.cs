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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RanSanMoi
{
    public partial class DangKy : Form
    {
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
        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            button2.Text = "Password";
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into PLAYER values('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "', '" + 0 + "', '" + 0 + "')";
            command.ExecuteNonQuery();
            loaddata();
            FormMuc form1 = new FormMuc(textBox1.Text);
            form1.Show();
            this.Hide();
        }
    }
}
