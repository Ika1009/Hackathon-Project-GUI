using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_Project_GUI
{
    public class Osoba
    {
        public Osoba(string ime1,
                     string prezime1,
                     string pol1,
                     string brojGodina1,
                     string brojTelefona1,
                     string opstina1,
                     string grad1)
        {
            ime = ime1;
            prezime = prezime1;
            pol = pol1;
            brojGodina = brojGodina1;
            brojTelefona = brojTelefona1;
            opstina = opstina1;
            grad = grad1;
        }
        public string id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string pol { get; set; }
        public string brojGodina { get; set; }
        public string brojTelefona { get; set; }
        public string opstina { get; set; }
        public string grad { get; set; }
    }
}
