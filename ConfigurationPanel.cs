using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CircleRacing
{
    public partial class ConfigurationPanel : Form
    {
        //Ссылка на файл
        string path = @"C:\Users\rozhk\source\repos\CircleRacing\DataMembers.txt";

        public ConfigurationPanel()
        {
            InitializeComponent();            
        }

        //Демонстрация выбранной скорости для ТС
        private void AutoSpeed_TB_Scroll(object sender, EventArgs e)
        {
            ASpeed_L.Text = AutoSpeed_TB.Value.ToString();
        }
        private void TruckSpeed_TB_Scroll(object sender, EventArgs e)
        {
            TSpeed_L.Text = TruckSpeed_TB.Value.ToString();
        }
        private void MotorSpeed_TB_Scroll(object sender, EventArgs e)
        {
            MSpeed_L.Text = MotorSpeed_TB.Value.ToString();
        }

        //Регистрация автомобиля
        public void RegAuto_B_Click(object sender, EventArgs e)
        {
            string DataAuto = "Автомобиль. Скорость: "+ AutoSpeed_TB.Value.ToString() + "; Вероятность прокола колеса: " + AutoPunctureProbability_Text.Text.Replace(".", ",") + "; Количество человек в машине: " + PeopleInAuto_NUD.Value.ToString() + Environment.NewLine;
            File.AppendAllText(path, DataAuto);
        }
        //Регистрация грузовика
        private void RegTruck_B_Click(object sender, EventArgs e)
        {
            string DataTruck = "Грузовик. Скорость: " + TruckSpeed_TB.Value.ToString() + "; Вероятность прокола колеса: " + TruckPunctureProbability_Text.Text.Replace(".",",") + "; Вес груза: " + TruckWeight_Text.Text + Environment.NewLine;
            File.AppendAllText(path, DataTruck);
        }

        //Регистрация мотоцикла
        private void RegMotorcycle_B_Click(object sender, EventArgs e)
        {
            //Наличие коляски
            bool Chek = Presence_Chek.Checked;
            string result;
            if (Chek == true)
                result = "Есть";
            else
                result = "-";
            //Регистрация
            string DataTruck = "Мотоцикл. Скорость: " + MotorSpeed_TB.Value.ToString() + "; Вероятность прокола колеса: " + MotorPunctureProbability_Text.Text.Replace(".", ",") + "; Наличие коляски: " + result + Environment.NewLine;
            File.AppendAllText(path, DataTruck);
        }
        
        //Возврат к списку участников
        private void ConfigurationPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            new EditMembers().Show();
        }
    }
}
