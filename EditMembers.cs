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
    public partial class EditMembers : Form
    {
        //Количество участников
        public int NumberParti;
        //Файл с данными об участниках
        string path = @"C:\Users\rozhk\source\repos\CircleRacing\DataMembers.txt";

        public EditMembers()
        {
            InitializeComponent();
            //Количество участников
            NumberParti = listBox1.Items.Count;

            //Проверка и создание файла
            if (!File.Exists(path))
            {
                File.WriteAllText(path,null);

            }
            else
            {
                listBox1.Items.AddRange(File.ReadAllLines(path, Encoding.Default));
            }

        }

        //Переход к окну регистрации участников
        private void AddMember_B_Click(object sender, EventArgs e)
        {
            if (NumberParti >= 10)
            {
                MessageBox.Show("Достигнут лимит количества участиков");
            }
            else 
            {
                new ConfigurationPanel().Show();
                this.Hide();
                using (StreamWriter sw = new StreamWriter(path))
                {
                    for (int i = 0; i < listBox1.Items.Count; i++)
                        sw.WriteLine(listBox1.Items[i].ToString());
                }
            }            
        }

        //Удаление участников
        private void DeleteMember_B_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            else
                MessageBox.Show("Выберите элемент");
        }

        //Обновление файла      
        private void EditMembers_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                    sw.WriteLine(listBox1.Items[i].ToString());
            }
            new Start_menu().Show();
        }
    }
}
