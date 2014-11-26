using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TursitAppV4.Model
{
    class Spillested
    {
        public Spillested(string navn, string hjemmeside, string adresse)
        {
            Navn = navn;
            Hjemmeside = hjemmeside;
            Adresse = adresse;
        }

        public String Navn { get; set; }
        public String Hjemmeside { get; set; }
        public String Adresse { get; set; }

        public override string ToString()
        {
            return string.Format("Navn: {0}, Hjemmeside: {1}, Adresse: {2}", Navn, Hjemmeside, Adresse);
        }
    }
}
