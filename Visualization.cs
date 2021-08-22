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
       static string  path = @"C:\Users\rozhk\source\repos\CircleRacing\DataMembers.txt";

        PictureBox[] Transport = new PictureBox[File.ReadAllLines(path).Length];
        Label[] TransportInfo = new Label[File.ReadAllLines(path).Length];

        PictureBox[] Finish = new PictureBox[File.ReadAllLines(path).Length];

        //Информация об автомобилях
        double[] speed=new double[File.ReadAllLines(path).Length];
        double[] procol = new double[File.ReadAllLines(path).Length];
        double[] dopParams = new double[File.ReadAllLines(path).Length];     

        //В разработке
        double[] distance = new double[File.ReadAllLines(path).Length];
        
        //Расположение и другие координаты
        private Point center;
        static int x1=70, x2=150, y1=80, y2=160;
        public static int LengthTrack;
        private int a2 = 120, b2 = (int)((Visualization.LengthTrack - 3000) * 0.05 + x2 - 50);
        int x , y;
            
    public Visualization()
        {
            InitializeComponent();
            //Центр PictureBox`а
            center = new Point(Picture_PB.Width / 2, Picture_PB.Height / 2);
            //Таймер
            Move_T.Tick += Move_T_Tick;
            Move_T.Enabled = !Move_T.Enabled;

            //Создание PictureBox`ов под количество машин
            for (int i = 0; i<Transport.Length; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 20;
                pictureBox.Height = 20;
                pictureBox.BackColor = Color.Black;
                pictureBox.Location = new Point(Picture_PB.Width / 2, Picture_PB.Height / 2);
                Transport[i] = pictureBox;
                Picture_PB.Controls.Add(pictureBox);
            }

            //Создание Label`ов под количество машин
            for (int i = 0; i < Transport.Length; i++)
            {
                Label Labelmini = new Label();
                Labelmini.Location = new Point(30+i*200,35);
                TransportInfo[i] = Labelmini;
                Picture_PB.Controls.Add(Labelmini);
            }

            //Взятие данных из файла
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < Transport.Length; i++)
            {
                //Маски
                var rgSpeed = new Regex(@"Скорость: (.*); Вероятность");
                var rgProcol = new Regex(@"колеса: (.*); ");
                //Авто
                var rgAutoPeople = new Regex(@"машине: (.*),");
                //Грузовик
                var rgTruckWeight = new Regex(@"груза: (.*),");
                //Мотоцикл
                var rgMotorSidecar = new Regex(@"коляски: (.*),");

                //Извлечение данных из строки
                var SpeedResult = rgSpeed.Match(lines[i]).Groups[1].Value;
                var ProcolResult = rgProcol.Match(lines[i]).Groups[1].Value;
                string DopParamsResult = "";

                //Особые характеритики ТС
                if (lines[i].IndexOf("Автомобиль") > -1)
                    DopParamsResult = rgAutoPeople.Match(lines[i]).Groups[1].Value;
                else if (lines[i].IndexOf("Грузовик") > -1)
                    DopParamsResult = rgTruckWeight.Match(lines[i]).Groups[1].Value;
                else if(lines[i].IndexOf("Мотоцикл") > -1)
                {
                    DopParamsResult = rgMotorSidecar.Match(lines[i]).Groups[1].Value;
                    if (DopParamsResult.Trim() == "Есть")
                        DopParamsResult = "1";
                    else if (DopParamsResult == "-")
                        DopParamsResult = "0";
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
        int tick = 0;
        private void Move_T_Tick(object sender, EventArgs e)
        {            
            //Увеличение вероятности прокола колеса
           for (int i = 0; i<Transport.Length;i++)
            {
                procol[i] += 0.005;
            }

            Refresh();

            tick++;
            MovePictureboxes(procol,tick);
        }

        //Движение машинок
        int timerLeft = 100;
               
        private void MovePictureboxes(double[] procol, int tick)
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
                    loc.Offset(-Transport[i].Width / 2, -Transport[i].Height / 2);
                    Transport[i].Location = loc;

                //Условие прокола колеса  
                if (procol[i] <= 1.5)
                    speed[i] += speed[i] * 0.001;
                else
                {
                    if (timerLeft > 0)
                    {
                        speed[i] += 0;
                        timerLeft = timerLeft - 1;
                    }
                    else
                    {
                        procol[i] = 0;
                        speed[i] += speed[i] * 0.001;
                        timerLeft = 100;
                    }
                }
                TransportInfo[i].Text = Transport[i].Location.ToString();
            }

            
            for(int i =0;i<Transport.Length;i++)
            {
                double D = (tick / 4.6) * 2 * speed[i];
                distance[i] = D;
            }

        }
    }
}