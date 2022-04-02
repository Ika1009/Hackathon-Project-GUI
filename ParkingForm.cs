using System;
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
    public partial class ParkingForm : Form
    {
        public ParkingForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("Medijana");
            comboBox1.Items.Add("Palilula");
            comboBox1.Items.Add("Crveni krst");
            comboBox1.Items.Add("Pantelej");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void opstina_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (comboBox1.Text == "Medijana")
            {
                dataGridView1.Rows.Add("9. brigade", "1", "2", "");
                dataGridView1.Rows.Add("Bulevar dr Zorana Đinđića", "1", "VЗ", "ispred kućnog broja 2");
                dataGridView1.Rows.Add("Bulevar dr Zorana Đinđića", "1", "VЗ", "ispred kućnog broja 8");
                dataGridView1.Rows.Add("Bulevar dr Zorana Đinđića", "1", "VЗ", "ispred Simpa");
                dataGridView1.Rows.Add("Bulevar Nemanjića", "1", "E", "Kod pijace „Krive livade“");
                dataGridView1.Rows.Add("Vizantijski bulevar", "3", "VЗ", "");
                dataGridView1.Rows.Add("Vojvode Tankosića", "2", "2", "Dom zdravlja");
                dataGridView1.Rows.Add("Vojvode Tankosića", "1", "2", "Mesna zajednica „Filip Kljajić“");
                dataGridView1.Rows.Add("Garaža “Goran Ostojić”", "4", "P", "Kod Doma zdravlja");
                dataGridView1.Rows.Add("Dositeja Obradovića", "2", "2", "Mesna kancelarija");
                dataGridView1.Rows.Add("Dragiše Cvetković", "1", "VЗ", "");
                dataGridView1.Rows.Add("Jeronimova", "2", "2", "Gimnazija 9. maj");
                dataGridView1.Rows.Add("Jovana Ristića", "1", "2", "Opštinska organizacija civilnih invalida rata");
                dataGridView1.Rows.Add("Jovana Skerlića", "1", "2", "");
                dataGridView1.Rows.Add("Jugovićeva", "1", "2", "kod kućnog broja 24");
                dataGridView1.Rows.Add("Kej kola srpskih sestara", "2", "2", "Vojni dispanzer");
                dataGridView1.Rows.Add("Nade Tomić", "2", "1", "ispred Uslužnog centra kod br.13");
                dataGridView1.Rows.Add("Nikole Pašića", "3", "E", "TC Kalča");
                dataGridView1.Rows.Add("Nikole Pašića", "4", "E", "Skupština Grada");
                dataGridView1.Rows.Add("Obilićev Venac - plato", "1", "1", "ispred Telekoma");
                dataGridView1.Rows.Add("Orlovića Pavla", "2", "1", "Glavna pošta");
                dataGridView1.Rows.Add("Pariske Komune", "2", "2", "GO Medijana");
                dataGridView1.Rows.Add("Parkiralište Sinđelićev Trg", "6", "P", "");
                dataGridView1.Rows.Add("Parkiralište Čair", "3", "P", "Kod istočne tribine stadiona Čair");
                dataGridView1.Rows.Add("Plato u 9. Brigade", "3", "2", "Parking pored hale Čair");
                dataGridView1.Rows.Add("Prvomajska", "1", "2", "kod škole");
                dataGridView1.Rows.Add("Prijezdina", "3", "2", "Saborna Crkva");
                dataGridView1.Rows.Add("Rajićeva", "2", "2", "");
                dataGridView1.Rows.Add("Svetozara Markovića", "2", "1", "Međuopštinska organizacija saveza slepih");
                dataGridView1.Rows.Add("Sinđelićev Trg (kod Dečje bibl.)", "2", "2", "Sportski savez invalida");
                dataGridView1.Rows.Add("Stojana Novakovića", "2", "2", "");
                dataGridView1.Rows.Add("Strahinjića Bana", "1", "1", "ispred kućnog broja 02");
                dataGridView1.Rows.Add("Trg 14. oktobra", "2", "2", "Pošta");
                dataGridView1.Rows.Add("Trg Kralja Aleksandra", "3", "2", "Pravni i Ekonomski fakultet");
                dataGridView1.Rows.Add("Ćirila i Metodija", "3", "2", "Filozofski fakultet");
                dataGridView1.Rows.Add("Hajduk Veljkova", "3", "2", "Gradska organizacija invalida rada");
                dataGridView1.Rows.Add("Cara Dušana", "2", "1", "Republički font za zdravstveno osiguranje");
                dataGridView1.Rows.Add("Cara Dušana", "1", "2", "na raskrsnici sa Prvomajskom");        
            }

            else if (comboBox1.Text == "Palilula")
            {
                dataGridView1.Rows.Add("Božidarčeva", "1", "VЗ", "ispred kućnog broja 24");
                dataGridView1.Rows.Add("Marina Držića", "1", "VЗ", "Zdravstvena stanica Delijski vis");
            }

            else if (comboBox1.Text == "Crveni krst")
            {
                dataGridView1.Rows.Add("Đuke Dinić", "4", "E", "Pijaca „Tvrđava“");
                dataGridView1.Rows.Add("Jelene Dimitrijević", "1", "2", "preko puta ambulante");
                dataGridView1.Rows.Add("Kej Mike Paligorića", "2", "2", "Zgrada Univerziteta");
                dataGridView1.Rows.Add("Parkiralište Rovče", "4", "2", "");
            }

            else 
            {
                dataGridView1.Rows.Add("Knjaževačka", "4", "VЗ", "Gradsko Udruženje cerebralne i dečije paralize Niš");
                dataGridView1.Rows.Add("Srbinjska", "4", "BЗ", "kod Durlanske pijace");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nazadButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MapaForm mapaForm = new MapaForm();
            mapaForm.Show();

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MapaForm nazad = new MapaForm();
            nazad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PocetniMeniForm meni = new PocetniMeniForm();
            meni.Show();

        }
    }
}
