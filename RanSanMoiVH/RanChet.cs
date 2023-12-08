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

namespace RanSanMoi
{
    public partial class RanChet : Form
    {
        string usernamecurrent;
        int diemcurrent;
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
        public RanChet(string username, int diem)
        {
            InitializeComponent();
            usernamecurrent = username;
            diemcurrent = diem;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RanChet_Load(object sender, EventArgs e)
        {
           
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            command = connection.CreateCommand();

            command.CommandText = "select Max_De from PLAYER where username = '" +usernamecurrent+ "'";
            object resultDe = command.ExecuteScalar();
            int high_score_de = Convert.ToInt32(resultDe);

            command.CommandText = "select Max_Vua from PLAYER where username = '" + usernamecurrent + "'";
            object resultVua = command.ExecuteScalar();
            int high_score_vua = Convert.ToInt32(resultVua);

            command.CommandText = "select Max_Kho from PLAYER where username = '" + usernamecurrent + "'";
            object resultKho = command.ExecuteScalar();
            int high_score_Kho = Convert.ToInt32(resultKho);

            command.CommandText = "select play_count from PLAYER where username = '" + usernamecurrent + "'";
            object result1 = command.ExecuteScalar();
            int play_count = Convert.ToInt32(result1);

            label4.Text = usernamecurrent;
            label5.Text = diemcurrent.ToString();
            label6.Text = high_score_de.ToString();
            label11.Text = high_score_vua.ToString();
            label12.Text = high_score_Kho.ToString();
            label8.Text = play_count.ToString();

        }
    }
}
