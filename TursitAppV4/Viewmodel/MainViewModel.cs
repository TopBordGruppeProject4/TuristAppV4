using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TursitAppV4.Model;

namespace TursitAppV4.Viewmodel
{
    class MainViewModel
    {
        
        Kategori RocKategori = new Kategori("Rock","placeholder");
        Koncert DADkKoncert = new Koncert("DAD", "kl.20:00", "d.2-2-2020", "Gimle");
        Koncert MagtensKorridorkKoncert = new Koncert("MagtensKorridor","kl:19:00","d.2-02-2020","Paramount");
        
        Kategori PopKategori = new Kategori("Pop","placeholder");
        Koncert MedinakKoncert = new Koncert("Medina","kl.15:00","D.30-4-2015","Roskilde Kongresscenter");
        Koncert RasmusSeebachkKoncert = new Koncert("Rasmus Seebach","kl.13:00","D.10-07-2015","Roskilde Kongresscenter");
        
        Kategori TecnoKategori = new Kategori("Tecno","placeholder");
        Koncert DjTiëstoKoncert = new Koncert("DjTiësto", "kl.21:30", "d.3-6-2015", "Gimle");
        Koncert DeadMousekKoncert = new Koncert("DeadMouse","kl.19:00","d.4-5-2016","Roskilde Kongresscenter");


        Kategori IndieKategori = new Kategori("Indie","placeholder");
        Koncert FonDüKoncert = new Koncert("Fon dü", "kl.21:00","d.14-11-2015","Gimle");
        Koncert RedwarszawakKoncert = new Koncert("Red warszawa","kl.21:00","d.4-8-2015", "Paramount");

        public MainViewModel()
        {
            RocKategori.ListeAfKoncerter.Add(DADkKoncert);
            RocKategori.ListeAfKoncerter.Add(MagtensKorridorkKoncert);
            
            PopKategori.ListeAfKoncerter.Add(MedinakKoncert);
            PopKategori.ListeAfKoncerter.Add(RasmusSeebachkKoncert);

            TecnoKategori.ListeAfKoncerter.Add(DjTiëstoKoncert);
            TecnoKategori.ListeAfKoncerter.Add(DeadMousekKoncert);

            IndieKategori.ListeAfKoncerter.Add(FonDüKoncert);
            IndieKategori.ListeAfKoncerter.Add(RedwarszawakKoncert);
        }
    }
}
