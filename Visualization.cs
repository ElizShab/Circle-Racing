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
    {   //Массивы переменных для извлечения парраметров из файла
        PictureBox[] Transport;
        double[] speed=new double[10];
        double[] procol = new double[10];
        double[] dopParams = new double[10];        

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

            //Проба работы через массив
            Transport = new PictureBox[] { pictureBox1, pictureBox2};

            //Взятие данных из файла
            string[] lines = File.ReadAllLines(@"C:\Users\rozhk\source\repos\CircleRacing\DataMembers.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                //Маски
                var rgSpeed = new Regex(@"Скорость: (.*); Вероятность");
                var rgProcol = new Regex(@"колеса: (.*); ");
                //Авто
                var rgAutoPeople = new Regex(@"машине: (.*);");
                //Грузовик
                var rgTruckWeight = new Regex(@"груза: (.*);");
                //Мотоцикл
                var rgMotorSidecar = new Regex(@"коляски: (.*);");

                //Извлечение данных из строки
                var SpeedResult = rgSpeed.Match(lines[i]).Groups[1].Value;
                var ProcolResult = rgProcol.Match(lines[i]).Groups[1].Value;
                string DopParamsResult = "";

                if (lines[i].IndexOf("Автомобиль") > -1)
                    DopParamsResult = rgAutoPeople.Match(lines[i]).Groups[1].Value;
                else if (lines[i].IndexOf("Грузовик") > -1)
                    DopParamsResult = rgTruckWeight.Match(lines[i]).Groups[1].Value;
                else if(lines[i].IndexOf("Мотоцикл") > -1)
                {
                    DopParamsResult = rgMotorSidecar.Match(lines[i]).Groups[1].Value;
                    if (DopParamsResult == "Есть")
                        DopParamsResult = 1.ToString();
                    else if (DopParamsResult == "-")
                        DopParamsResult = 0.ToString();
                }    

                //Присвоение извлечённых данных нужным массивам
                speed[i] = Convert.ToInt32(SpeedResult);
                procol[i] = Convert.ToDouble(ProcolResult);
                dopParams[i] = Convert.ToInt32(DopParamsResult);
            }            
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
           for (int i = 0; i<procol.Length;i++)
            {
                procol[i] += 0.005;
            }
            Refresh();
            MovePictureboxes(procol);
            label1.Text = pictureBox2.Location.ToString();
        }

        //Движение машинок
        private void MovePictureboxes(double[] procol)
        {
            //Точка для передвижения
            Point loc = new Point();           

            //Движение
            for (int i = 0; i < Transport.Length; i++)
            {
                x = (int)(b2 * Math.Cos(speed[i]));
                y = (int)(a2 * Math.Sin(speed[i]));
                loc = new Point(x, y);
                loc.Offset(center.X, center.Y);
                loc.Offset(-pictureBox2.Width / 2, -pictureBox2.Height / 2);
                Transport[i].Location = loc;
            }

            //Условие прокола колеса (Имитация), пока что без возврата к движению
            for (int i = 0; i < Transport.Length; i++)
            {
                if (procol[i] <= 1.5)
                    speed[i] += speed[i] * 0.001;
                else
                {
                    speed[i] += 0;
                    //Подождать n секунд и продолжить движение, так же свести вероятность прокола на  0
                    // ...
                }
            }           
        }
    }
}