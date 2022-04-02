using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hackathon_Project_GUI
{
    public partial class MapaForm : Form
    {
        public MapaForm()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            
        }
        private void over(object sender, EventArgs e)
        {
            button2.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.nazad_dugme_oc;
        }

        private void leave(object sender, EventArgs e)
        {
            button2.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.nazad_dugme;
        }

        private void idiNazadButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PocetniMeniForm pocetniMeni = new PocetniMeniForm();
            pocetniMeni.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParkingForm pocetniMeni = new ParkingForm();
            pocetniMeni.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void help(object sender, EventArgs e)
        {
            
        }
    }
}
