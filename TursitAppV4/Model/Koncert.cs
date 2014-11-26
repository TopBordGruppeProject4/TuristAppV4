using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TursitAppV4.Model
{
    class Koncert
    {
        public Band Band { get; set; }
        public string Tidspunkt { get; set; }
        public string Dato { get; set; }
        public string Spillested { get; set; }

        public Koncert(Band band, string tidspunkt, string dato, string spillested)
        {
            Band = band;
            Tidspunkt = tidspunkt;
            Dato = dato;
            Spillested = spillested;
        }

        public override string ToString()
        {
            return string.Format("Band: {0}, Tidspunkt: {1}, Dato: {2}, Spillested: {3}", Band, Tidspunkt, Dato, Spillested);
        }
    }
}
