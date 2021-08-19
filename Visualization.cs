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
        //Шаблоны для проверки
        double speed1 = 40, speed2 = 120;
        //

        Random random = new Random();
        private Point center;
        static int x1=70, x2=150, y1=80, y2=160;
        public static int LengthTrack;
        private int a1 = 100, b1 = (int)((Visualization.LengthTrack - 3000) * 0.05 + x1 + 40), a2 = 120, b2 = (int)((Visualization.LengthTrack - 3000) * 0.05 + x2 - 50);
        double procol1, procol2;
        int tick = 0;
        int x , y;
        

        public Visualization()
        {
            InitializeComponent();
            Move_T.Tick += Move_T_Tick;
            center = new Point(Picture_PB.Width / 2, Picture_PB.Height / 2);
            Move_T.Enabled = !Move_T.Enabled;
            procol1 = random.NextDouble(); procol2 = random.NextDouble();
            label1.Text = procol1.ToString();
        }

        private void Picture_PB_Paint(object sender, PaintEventArgs e)
        {                      
            if (!Move_T.Enabled) return;
            using (Pen pen = new Pen(Color.Black))  
            {
                int x = (int)((Visualization.LengthTrack - 3000) * 0.05 + Visualization.x1);
                int xx = (int)((Visualization.LengthTrack - 3000) * 0.05 + Visualization.x2);
                Point StartPoint = new Point(Picture_PB.Width/2, center.Y-y1);
                Point EndPoint = new Point(Picture_PB.Width / 2, center.Y - y2);
                e.Graphics.DrawLine(pen, StartPoint, EndPoint);
                e.Graphics.DrawEllipse(pen, Rectangle.FromLTRB(center.X - x, center.Y - y1, center.X + x, center.Y + y1));
                e.Graphics.DrawEllipse(pen, Rectangle.FromLTRB(center.X - xx, center.Y - y2, center.X + xx, center.Y + y2));
            }
        }

        private void Move_T_Tick(object sender, EventArgs e)
        {
            Refresh();
            procol1 += 0.005;
            procol2 += 0.005;
            tick += 1;
            MovePictureboxes(procol1,procol2, tick);
        }

        private void MovePictureboxes(double procol1, double procol2, int tick)
        {
            Point loc = new Point();
            
            x = (int)(b1 * Math.Cos(0)+ speed1);
            y = (int)(a1 * Math.Sin(1)+ speed1);
            loc = new Point(x, y);
            loc.Offset(center.X, center.Y);
            loc.Offset(-pictureBox1.Width / 2, -pictureBox1.Height / 2);
            pictureBox1.Location = loc;

            x = (int)(b2 * Math.Cos(speed2));
            y = (int)(a2 * Math.Sin(speed2));
            loc = new Point(x, y);
            loc.Offset(center.X, center.Y);
            loc.Offset(-pictureBox2.Width / 2, -pictureBox2.Height / 2);
            pictureBox2.Location = loc;

            //Прокол колеса                 

            if (procol1 <= 1.5) 
               speed1 += speed1 * 0.001;
            else
            {
                speed1 += 0;
            }

            if (procol2 <= 1.5) 
              speed2 += speed2 * 0.001;
            else
            {
                speed2 += 0;
            }
        }
    }
}