﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RanSanMoi
{
    public partial class FormMuc : Form
    {
        string username;
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
        public FormMuc(string Username)
        {
            InitializeComponent();
            username = Username;
        }

        private void btde_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(2, false, username);
            form.Show();
            this.Hide();
            form.timer1.Interval = 200;
        }

        private void btvua_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(4, false, username);
            form.Show();
            this.Hide();
            form.timer1.Interval = 150;
        }

        private void btkho_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(4, true, username);
            form.Show();
            this.Hide();
            form.timer1.Interval = 100;
        }

        private void FormMuc_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }
    }
}
