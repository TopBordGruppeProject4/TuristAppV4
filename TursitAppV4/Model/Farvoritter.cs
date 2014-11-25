using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TursitAppV4.Model
{
    class Farvoritter
    {
        public ObservableCollection<Koncert> FavoritKoncerter { get; set; }

        public Farvoritter(ObservableCollection<Koncert> favoritKoncerter)
        {
            FavoritKoncerter = favoritKoncerter;
        }

        public override string ToString()
        {
            return string.Format("FavoritKoncerter: {0}", FavoritKoncerter);
        }

        public void AddKoncert()
        {
            
        }
    }


}
