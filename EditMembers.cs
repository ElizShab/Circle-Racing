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
        public EditMembers()
        {
            InitializeComponent();
        }

        private void AddMember_B_Click(object sender, EventArgs e)
        {
            new ConfigurationPanel().Show();
        }
    }
}
