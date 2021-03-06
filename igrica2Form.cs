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
    public partial class igrica2Form : Form
    {
        public igrica2Form()
        {
            InitializeComponent();
            movetostart();
        }

        private void igrica2Form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox20_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Dodirnuli ste zid! Pokušajte ponovo!");
            movetostart();
        }

        private void pictureBox62_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Pobedili ste! Kraj igre!");
            this.Hide();
            igriceMeniForm igricemeni = new igriceMeniForm(); // kreira novu formu sa meni igricama
            igricemeni.Show(); // pokazuje formu - igriceMeniForma
        }

        private void pictureBox60_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Dodirnuli ste zid! Pokušajte ponovo!");
            movetostart();
        }

        private void movetostart()
        {
            Point startingpoint = pictureBox61.Location;
            startingpoint.Offset(10, 15);
            Cursor.Position = PointToScreen(startingpoint);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // sakriva ovu formu
            igriceMeniForm igricemeni = new igriceMeniForm(); // kreira novu formu sa meni igricama
            igricemeni.Show(); // pokazuje formu - igriceMeniForma
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("U igri lavirint cilj je da pomerate kursor od jednog do drugog kvadrata, tako da ne dodirnete ivice lavirinta");
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
        }

        private void nazadButon_Click(object sender, EventArgs e)
        {
            this.Close();
            PocetniMeniForm pocetniMeni = new PocetniMeniForm();
            pocetniMeni.Show();
        }

        private void over(object sender, EventArgs e)
        {
            button1.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.nazad_dugme_oc;
        }

        private void leave(object sender, EventArgs e)
        {
            button1.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.nazad_dugme;
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {

        }

        private void igrica2Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            PocetniMeniForm.turnOffMusic();
        }
    }
}
