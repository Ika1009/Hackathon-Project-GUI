﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_Project_GUI
{
    public partial class CreditsForm : Form
    {
        public CreditsForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PocetniMeniForm nazad = new PocetniMeniForm();
            nazad.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void over(object sender, EventArgs e)
        {
            button1.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.nazad_dugme_oc;
        }

        private void leave(object sender, EventArgs e)
        {
            button1.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.nazad_dugme;
        }

        private void CreditsForm_Load(object sender, EventArgs e)
        {

        }

        private void CreditsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PocetniMeniForm.turnOffMusic();
        }
    }
}
