using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TursitAppV4.Annotations;

namespace TursitAppV4.Model
{
    public class Kategori: INotifyPropertyChanged
    {
        public string Genre { get; set; }
        public ObservableCollection<Koncert> ListeAfKoncerter { get; set; }
        public string Bagrundsbilled { get; set; }

        public Kategori(string genre, ObservableCollection<Koncert> listeAfKoncerter, string bagrundsbilled)
        {
            Genre = genre;
            ListeAfKoncerter = listeAfKoncerter;
            Bagrundsbilled = bagrundsbilled;
        }

        public override string ToString()
        {
            return string.Format("Genre: {0}, ListeAfKoncerter: {1},Bagrundsbilled{2}", Genre, ListeAfKoncerter, Bagrundsbilled);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
