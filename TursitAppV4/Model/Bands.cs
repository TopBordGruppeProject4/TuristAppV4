using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TursitAppV4.Model
{
    class Bands
    {
        public string Navn { get; set; }
        public string Beskrivelse { get; set; }

        public Bands(string navn, string beskrivelse)
        {
            Navn = navn;
            Beskrivelse = beskrivelse;
        }

        public override string ToString()
        {
            return string.Format("Navn: {0}, Beskrivelse: {1}", Navn, Beskrivelse);
        }
    }
}
