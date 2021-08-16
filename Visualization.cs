using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CircleRacing
{
    public partial class Visualization : Form
    {
        //Большие и малые полуоси эллипсов
        private int a1 = 100, b1 = 310, a2 = 120, b2 = 330;
        //Центра эллипса
        private Point center;
        double angle1 = 0, angle2 = 0;

        private void Picture_PB_Paint(object sender, PaintEventArgs e)
        {
            if (!Move_T.Enabled) return;
            using (Pen pen = new Pen(Color.Black))
            {
                e.Graphics.DrawEllipse(pen, Rectangle.FromLTRB(center.X - 280, center.Y - 70, center.X + 280, center.Y + 70));
                e.Graphics.DrawEllipse(pen, Rectangle.FromLTRB(center.X - 360, center.Y - 150, center.X + 360, center.Y + 150));
            }
        }
        public Visualization()
        {
            InitializeComponent();
            Move_T.Tick += Move_T_Tick;
            DoubleBuffered = true;
            center = new Point(ClientSize.Width / 2, ClientSize.Height / 2);
            Move_T.Enabled = !Move_T.Enabled;
        }

        private void Move_T_Tick(object sender, EventArgs e)
        {
            Refresh();
            MovePictureboxes();
        }

        private void MovePictureboxes()
        {
            int x, y;
            x = (int)(b1 * Math.Cos(angle1));
            y = (int)(a1 * Math.Sin(angle1));
            Point loc = new Point(x, y);
            //Перенос к центру вращения
            loc.Offset(center.X, center.Y);
            //Перенос к центру pictureBox
            loc.Offset(-pictureBox1.Width / 2, -pictureBox1.Height / 2);
            pictureBox1.Location = loc;
            x = (int)(b2 * Math.Cos(angle2));
            y = (int)(a2 * Math.Sin(angle2));
            loc = new Point(x, y);
            //Перенос к центру вращения
            loc.Offset(center.X, center.Y);
            //Перенос к центру pictureBox
            loc.Offset(-pictureBox2.Width / 2, -pictureBox2.Height / 2);
            pictureBox2.Location = loc;
            //Первый будет двигаться медленнее, а второй быстрее, т.к. второй угол быстрее растёт
            angle1 += 0.1; angle2 += 0.3;
        }
    }
}