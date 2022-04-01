using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace Hackathon_Project_GUI
{
    public class PristupPodacima
    {
        public List<Osoba> UzmiOsobe(string prezime)
        {
            //throw new NotImplementedException();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("HackathonDB")))
            {
                return connection.Query<Osoba>($"select * from Hackathon where prezime ='{prezime}'").ToList();
            }
        }
    }
}
