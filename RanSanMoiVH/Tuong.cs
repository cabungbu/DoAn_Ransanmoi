using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RanSanMoi
{
    class Wall
    {
        public void DrawWall(Graphics paper)
        {
            Pen p = new Pen(Color.Black, 10);
            paper.DrawRectangle(p, 5, 5, 410, 410);
        }
    }
}
