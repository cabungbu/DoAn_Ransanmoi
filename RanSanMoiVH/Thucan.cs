using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace RanSanMoi
{
    class Food
    {
        private int x, y, width, height;
        private SolidBrush brush;
        public Rectangle FoodRec;
        public System.Drawing.Image apple;
        public Food(Random randFood)
        {
            x = randFood.Next(1, 40) * 10;
            y = randFood.Next(1, 40) * 10;
            brush = new SolidBrush(Color.Red);
            width = 15; height = 15;
            string resourceName = "RanSanMoiVH.Resources.apple.png";

            // Lấy luồng dữ liệu của tài nguyên nhúng
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                // Tạo một đối tượng hình ảnh từ luồng dữ liệu
                apple = System.Drawing.Image.FromStream(stream);
            }

            FoodRec = new Rectangle(x,y,width,height);
        }
        public void FoodLocation(Random randFood)
        {
            x = randFood.Next(1, 40) * 10;
            y = randFood.Next(1, 40) * 10;
        }
        public void DrawFood(Graphics paper)
        {
            FoodRec.X = x;
            FoodRec.Y = y;
            paper.DrawImage(apple, FoodRec);
            //paper.FillRectangle(brush,FoodRec);
        }

    }
}
