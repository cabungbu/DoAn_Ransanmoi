using RanSanMoi.RanSanMoi;
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
    public partial class Form3 : Form
    {
        int diem1 = 0;
        int diem2 = 0;
        Random randFood = new Random();
        Food food;
        Wall wall;
        Obstacle obstacle;
        Graphics paper;
        Snake snake1 = new Snake();
        Ran2 snake2 = new Ran2(); 
        Boolean trai = false, phai = false, len = false, xuong = false;
        Boolean trai2 = false, phai2 = false, len2 = false, xuong2 = false;
        bool Ran1Win = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripDiem1.Text = diem1.ToString();
            toolStripDiem2.Text = diem2.ToString();
            if (xuong == true)
            {
                snake1.dichuyenxuong();
            }
            if (len == true)
            {
                snake1.dichuyenlen();
            }
            if (trai == true)
            {
                snake1.dichuyentrai();
            }
            if (phai == true)
            {
                snake1.dichuyenphai();
            }

            ///RAN2
            if (xuong2 == true)
            {
                snake2.dichuyenxuong();
            }
            if (len2 == true)
            {
                snake2.dichuyenlen();
            }
            if (trai2 == true)
            {
                snake2.dichuyentrai();
            }
            if (phai2 == true)
            {
                snake2.dichuyenphai();
            }

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
            for (int i = 0; i < snake1.RanRec.Length; i++)
            {
                if (snake1.RanRec[i].IntersectsWith(food.FoodRec))
                {
                    timer1.Interval -= 5;
                    diem1 += 10;
                    snake1.GrowSnake();
                    food.FoodLocation(randFood);
                }
            }

            for (int i = 0; i < snake2.RanRec.Length; i++)
            {
                if (snake2.RanRec[i].IntersectsWith(food.FoodRec))
                {
                    timer1.Interval -= 5;
                    diem2 += 10;
                    snake2.GrowSnake();
                    food.FoodLocation(randFood);
                }
            }
            vacham();
            this.Invalidate();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void vacham()
        {
            for (int i = 1; i < snake1.RanRec.Length; i++)
            {
                if (snake1.RanRec[0].IntersectsWith(snake1.RanRec[i]))
                {
                    Ran1Win = false;
                    Restart();
                    return;
                }
            }
            for (int i = 1; i < snake2.RanRec.Length; i++)
            {
                if (snake2.RanRec[0].IntersectsWith(snake2.RanRec[i]))
                {
                    Ran1Win = true;
                    Restart();
                    return;
                }
            }
            for (int i = 0; i < obstacle.ObstacleRec.Length; i++)
            {
                if (snake1.RanRec[0].IntersectsWith(obstacle.ObstacleRec[i]))
                {
                    Restart();
                    Ran1Win = false;
                    return;
                }
                if (snake1.RanRec[0].IntersectsWith(obstacle.ObstacleRec1[i]))
                {
                    Restart();
                    Ran1Win = false;
                    return;
                }
                if (snake1.RanRec[0].IntersectsWith(obstacle.ObstacleRec2[i]))
                {
                    Restart();
                    Ran1Win = false;
                    return;
                }
                if (snake1.RanRec[0].IntersectsWith(obstacle.ObstacleRec3[i]))
                {
                    Restart();
                    Ran1Win = false;
                    return;
                }
                if (snake2.RanRec[0].IntersectsWith(obstacle.ObstacleRec[i]))
                {
                    Restart();
                    Ran1Win = true;
                    return;
                }
                if (snake2.RanRec[0].IntersectsWith(obstacle.ObstacleRec1[i]))
                {
                    Restart();
                    Ran1Win = true;
                    return;
                }
                if (snake2.RanRec[0].IntersectsWith(obstacle.ObstacleRec2[i]))
                {
                    Restart();
                    Ran1Win = true;
                    return;
                }
                if (snake2.RanRec[0].IntersectsWith(obstacle.ObstacleRec3[i]))
                {
                    Restart();
                    Ran1Win = true;
                    return;
                }
                if (snake1.RanRec[0].X < 10 || snake1.RanRec[0].X > 400)
                {
                    Restart();
                    Ran1Win = false;
                    return;
                }
                if (snake1.RanRec[0].Y < 10 || snake1.RanRec[0].Y > 400)
                {
                    Restart();
                    Ran1Win = false;
                    return;
                }
                if (snake2.RanRec[0].X < 10 || snake2.RanRec[0].X > 400)
                {
                    Restart();
                    Ran1Win = true;
                    return;
                }
                if (snake2.RanRec[0].Y < 10 || snake2.RanRec[0].Y > 400)
                {
                    Restart();
                    Ran1Win = true;
                    return;
                }
            }
        }
        void Restart()
        {
            this.Close();
            timer1.Enabled = false;

            MessageBox.Show("Diem ran 1: " + diem1.ToString()+ " diem ran 2: "+ diem2.ToString());
            label1.Text = "Nhấn F2 Để Bắt Đầu Chơi";
            diem1 = 0;
            diem2 = 0;
            toolStripDiem1.Text = "0";
            toolStripDiem2.Text = "0";
        }
      

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                timer1.Enabled = true;
                trai = false; phai = false; len = false; xuong = false;
                trai2 = false; phai2 = false; len2 = false; xuong2 = false;
                label3.Text = "";

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
            if (e.KeyData == Keys.W && xuong2 == false)
            {
                len2 = true;
                xuong2 = false;
                trai2 = false;
                phai2 = false;
            }
            if (e.KeyData == Keys.S && len2 == false)
            {
                len2 = false;
                xuong2 = true;
                trai2 = false;
                phai2 = false;
            }
            if (e.KeyData == Keys.A && phai2 == false)
            {
                len2 = false;
                xuong2 = false;
                trai2 = true;
                phai2 = false;
            }
            if (e.KeyData == Keys.D & trai2 == false)
            {
                len2 = false;
                xuong2 = false;
                trai2 = false;
                phai2 = true;
            }
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            lbtocdo1.Text = (250 - timer1.Interval).ToString();
            paper = e.Graphics;

            food.DrawFood(paper);
            snake1.DrawSnake(paper);
            snake2.DrawSnake(paper);
            wall.DrawWall(paper);
            obstacle.DrawObstacle(paper);
        }

        public Form3()
        {
            InitializeComponent();
            food = new Food(randFood);
            wall = new Wall();
            obstacle = new Obstacle(4);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
