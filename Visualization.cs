using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CircleRacing
{
      
    public partial class Visualization : Form
    {  
        //Тестовые переменные скорости
        double speed1 = 40, speed2 = 120;
        double procol1, procol2;

        //Массивы переменных для извлечения парраметров из файла
        int[] speed=new int [10];
        double[] procol = new double[10];
        

        //Расположение и другие координаты
        private Point center;
        static int x1=70, x2=150, y1=80, y2=160;
        public static int LengthTrack;
        private int a1 = 100, b1 = (int)((Visualization.LengthTrack - 3000) * 0.05 + x1 + 40), a2 = 120, b2 = (int)((Visualization.LengthTrack - 3000) * 0.05 + x2 - 50);
        int x , y;
        

        public Visualization()
        {
            InitializeComponent();
            //Центр PictureBox`а
            center = new Point(Picture_PB.Width / 2, Picture_PB.Height / 2);
            //Таймер
            Move_T.Tick += Move_T_Tick;
            Move_T.Enabled = !Move_T.Enabled;

            //Взятие данных из файла
            string[] lines = File.ReadAllLines(@"C:\Users\rozhk\source\repos\CircleRacing\DataMembers.txt");
            for (int i = 1; i < lines.Length; i++)
            {
                //Маски
                var rgSpeed = new Regex(@"Скорость: (.*); Вероятность");
                var rgProcol = new Regex(@"колеса: (.*); ");

                //Извлечение данных из строки
                var SpeedResult = rgSpeed.Match(lines[i]).Groups[1].Value;
                var ProcolResult = rgProcol.Match(lines[i]).Groups[1].Value;

                //Присвоение извлечённых данных нужным массивам
                speed[i] = Convert.ToInt32(SpeedResult);
                procol[i] = Convert.ToDouble(ProcolResult);
            }            
            //Проверка корректности извлечённых данных
            label1.Text = procol[5].ToString();
        }

        //Рисование простых объектов
        private void Picture_PB_Paint(object sender, PaintEventArgs e)
        {                      
            if (!Move_T.Enabled) return;
            using (Pen pen = new Pen(Color.Black))  
            {
                // Стартовая/Финишная линия
                Point StartPoint = new Point(Picture_PB.Width/2, center.Y-y1);
                Point EndPoint = new Point(Picture_PB.Width / 2, center.Y - y2);
                e.Graphics.DrawLine(pen, StartPoint, EndPoint);

                //Изображение трассы
                int x = (int)((Visualization.LengthTrack - 3000) * 0.05 + Visualization.x1);
                int xx = (int)((Visualization.LengthTrack - 3000) * 0.05 + Visualization.x2);
                e.Graphics.DrawEllipse(pen, Rectangle.FromLTRB(center.X - x, center.Y - y1, center.X + x, center.Y + y1));
                e.Graphics.DrawEllipse(pen, Rectangle.FromLTRB(center.X - xx, center.Y - y2, center.X + xx, center.Y + y2));
            }
        }

        //Каждый тик таймера
        private void Move_T_Tick(object sender, EventArgs e)
        {
            //Тестирование прокола колеса
            procol1 += 0.005;
            procol2 += 0.005;

            Refresh();
            MovePictureboxes(procol1,procol2);
        }

        //Движение машинок
        private void MovePictureboxes(double procol1, double procol2)
        {
            //Точка для передвижения
            Point loc = new Point();
            
            //Движение первого объекта (Двигается не верно, тестируется)
            x = (int)(b1 * Math.Cos(0)+ speed1);
            y = (int)(a1 * Math.Sin(1)+ speed1);
            loc = new Point(x, y);
            loc.Offset(center.X, center.Y);
            loc.Offset(-pictureBox1.Width / 2, -pictureBox1.Height / 2);
            pictureBox1.Location = loc;

            //Движение второго объекта (ДВижется верно, но не имеет единого старта, не изменяется)
            x = (int)(b2 * Math.Cos(speed2));
            y = (int)(a2 * Math.Sin(speed2));
            loc = new Point(x, y);
            loc.Offset(center.X, center.Y);
            loc.Offset(-pictureBox2.Width / 2, -pictureBox2.Height / 2);
            pictureBox2.Location = loc;

            //Условие прокола колеса (Имитация), пока что без возврата к движению
            if (procol1 <= 1.5) 
               speed1 += speed1 * 0.001;
            else
            {
                speed1 += 0;
                //Подождать n секунд и продолжить движение, так же свести вероятность прокола на  0
                // ...
            }

            if (procol2 <= 1.5) 
              speed2 += speed2 * 0.001;
            else
            {
                speed2 += 0;
                //Подождать n секунд и продолжить движение, так же свести вероятность прокола на  0
                // ...
            }
        }
    }
}