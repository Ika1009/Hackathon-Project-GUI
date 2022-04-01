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
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)/MSSQLLocalDB;AttachDbFilename=C:/Users/milos/Source/Repos/Hackathon-Project-GUI/Database1.mdf;Integrated Security=True");
        public DodavanjeVolonteraForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Volonteri (id,Ime,Prezime)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("jebite se svi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
    }
}
