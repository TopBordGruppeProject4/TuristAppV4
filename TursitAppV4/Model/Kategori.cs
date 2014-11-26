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
        public String Genre { get; set; }
        public ObservableCollection<Koncert> ListeAfKoncerter { get; set; }

        public Kategori(string genre, ObservableCollection<Koncert> listeAfKoncerter)
        {
            Genre = genre;
            ListeAfKoncerter = listeAfKoncerter;
        }

        public override string ToString()
        {
            return string.Format("Genre: {0}, ListeAfKoncerter: {1}", Genre, ListeAfKoncerter);
        }
    }
}
