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
    public partial class settingsForm : Form
    {
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer();

        public static string muzika= "Hackathon_Project_GUI.muzika1.wav"; // path za pesmu koja se menja
        
        public settingsForm()
        {
            InitializeComponent();
        }
        bool pusteno = true;

        private void button1_Click(object sender, EventArgs e)
        {
            sp.Stop();

            if (pusteno)
            {
                pusteno = false;
                ugasiMuzikuButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_off_dugme;
                sp.Stop();
            }
            else
            {
                ugasiMuzikuButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_on_dugme;
                pusteno = true;
                pustiPesmu();
            }

        }
        private void over56(object sender, EventArgs e)
        {
            if (pusteno) { ugasiMuzikuButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_on_dugme_co; ; }
            else { ugasiMuzikuButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_off_dugme_co; ; }

        }

        private void leav56(object sender, EventArgs e)
        {
            if (pusteno) { ugasiMuzikuButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_on_dugme; ; }
            else { ugasiMuzikuButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_on_dugme; }
        }
        private void over1(object sender, EventArgs e)
        {
            if (muzika1) { muzika1Button.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_1_on_dugme_co; }
            else { muzika1Button.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_1_off_dugme_co; }
       
        }

        private void leave1(object sender, EventArgs e)
        {
            if (muzika1) { muzika1Button.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_1_on_dugme; }
            else { muzika1Button.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_1_off_dugme; }
        }

        private void over2(object sender, EventArgs e)
        {
            if (muzika2) { muzika2button.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_2_on_dugme_co; }
            else { muzika2button.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_2_off_dugme_co; }

        }

        private void leave2(object sender, EventArgs e)
        {
            if (muzika2) { muzika2button.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_2_on_dugme; }
            else { muzika2button.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_2_off_dugme; }
        }
        private void over(object sender, EventArgs e)
        {
            nazadButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.nazad_dugme_oc;
            

        }

        private void leave(object sender, EventArgs e)
        {
            nazadButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.nazad_dugme;
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ugasiMuzikuButton.Text == "Ugasi muziku") 
            {
                this.Hide(); // sakriva ovu formu
                PocetniMeniForm pocetniMeni = new PocetniMeniForm(); // kreira novu formu sa meni igricama
                pocetniMeni.Show(); // pokazuje formu - igriceMeniForma

            }
            else
            {
                this.Hide(); // sakriva ovu formu
                PocetniMeniForm pocetniMeni = new PocetniMeniForm(); // kreira novu formu sa meni igricama
                pocetniMeni.Show(); // pokazuje formu - igriceMeniForma
                sp.Stop();
            }
        }

        bool muzika1 = true;
        bool muzika2 = false;

        private void muzika1Button_Click(object sender, EventArgs e)
        {
            muzika = "Hackathon_Project_GUI.muzika1.wav";
            muzika2button.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_2_off_dugme;
            muzika1Button.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_1_on_dugme;
            muzika2 = false;
            muzika1 = true;
            pustiPesmu();
        }

         private void muzika2button_Click(object sender, EventArgs e)
        {
            muzika = "Hackathon_Project_GUI.muzika2.wav";
            muzika1Button.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_1_off_dugme;
            muzika2button.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.muzika_2_on_dugme;
            muzika1 = false;
            muzika2 = true;
            pustiPesmu();
        }
        
        public static void pustiPesmu() 
        {
            Assembly assembly;
            //Stream soundStream;
            SoundPlayer sp;
            assembly = Assembly.GetExecutingAssembly();
            sp = new SoundPlayer(assembly.GetManifestResourceStream
                (muzika)); // uzima muziku iz resorsa iz adrese
            sp.Play();

            sp.PlayLooping();
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
