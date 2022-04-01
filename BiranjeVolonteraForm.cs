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
            tabelaPrikazOsobaDataGriedView.Rows.Add(osobe.Count);


            for (int i = 0; i < osobe.Count; i++) 
            {
                tabelaPrikazOsobaDataGriedView[0, i].Value = osobe[i].id;
                tabelaPrikazOsobaDataGriedView[1, i].Value = osobe[i].ime;
                tabelaPrikazOsobaDataGriedView[2, i].Value = osobe[i].prezime;
                tabelaPrikazOsobaDataGriedView[3, i].Value = osobe[i].brojGodina;
                tabelaPrikazOsobaDataGriedView[4, i].Value = osobe[i].emailAdresa;
            }
            

            //tabelaPrikazOsobaDataGriedView.Columns.Add()
            
            for (int i = 0; i < osobe.Count; i++) ;

        }
    }
}
