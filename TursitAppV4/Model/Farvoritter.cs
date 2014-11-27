using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TursitAppV4.Model
{
    public class Farvoritter
    {

        public ObservableCollection<Koncert> Favoritkoncerter { get; set; }
        public Koncert SelectedKoncert { get; set; }
        public Farvoritter()
        {
            Favoritkoncerter = new ObservableCollection<Koncert>();
        }
        public void AddKoncert()
        {
          Favoritkoncerter.Add(SelectedKoncert);
        }
    }


}
