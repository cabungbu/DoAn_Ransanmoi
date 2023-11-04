using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RanSanMoi
{
    class Obstacle
    {
        private int x, y, x1, y1, x2, y2, x3, y3, width, height;
        private SolidBrush brush2;
        public Rectangle ObstacleRec;
        public Rectangle ObstacleRec1;
        public Rectangle ObstacleRec2;
        public Rectangle ObstacleRec3;
        public void DrawObstacle(Graphics paper)
        {
            width = 180;
            height = 20;
            ObstacleRec.X = x;
            ObstacleRec.Y = y;
            x = 30;
            y = 30;
            ObstacleRec1.X = x1;
            ObstacleRec1.Y = y1;
            x1 = 200;
            y1 = 100;
            ObstacleRec2.X = x2;
            ObstacleRec2.Y = y2;
            x2 = 30;
            y2 = 200;
            ObstacleRec3.X = x3;
            ObstacleRec3.Y = y3;
            x3 = 200;
            y3 = 300;
            ObstacleRec = new Rectangle(x, y, width, height);
            brush2 = new SolidBrush(Color.Violet);
            paper.FillRectangle(brush2, ObstacleRec);
            ObstacleRec1 = new Rectangle(x1, y1, width, height);
            paper.FillRectangle(brush2, ObstacleRec1);
            ObstacleRec2 = new Rectangle(x2, y2, width, height);
            paper.FillRectangle(brush2, ObstacleRec2);
            ObstacleRec3 = new Rectangle(x3, y3, width, height);
            paper.FillRectangle(brush2, ObstacleRec3);

        }

    }
}
