using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TursitAppV4.Model;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
namespace TursitAppV4.Model.Tests
{
    [TestClass()]
    public class FileHandlerTests
    {
       static Band band = new Band("band","band");
        private static Spillested spillested = new Spillested("spillested","placeholder","placeholder");
        static Koncert koncert = new Koncert(band,"00;00","0-0-0",spillested);
        Kategori kategori1 = new Kategori("genre", new ObservableCollection<Koncert>(),"placeholder" );
        
        
        [TestMethod()]
        public async  void SaveTestAndLoadSuccess()
        {
           kategori1.ListeAfKoncerter.Add(koncert);
           FileHandler.Save(kategori1.ListeAfKoncerter);

           var filedata = await FileHandler.Load();

            if (filedata != null)
            {
                return;
            }

            Assert.Fail();
        }


        [TestMethod()]
        public async void LoadTestFail()
        {
            
            var fileData = await FileHandler.Load();
            if (fileData == null)
            {
                return;
            }

            Assert.Fail();
        }
    }
}
