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
    public partial class BiranjeVolonteraForm : Form
    {
        List<Osoba> osobe = new List<Osoba>();
        public BiranjeVolonteraForm()
        {
            InitializeComponent();

        }

        private void nadjiVolonteraButton_Click(object sender, EventArgs e)
        {
            PristupPodacima db = new PristupPodacima();

            osobe=db.UzmiOsobe();

            volonteriIzBazePodatakaListBox.DataSource = osobe;
            volonteriIzBazePodatakaListBox.DisplayMember = "ceoInfo";

            //tabelaPrikazOsobaDataGriedView.Columns.Add()
            
            for (int i = 0; i < osobe.Count; i++) ;

        }
    }
}
