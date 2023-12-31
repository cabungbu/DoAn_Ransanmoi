using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;

namespace RanSanMoi
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Drawing;
    using System.Linq;

    namespace RanSanMoi
    {
        class Snake
        {
            /// <summary>
            /// Khoi tao mang
            /// </summary>
            private Rectangle[] snakeRec;
            public Rectangle[] RanRec
            {
                get
                {
                    return snakeRec;
                }

            }
            private SolidBrush brush;
            private SolidBrush brush2;
            private int x, y, width, height;
            /// <summary>
            /// Hàm khởi tạo con rắn
            /// </summary>

            public Snake()
            {
                // khoi tao chieu dai con ran
                snakeRec = new Rectangle[3];
                // tao moi co ve voi mau xanh
                brush = new SolidBrush(Color.Green);
                //tao moi co ve cho dau con ran
                brush2 = new SolidBrush(Color.Red);
                // truyen toa do con ran
                x = 30;
                y = 10;
                width = 9;
                height = 9;
                // sap xep dot cua con ran
                for (int i = 0; i < snakeRec.Length; i++)
                {
                    snakeRec[i] = new Rectangle(x, y, width, height);
                    x -= 10;
                }
            }

            /// <summary>
            /// ve va to mau cho ran
            /// </summary>
            /// <param name="paper"></param>
            public virtual void DrawSnake(Graphics paper)
            {
                foreach (Rectangle rec in snakeRec)
                {
                    //to mau cho ran
                    paper.FillRectangle(brush, rec);
                    //to mau dau ran
                    paper.FillRectangle(brush2, snakeRec[0]);
                }
            }
            // ve ham di chuyen
            public virtual void RunSnake()
            {
                for (int i = RanRec.Length - 1; i > 0; i--)
                {
                    snakeRec[i] = RanRec[i - 1];
                }
            }
            //ran lon
            public virtual void GrowSnake()
            {
                List<Rectangle> rec = snakeRec.ToList();
                rec.Add(new Rectangle(snakeRec[snakeRec.Length - 1].X, snakeRec[snakeRec.Length - 1].Y, width, height));
                snakeRec = rec.ToArray();
            }
            //ve ham di chuyen
            public virtual void dichuyenxuong()
            {
                RunSnake();
                snakeRec[0].Y += 10;
            }
            public virtual void dichuyenlen()
            {
                RunSnake();
                snakeRec[0].Y -= 10;
            }
            public virtual void dichuyentrai()
            {
                RunSnake();
                snakeRec[0].X -= 10;
            }
            public virtual void dichuyenphai()
            {
                RunSnake();
                snakeRec[0].X += 10;
            }
        }
    }
}
