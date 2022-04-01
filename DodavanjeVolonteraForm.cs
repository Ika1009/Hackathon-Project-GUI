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
                SqlCommand cmd = new SqlCommand("insert into Hackathon (ime,prezime, godine)values('" + imeTextBox.Text + "','" + prezimeTextBox.Text + "','" + godineTextBox.Text + "','" + brojTelefonaTextBox.Text + "','" + emailAdresaTextBox + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hvala puno za volontiranje!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
    }
}
