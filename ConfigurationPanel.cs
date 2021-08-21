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
            if (File.ReadAllLines(@"C:\Users\rozhk\source\repos\CircleRacing\DataMembers.txt").Length >= 10)
            {
                MessageBox.Show("Достигнут лимит количества участиков");
            }
            else
            {
                if (AutoPunctureProbability_Text.Text == String.Empty)
                {
                    MessageBox.Show("Введите вероятность прокола колеса автомобиля");
                    return;
                }
                else
                {
                    string DataAuto = "Автомобиль. Скорость: " + AutoSpeed_TB.Value.ToString() + "; Вероятность прокола колеса: " + AutoPunctureProbability_Text.Text.Replace(".", ",") + "; Количество человек в машине: " + PeopleInAuto_NUD.Value.ToString() + Environment.NewLine+"; ";
                    File.AppendAllText(path, DataAuto); 
                    AutoSpeed_TB.Value = 1;
                    ASpeed_L.Text = AutoSpeed_TB.Value.ToString();
                    AutoPunctureProbability_Text.Text = "";
                    PeopleInAuto_NUD.Value = 1;
                }
            }
            
        }
        //Регистрация грузовика
        private void RegTruck_B_Click(object sender, EventArgs e)
        {
            if (File.ReadAllLines(@"C:\Users\rozhk\source\repos\CircleRacing\DataMembers.txt").Length >= 10)
            {
                MessageBox.Show("Достигнут лимит количества участиков");
            }
            else
            {
                if (TruckPunctureProbability_Text.Text == String.Empty)
                {
                    MessageBox.Show("Введите вероятность прокола колеса грузовика");
                    return;
                }
                else if(TruckWeight_Text.Text == String.Empty)
                {
                    MessageBox.Show("Введите веc груза для грузовика");
                    return;
                }
                else {
                    string DataTruck = "Грузовик. Скорость: " + TruckSpeed_TB.Value.ToString() + "; Вероятность прокола колеса: " + TruckPunctureProbability_Text.Text.Replace(".", ",") + "; Вес груза: " + TruckWeight_Text.Text + Environment.NewLine + "; ";
                    File.AppendAllText(path, DataTruck);
                    TruckSpeed_TB.Value = 1;
                    TSpeed_L.Text = TruckSpeed_TB.Value.ToString();
                    TruckPunctureProbability_Text.Text = "";
                    TruckWeight_Text.Text = "";
                }               
            }
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
            if (File.ReadAllLines(@"C:\Users\rozhk\source\repos\CircleRacing\DataMembers.txt").Length >= 10)
            {
                MessageBox.Show("Достигнут лимит количества участиков");
            }
            else
            {
                if (MotorPunctureProbability_Text.Text == String.Empty)
                {
                    MessageBox.Show("Введите вероятность прокола колеса мотоцикла");
                    return;
                }
                else
                {
                    string DataMotor = "Мотоцикл. Скорость: " + MotorSpeed_TB.Value.ToString() + "; Вероятность прокола колеса: " + MotorPunctureProbability_Text.Text.Replace(".", ",") + "; Наличие коляски: " + result + Environment.NewLine + "; ";
                    File.AppendAllText(path, DataMotor);
                    MotorSpeed_TB.Value = 1;
                    MSpeed_L.Text = MotorSpeed_TB.Value.ToString();
                    MotorPunctureProbability_Text.Text = "";
                    Presence_Chek.Checked = false;
                }                
            }
        }
        
        //Возврат к списку участников
        private void ConfigurationPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            new EditMembers().Show();
        }
    }
}
