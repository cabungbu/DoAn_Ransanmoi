using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace RanSanMoi
{
    class Obstacle
    {
        public int x;
        public int x1;
        public int x2;
        public int x3;
        public int y;
        public int y1;
        public int y2;
        public int y3;

        public Rectangle[] ObstacleRec;
       
        public Rectangle[] ObstacleRec1;
        
        public Rectangle[] ObstacleRec2;
     
        public Rectangle[] ObstacleRec3;
      
        private SolidBrush brush2;
        public System.Drawing.Image glass;
        public void RunObstacle()
        {

            for (int i = ObstacleRec.Length - 1; i >= 0; i--)
            {
                ObstacleRec[i].X += 20;
                if (ObstacleRec[i].X >= 400)
                    ObstacleRec[i].X = 410 - ObstacleRec[i].X;
            }

            for (int i = ObstacleRec1.Length - 1; i >= 0; i--)
            {
                ObstacleRec1[i].X += 20;
                if (ObstacleRec1[i].X >= 400)
                    ObstacleRec1[i].X = 410 - ObstacleRec1[i].X;
            }
            for (int i = ObstacleRec2.Length - 1; i >= 0; i--)
            {
                ObstacleRec2[i].X += 20;
                if (ObstacleRec2[i].X >= 400)
                    ObstacleRec2[i].X = 410 - ObstacleRec2[i].X;
            }
            for (int i = ObstacleRec3.Length - 1; i >= 0; i--)
            {
                ObstacleRec3[i].X += 20;
                if (ObstacleRec3[i].X >= 400)
                    ObstacleRec3[i].X = 410 - ObstacleRec3[i].X;
            }

        }
        public Obstacle(int num)
        {
            brush2 = new SolidBrush(Color.Violet);
            string resourceName = "RanSanMoiVH.Resources.obstacle.png";

            // Lấy luồng dữ liệu của tài nguyên nhúng
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                // Tạo một đối tượng hình ảnh từ luồng dữ liệu
                glass = System.Drawing.Image.FromStream(stream);
            }
            if (num == 2)
            {
                ObstacleRec = new Rectangle[9];
                ObstacleRec1 = new Rectangle[9];
                x = 180;
                y = 100;
                for (int i = 0; i < ObstacleRec.Length; i++)
                {
                    ObstacleRec[i] = new Rectangle(x, y, 20, 20);
                    x -= 20;
                }
                x1 = 350;
                y1 = 250;
                for (int i = 0; i < ObstacleRec1.Length; i++)
                {
                    ObstacleRec1[i] = new Rectangle(x1, y1, 20, 20);
                    x1 -= 20;
                }
              
            }
            else if (num == 4)
            {
                ObstacleRec = new Rectangle[9];
                ObstacleRec1 = new Rectangle[9];
                ObstacleRec2 = new Rectangle[9];
                ObstacleRec3 = new Rectangle[9];
                x = 180;
                y = 80;
                for (int i = 0; i < ObstacleRec.Length; i++)
                {
                    ObstacleRec[i] = new Rectangle(x, y, 20, 20);
                    x -= 20;
                }
                int x1 = 350;
                int y1 = 180;
                for (int i = 0; i < ObstacleRec1.Length; i++)
                {
                    ObstacleRec1[i] = new Rectangle(x1, y1, 20, 20);
                    x1 -= 20;
                }
                int x2 = 180;
                int y2 = 260;
                for (int i = 0; i < ObstacleRec2.Length; i++)
                {
                    ObstacleRec2[i] = new Rectangle(x2, y2, 20, 20);
                    x2 -= 20;
                }
                int x3 = 350;
                int y3 = 330;
                for (int i = 0; i < ObstacleRec3.Length; i++)
                {
                    ObstacleRec3[i] = new Rectangle(x3, y3, 20, 20);
                    x3 -= 20;
                }
            }
            
        }
        public void DrawObstacle(Graphics paper)
        {
           
            if (ObstacleRec != null)
                foreach (Rectangle rec in ObstacleRec)
                {
                    paper.DrawImage(glass, rec);


                }
            if (ObstacleRec1 != null)
                foreach (Rectangle rec in ObstacleRec1)
                {
                    paper.DrawImage(glass, rec);

                }
            if (ObstacleRec2 != null)
                foreach (Rectangle rec in ObstacleRec2)
                {
                    paper.DrawImage(glass, rec);

                }
            if (ObstacleRec3 != null)
                foreach (Rectangle rec in ObstacleRec3)
                {
                    paper.DrawImage(glass, rec);

                }
        }
       

    }
}
