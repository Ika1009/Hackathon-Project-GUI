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
    public partial class PocetniMeniForm : Form
    {
        public PocetniMeniForm()
        {
            InitializeComponent();
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"D:\doc\Downloads\Frankie_MP3_320K_.wav");

            sp.PlayLooping();

            sp.Play();
        }

        private void igriceButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // sakriva ovu formu
            igriceMeniForm igriceMeniForma = new igriceMeniForm(); // kreira novu formu sa meni igricama
            igriceMeniForma.Show(); // pokazuje formu - igriceMeniForma
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            /*this.Hide(); 
            igriceMeniForm igriceMeniForma = new igriceMeniForm(); 
            igriceMeniForma.Show(); */
            
        }
    }
}
