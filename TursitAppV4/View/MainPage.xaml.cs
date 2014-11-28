// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

using System.Collections.ObjectModel;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using TursitAppV4.Model;
using TursitAppV4.Viewmodel;

namespace TursitAppV4.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            MainViewModel.SelectedKategori = MainViewModel.RockKategori;
            this.Frame.Navigate(typeof(Kategorier));
        }

        private void Button_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            MainViewModel.SelectedKategori = MainViewModel.PopKategori;
            this.Frame.Navigate(typeof(Kategorier));
        }

        private void Button_Click_2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            MainViewModel.SelectedKategori = MainViewModel.IndieKategori;
            this.Frame.Navigate(typeof(Kategorier));
        }

        private void Button_Click_3(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            MainViewModel.SelectedKategori = MainViewModel.TecnoKategori;
            this.Frame.Navigate(typeof(Kategorier));
        }

        private async void Button_Click_4(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ObservableCollection<Koncert> fileData = await FileHandler.Load();
            if (fileData != null)
            {
                MainViewModel.FavoritKategori.ListeAfKoncerter = fileData;
                if (fileData.Count > 0)
                {
                    MainViewModel.SelectedKategori = MainViewModel.FavoritKategori;
                    this.Frame.Navigate(typeof (Kategorier));
                }
                else
                {
                    MessageDialog myDialog = new MessageDialog("Din favoritliste er tom");
                    myDialog.ShowAsync();
                }
            }
        }
    }
}
