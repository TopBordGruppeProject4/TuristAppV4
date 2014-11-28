using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TursitAppV4.Model;
using TursitAppV4.View;
using TursitAppV4.Viewmodel;

namespace TursitAppV4.Viewmodel
{
    class KoncertHandler
    {

        public async void SaveFavoritter(ObservableCollection<Koncert> koncerts)
        {
            FileHandler.Save(koncerts);
        }

        public async void LoadFavoritter()
        {
            var favorites = await FileHandler.Load();
            if (favorites != null)
            {
                MainViewModel.FavoritKategori.ListeAfKoncerter = favorites;
            }
        }
    }
}
