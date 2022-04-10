using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Media;
using System.Reflection;
//using System.Net;

namespace Hackathon_Project_GUI
{
    public partial class DodavanjeVolonteraForm : Form
    {

        public DodavanjeVolonteraForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText(@"dataFajl.txt");
            try
            {
                sw.WriteLine(imeTextBox.Text + 
                    "," + prezimeTextBox.Text + 
                    "," + godineTextBox.Text + 
                    "," + polTextBox.Text +
                    "," + brojTelefonaTextBox.Text + 
                    "," + gradtextBox.Text + 
                    "," + opstinaTextBox.Text);
                MessageBox.Show("Hvala puno za volontiranje!");

                //System.Media.SoundPlayer sp = new System.Media.SoundPlayer();


                Assembly assembly;
                //Stream soundStream;
                SoundPlayer sp;
                assembly = Assembly.GetExecutingAssembly();
                sp = new SoundPlayer(assembly.GetManifestResourceStream
                    ("Hackathon_Project_GUI.CROWD-CHEER-SOUND-EFFECT_MP3_70K_.wav")); // uzima muziku iz resorsa iz adrese
                sp.Play();
                
                //settingsForm.pustiPesmu()a;

                imeTextBox.Clear();

                prezimeTextBox.Clear();
                godineTextBox.Clear();
                brojTelefonaTextBox.Clear();
                gradtextBox.Clear();
                polTextBox.Clear();
                opstinaTextBox.Clear();
                sw.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nazadButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PocetniMeniForm pocetniMeniForma = new PocetniMeniForm();
            pocetniMeniForma.Show();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void over(object sender, EventArgs e)
        {
            nazadButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.nazad_dugme_oc;
        }

        private void leave(object sender, EventArgs e)
        {
            nazadButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.nazad_dugme;
        }
        public void turning_off_music_when_form_closes() //kad se gasi forma
        {
            SoundPlayer sp = new SoundPlayer();
            sp.Stop();
        }

        private void DodavanjeVolonteraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            turning_off_music_when_form_closes();
        }
    }
}
