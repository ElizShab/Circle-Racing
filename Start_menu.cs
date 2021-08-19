using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleRacing
{
    public partial class Start_menu : Form
    {        
        public Start_menu()
        {
            InitializeComponent();
                 }

        private void Start_B_Click(object sender, EventArgs e)
        {
            new Visualization().Show();
            this.Hide();
        }

        private void EditListMembers_B_Click(object sender, EventArgs e)
        {
            new EditMembers().Show();
            this.Hide();
        }

        public void TrackLength_NUD_ValueChanged(object sender, EventArgs e)
        {
            Visualization.LengthTrack = (int)TrackLength_NUD.Value;     
        }

        private void Start_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
