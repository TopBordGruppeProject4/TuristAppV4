using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Newtonsoft.Json;

namespace TursitAppV4.Model
{
    class FileHandler
    {
        private static string FileName = "FavoritSave.dat";

        public static async void Save(ObservableCollection<Koncert> favoritData)
        {
            string playerDataAsJson = JsonConvert.SerializeObject(favoritData);
            SerializeSaveGameAsync(playerDataAsJson, FileName);
        }

        public static async void SerializeSaveGameAsync(string playerDataJsonString, string fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(localFile, playerDataJsonString);
        }

        public static async Task<ObservableCollection<Koncert>> Load()
        {
            string favoritData = await DeserializeSaveGameAsync(FileName);
            if (favoritData != null)
            {
                return (ObservableCollection<Koncert>)JsonConvert.DeserializeObject(favoritData, typeof(ObservableCollection<Koncert>));
            }
            return null;
        }

        private static async Task<string> DeserializeSaveGameAsync(string fileName)
        {
            try
            {
                StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                return await FileIO.ReadTextAsync(localFile);
            }
            catch (FileNotFoundException)
            {
                MessageDialog myDialog = new MessageDialog("Du har ikke tilføjet nogle favoritter.", "Filen blev ikke fundet");
                myDialog.ShowAsync();
                return null;
            }
            catch (UnauthorizedAccessException)
            {
                MessageDialog myDialog = new MessageDialog("Kunne ikke få adgang til filen, beklager", "Manglende adgang");
                myDialog.ShowAsync();
                return null;
            }
            
        }
    }
}
