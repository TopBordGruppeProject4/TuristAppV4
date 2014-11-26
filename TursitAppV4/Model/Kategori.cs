using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TursitAppV4.Model
{
    class Kategori
    {
        public string Genre { get; set; }
        public ObservableCollection<Koncert> ListeAfKoncerter { get; set; }
        public string Bagrundsbilled { get; set; }

        public Kategori(string genre,string bagrundsbilled)
        {
            Genre = genre;
            ListeAfKoncerter = listeAfKoncerter;
            Bagrundsbilled = bagrundsbilled;
        }

        public override string ToString()
        {
            return string.Format("Genre: {0}, ListeAfKoncerter: {1},Bagrundsbilled{2}", Genre, ListeAfKoncerter, Bagrundsbilled);
        }
    }
}
