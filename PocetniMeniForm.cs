using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Media;
using System.Diagnostics;


namespace Hackathon_Project_GUI
{

    public partial class PocetniMeniForm : Form
    {
        public PocetniMeniForm()
        {
            
            InitializeComponent();

            settingsForm.pustiPesmu();

        }
        private void pomocover(object sender, EventArgs e)
        {
            pomocButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.pomoc_dugme_co;
        }

        private void pomocleave(object sender, EventArgs e)
        {
            pomocButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.pomoc_dugme;
        }
        private void lupaover(object sender, EventArgs e)
        {
            mestaButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.mesta_dugme2_co;
        }

        private void lupaleave(object sender, EventArgs e)
        {
            mestaButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.mesta_dugme2;
        }
        private void mapaover(object sender, EventArgs e)
        {
            lokacijeButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.lokacije_dugme_co;
        }

        private void mapaleave(object sender, EventArgs e)
        {
            lokacijeButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.lokacije_dugme;
        }
        private void igriceover(object sender, EventArgs e)
        {
            igriceButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.igrice_dugme_co;
        }

        private void igriceleave(object sender, EventArgs e)
        {
            igriceButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.igrice_dugme;
        }

        private void igriceButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // sakriva ovu formu
            igriceMeniForm igriceMeniForma = new igriceMeniForm(); // kreira novu formu sa meni igricama
            igriceMeniForma.Show(); // pokazuje formu - igriceMeniForma
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            settingsForm podesavanja = new settingsForm(); 
            podesavanja.Show(); 
        }

        private void lokacijeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapaForm mapForm = new MapaForm();
            mapForm.Show();
        }

        private void mestaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BiranjeVolonteraForm biranjeVolonteraForma = new BiranjeVolonteraForm();
            biranjeVolonteraForma.Show();
        }

        private void pomocButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodavanjeVolonteraForm dodavanjeVolonteraForma = new DodavanjeVolonteraForm();
            dodavanjeVolonteraForma.Show();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreditsForm credits = new CreditsForm();
            credits.Show();
        }
    }
}
