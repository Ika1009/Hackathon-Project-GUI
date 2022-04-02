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
//using System.Net;

namespace Hackathon_Project_GUI
{
    public partial class DodavanjeVolonteraForm : Form
    {

        SqlConnection conn = new SqlConnection("Server =.\\SQLEXPRESS; Database=Hackathon_Database;Trusted_Connection=True;");

        public DodavanjeVolonteraForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into Hackathon (ime ,prezime, brojGodina, pol, brojTelefona, grad, opstina )values('" + imeTextBox.Text + 
                    "','" + prezimeTextBox.Text + 
                    "','" + godineTextBox.Text + 
                    "','" + polTextBox.Text + 
                    "','" + brojTelefonaTextBox.Text + 
                    "','" + gradtextBox.Text + 
                    "','" + opstinaTextBox.Text +"')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hvala puno za volontiranje!");
                imeTextBox.Clear();
                prezimeTextBox.Clear();
                godineTextBox.Clear();
                brojTelefonaTextBox.Clear();
                gradtextBox.Clear();
                polTextBox.Clear();
                opstinaTextBox.Clear();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
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
    }
}
