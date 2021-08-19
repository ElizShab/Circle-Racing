using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CircleRacing
{
    public partial class EditMembers : Form
    {
        Start_menu SM = new Start_menu();
        public int NumberParti = 0;
        //Проверка
        int k = 3; int n = 8;
        public EditMembers()
        {
            InitializeComponent();

            //Количество участников
            NumberParti = listBox1.Items.Count;

            //Проверка
            listBox1.Items.Add(k + " / " + n);
        }

        private void AddMember_B_Click(object sender, EventArgs e)
        {
            new ConfigurationPanel().Show();
            listBox1.Items.Add("1");


            new Start_menu().label2.Text = "Количество участников: " + listBox1.Items.Count;
        }

        private void DeleteMember_B_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            else
                MessageBox.Show("выберите элемент");

        }

        private void EditMembers_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Start_menu().label2.Text = "Количество участников: " + listBox1.Items.Count;
        }
    }
}
