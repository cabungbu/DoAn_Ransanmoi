using RanSanMoi.RanSanMoi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RanSanMoi
{
    public partial class Form1 : Form
    {
        int diem = 0;
        Random randFood = new Random();
        Food food;
        Wall wall;
        Obstacle obstacle;
        Graphics paper;
        Snake snake = new Snake();
        string usernamecurrent;
        int numObstacle;
        bool IsMovingObstacle;
        // khoi tao cac phim dieu khien ran
        Boolean trai = false, phai = false, len = false, xuong = false;
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
        public Form1(int numObstacles, bool isMovingObstacles, string Username)
        {
            InitializeComponent();
            food = new Food(randFood);
            wall = new Wall();
            obstacle = new Obstacle(numObstacles);
            numObstacle = numObstacles;
            IsMovingObstacle = isMovingObstacles;
            usernamecurrent = Username;
        }
        // hien thi do hoa tren form
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            lbtocdo1.Text =(250 - timer1.Interval).ToString();
            paper = e.Graphics;
          
            food.DrawFood(paper);
            snake.DrawSnake(paper);
            wall.DrawWall(paper);
            obstacle.DrawObstacle(paper);

        }
        // khoi tao su kien tren ban phim
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)            
            {
                timer1.Enabled = true;
                trai = false; phai = false; len = false; xuong = false;
                label1.Text = "";
                
            }
            if (e.KeyData == Keys.Up && xuong == false)
            {
                len = true;
                xuong = false;
                trai = false;
                phai = false;
            }
            if (e.KeyData == Keys.Down && len == false)
            {
                len = false;
                xuong = true;
                trai = false;
                phai = false;
            }
            if (e.KeyData == Keys.Left && phai == false)
            {
                len = false;
                xuong = false;
                trai = true;
                phai = false;
            }
            if (e.KeyData == Keys.Right & trai == false)
            {
                len = false;
                xuong = false;
                trai = false;
                phai = true;
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            toolStripStatusdiem.Text = diem.ToString();
            if (xuong == true)
            {
                snake.dichuyenxuong();
            }
            if (len == true)
            {
                snake.dichuyenlen();
            }
            if (trai == true)
            {
                snake.dichuyentrai();
            }
            if (phai == true)
            {
                snake.dichuyenphai();
            }
            if (numObstacle == 2)
            {
                for (int i = 0; i < obstacle.ObstacleRec.Length; i++)
                {
                    if (food.FoodRec.IntersectsWith(obstacle.ObstacleRec[i]))
                    {
                        food.FoodLocation(randFood);
                    }
                    if (food.FoodRec.IntersectsWith(obstacle.ObstacleRec1[i]))
                    {
                        food.FoodLocation(randFood);
                    }
                }
            }    
            if (numObstacle == 4)
            {
                for (int i = 0; i < obstacle.ObstacleRec.Length; i++)
                {
                    if (food.FoodRec.IntersectsWith(obstacle.ObstacleRec[i]))
                    {
                        food.FoodLocation(randFood);
                    }
                    if (food.FoodRec.IntersectsWith(obstacle.ObstacleRec1[i]))
                    {
                        food.FoodLocation(randFood);
                    }
                    if (food.FoodRec.IntersectsWith(obstacle.ObstacleRec2[i]))
                    {
                        food.FoodLocation(randFood);
                    }
                    if (food.FoodRec.IntersectsWith(obstacle.ObstacleRec3[i]))
                    {
                        food.FoodLocation(randFood);
                    }
                }
            }    
           
            for (int i = 0; i < snake.RanRec.Length; i++)
            {
                if (snake.RanRec[i].IntersectsWith(food.FoodRec))
                {
                    timer1.Interval -= 5;
                    diem += 10;
                    snake.GrowSnake();
                    food.FoodLocation(randFood);
                }
            }

            vacham();
            if (IsMovingObstacle == true)
                obstacle.RunObstacle();
            //cap nhat lai man hinh
            this.Invalidate();
        }
        //ham va cham chet
        public void vacham()
        {
            for (int i = 1; i < snake.RanRec.Length; i++)
            {
                if (snake.RanRec[0].IntersectsWith(snake.RanRec[i]))
                {
                    Restart();
                    return;
                }
            }

            for (int i = 0; i < obstacle.ObstacleRec.Length; i++)
            {
                if (numObstacle == 2)
                {
                    if (snake.RanRec[0].IntersectsWith(obstacle.ObstacleRec[i]))
                    {
                        Restart();
                        return;
                    }
                    if (snake.RanRec[0].IntersectsWith(obstacle.ObstacleRec1[i]))
                    {
                        Restart();
                        return;
                    }
                }
                else if (numObstacle == 4)
                {
                    if (snake.RanRec[0].IntersectsWith(obstacle.ObstacleRec[i]))
                    {
                        Restart();
                        return;
                    }
                    if (snake.RanRec[0].IntersectsWith(obstacle.ObstacleRec1[i]))
                    {
                        Restart();
                        return;
                    }
                    if (snake.RanRec[0].IntersectsWith(obstacle.ObstacleRec2[i]))
                    {
                        Restart();
                        return;
                    }
                    if (snake.RanRec[0].IntersectsWith(obstacle.ObstacleRec3[i]))
                    {
                        Restart();
                        return;
                    }
                }
            
                if (snake.RanRec[0].X < 10 || snake.RanRec[0].X > 400)
                {
                    Restart();
                    return;
                }
                if (snake.RanRec[0].Y < 10 || snake.RanRec[0].Y > 400)
                {
                    Restart();
                    return;
                }

            }    
           
        }
        void Restart()
        {
            this.Close();
            timer1.Enabled = false;
            
            command = connection.CreateCommand();
            if (numObstacle == 2)
            {
                command.CommandText = "select Max_De from PLAYER where username = '" + usernamecurrent + "'";
                object result = command.ExecuteScalar();
                int high_score = Convert.ToInt32(result);

                if (diem > high_score)
                {
                    high_score = diem;
                }
                command.CommandText = "update PLAYER set play_count = play_count + 1, Max_De = '" + high_score + "' where username = '" + usernamecurrent + "'";
                command.ExecuteNonQuery();
                loaddata();
            }
            else if (numObstacle == 4 && IsMovingObstacle == false)
            {
                command.CommandText = "select Max_Vua from PLAYER where username = '" + usernamecurrent + "'";
                object result = command.ExecuteScalar();
                int high_score = Convert.ToInt32(result);

                if (diem > high_score)
                {
                    high_score = diem;
                }
                command.CommandText = "update PLAYER set play_count = play_count + 1, Max_Vua = '" + high_score + "' where username = '" + usernamecurrent + "'";
                command.ExecuteNonQuery();
                loaddata();
            }
            else if (numObstacle == 4 && IsMovingObstacle == true)
            {
                command.CommandText = "select Max_Kho from PLAYER where username = '" + usernamecurrent + "'";
                object result = command.ExecuteScalar();
                int high_score = Convert.ToInt32(result);

                if (diem > high_score)
                {
                    high_score = diem;
                }
                command.CommandText = "update PLAYER set play_count = play_count + 1, Max_Kho = '" + high_score + "' where username = '" + usernamecurrent + "'";
                command.ExecuteNonQuery();
                loaddata();
            }
            RanChet RC = new RanChet(usernamecurrent, diem);
            RC.Show();
            label1.Text = "Nhấn F2 Để Bắt Đầu Chơi";
            diem = 0;
            toolStripStatusdiem.Text = "0";

        }

      
        private void timerchuchay_Tick(object sender, EventArgs e)
        {
            lblChuoichu.Location = new Point(lblChuoichu.Location.X, lblChuoichu.Location.Y - 1);
            if (lblChuoichu.Location.Y + lblChuoichu.Height < 0)
            {
                lblChuoichu.Location = new Point(lblChuoichu.Location.X,pnchuchay.Height);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lblChuoichu.Text = "  \n****Đồ Án: Trò Chơi Rắn Săn Mồi***\nTrường ĐH Công Nghệ Thông Tin \nSinh Viên Thực Hiện 1: \nSinh viên thực hiện 2: \n+ Lớp: \nSử dụng các phím điều hướng \nDi chuyển để điều khiển rắn \nTheo hướng của phím Di chuyển \nKhéo léo điều khiển sao cho \nKhông được va vào tường và vật cản  \nVà Ăn thức ăn \n với mỗi lần ăn thức ăn \nSẽ được 10 điểm\n Và Tốc độ sẽ Tăng thêm 5km/h";
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chơiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            toolStripStatusdiem.Text = "0";
            diem = 0;
            snake = new Snake();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTin form = new FormThongTin();
            form.Show();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHuongdan form = new FormHuongdan();
            form.Show();
        }
   }

}
