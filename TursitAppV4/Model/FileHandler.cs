using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml;
using Newtonsoft.Json;

namespace TursitAppV4.Model
{
    class FileHandler
    {
        private static string FileName = "FavoritSave.dat";

        public static async void SaveGameAsJson(ObservableCollection<Koncert> favoritData)
        {
            string playerDataAsJson = JsonConvert.SerializeObject(favoritData);
            SerializeSaveGameAsync(playerDataAsJson, FileName);
        }

        public static async void SerializeSaveGameAsync(string playerDataJsonString, string fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(localFile, playerDataJsonString);
        }

        public static async Task<ObservableCollection<Koncert>> LoadGameFromJson()
        {
            string playerData = await DeserializeSaveGameAsync(FileName);
            return (ObservableCollection<Koncert>) JsonConvert.DeserializeObject(playerData, typeof(ObservableCollection<Koncert>));
        }

        private static async Task<string> DeserializeSaveGameAsync(string fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
            return await FileIO.ReadTextAsync(localFile);
        }
    }
}
