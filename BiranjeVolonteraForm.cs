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

namespace Hackathon_Project_GUI
{
    public partial class BiranjeVolonteraForm : Form
    {
        List<Osoba> osobe = new List<Osoba>();
        public BiranjeVolonteraForm()
        {
            InitializeComponent();

            //StreamReader sr = new StreamReader(@"dataFajl.txt");
            try
            {

                using (StreamReader sr = new StreamReader(@"dataFajl.txt"))
                {
                    string linija;
                    while ((linija = sr.ReadLine()) != null)
                    {
                        string[] reci = linija.Split(",");
                        Osoba novaOsoba = new Osoba(reci[0], reci[1], reci[2], reci[3], reci[4], reci[5], reci[6]);
                        osobe.Add(novaOsoba);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


tabelaPrikazOsobaDataGriedView.Rows.Add(osobe.Count);


            for (int i = 0; i < osobe.Count; i++)
            {
                tabelaPrikazOsobaDataGriedView[0, i].Value = i+1;
                tabelaPrikazOsobaDataGriedView[1, i].Value = osobe[i].ime;
                tabelaPrikazOsobaDataGriedView[2, i].Value = osobe[i].prezime;
                tabelaPrikazOsobaDataGriedView[3, i].Value = osobe[i].pol;
                tabelaPrikazOsobaDataGriedView[4, i].Value = osobe[i].brojGodina;
                tabelaPrikazOsobaDataGriedView[5, i].Value = osobe[i].brojTelefona;
                tabelaPrikazOsobaDataGriedView[6, i].Value = osobe[i].grad;
                tabelaPrikazOsobaDataGriedView[7, i].Value = osobe[i].opstina;

            }
            //tabelaPrikazOsobaDataGriedView.Columns.Add()
        }

        private void nadjiVolonteraButton_Click(object sender, EventArgs e)
        {
            

        }

        private void nazadButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PocetniMeniForm pocetniMeniForma = new PocetniMeniForm();
            pocetniMeniForma.Show();
        }

        private void over(object sender, EventArgs e)
        {
            nazadButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.nazad_dugme_oc;
        }

        private void leave(object sender, EventArgs e)
        {
            nazadButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.nazad_dugme;
        }

        private void tabelaPrikazOsobaDataGriedView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BiranjeVolonteraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PocetniMeniForm.turnOffMusic();
        }
    }
}
