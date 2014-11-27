using System;
using System.Collections.Generic;
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
        private static string FileName = "GameSave.dat";

        public static async void SaveGameAsJson(Farvoritter favoritData)
        {
            string playerDataAsJson = JsonConvert.SerializeObject(favoritData);
            SerializeSaveGameAsync(playerDataAsJson, FileName);
        }

        public static async void SerializeSaveGameAsync(string playerDataJsonString, string fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(localFile, playerDataJsonString);
        }

        public static async Task<Farvoritter> LoadGameFromJson()
        {
            string playerData = await DeserializeSaveGameAsync(FileName);
            return (Farvoritter) JsonConvert.DeserializeObject(playerData, typeof(Farvoritter));
        }

        private static async Task<string> DeserializeSaveGameAsync(string fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
            return await FileIO.ReadTextAsync(localFile);
        }
    }
}
