using RanSanMoi.RanSanMoi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
        // khoi tao cac phim dieu khien ran
        Boolean trai = false, phai = false, len = false, xuong = false;
        public Form1()
        {
            InitializeComponent();
            food = new Food(randFood);
            wall = new Wall();
            obstacle = new Obstacle();
        }
        // hien thi do hoa tren form
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            lbtocdo1.Text =(250 - timer1.Interval).ToString();
            paper = e.Graphics;
            obstacle.DrawObstacle(paper);
            food.DrawFood(paper);
            snake.DrawSnake(paper);
            wall.DrawWall(paper);
        }
        // khoi tao su kien tren ban phim
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData ==Keys.F2)
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
            if (food.FoodRec.IntersectsWith(obstacle.ObstacleRec))
            {
                food.FoodLocation(randFood);
            }
            if (food.FoodRec.IntersectsWith(obstacle.ObstacleRec1))
            {
                food.FoodLocation(randFood);
            }
            if (food.FoodRec.IntersectsWith(obstacle.ObstacleRec2))
            {
                food.FoodLocation(randFood);
            }
            if (food.FoodRec.IntersectsWith(obstacle.ObstacleRec3))
            {
                food.FoodLocation(randFood);
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
            //cap nhat lai man hinh
            this.Invalidate();
        }
        //ham va cham chet
        public void vacham()
        {
            for (int i = 1; i < snake.RanRec.Length; i++)
            {
                if (timer1.Interval == 5)
                {
                    MessageBox.Show("Bạn Đã Chiến Thắng");
                    snake = new Snake();
                }
                if (snake.RanRec[0].IntersectsWith(snake.RanRec[i]))
                {
                    Restart();
                }
                if (snake.RanRec[0].IntersectsWith(obstacle.ObstacleRec))
                {
                    Restart();
                }
                if (snake.RanRec[0].IntersectsWith(obstacle.ObstacleRec1))
                {
                    Restart();
                }
                if (snake.RanRec[0].IntersectsWith(obstacle.ObstacleRec2))
                {
                    Restart();
                }
                if (snake.RanRec[0].IntersectsWith(obstacle.ObstacleRec3))
                {
                    Restart();
                }
                if (snake.RanRec[0].X < 10 || snake.RanRec[0].X > 400)
                {
                    Restart();
                }
                if (snake.RanRec[0].Y < 10 || snake.RanRec[0].Y > 400)
                {
                    Restart();
                }
            }
        }
        void Restart()
        {
            this.Close();
            timer1.Enabled = false;
            toolStripStatusdiem.Text = "0";
            diem = 0;
            label1.Text = "Nhấn F2 Để Bắt Đầu Chơi";
            MessageBox.Show("Rắn Của Bạn Đã Chết Nhấn OK và chơi lại");
            snake = new Snake();
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
        }

        private void label2_Click(object sender, EventArgs e)
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
