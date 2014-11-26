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
        static Band DAD = new Band("DAD","Placeholder");
        static Band MagtensKorridor = new Band("Magtens Korridor","Placeholder");
        static Band Medina = new Band("Medina","Placeholder");
        static Band RasmusSeebach = new Band("Rasmus Seebach","placeholder");
        static Band DjTiësto = new Band("DJTiësto","placeholder");
        static Band DeadMouse = new Band("DeadMouse","placeholder");
        static Band FonDü = new Band("Fon Dü","placeholder");
        static Band Redwarszawa = new Band("Red warszawa","placeholder");
        
        Kategori RockKategori = new Kategori("Rock","placeholder");
        Koncert DADkKoncert = new Koncert(DAD, "kl.20:00", "d.2-2-2020", "Gimle");
        Koncert MagtensKorridorkKoncert = new Koncert(MagtensKorridor,"kl:19:00","d.2-02-2020","Paramount");
        
        Kategori PopKategori = new Kategori("Pop","placeholder");
        Koncert MedinakKoncert = new Koncert(Medina,"kl.15:00","D.30-4-2015","Roskilde Kongresscenter");
        Koncert RasmusSeebachkKoncert = new Koncert(RasmusSeebach,"kl.13:00","D.10-07-2015","Roskilde Kongresscenter");
        
        Kategori TecnoKategori = new Kategori("Tecno","placeholder");
        Koncert DjTiëstoKoncert = new Koncert(DjTiësto, "kl.21:30", "d.3-6-2015", "Gimle");
        Koncert DeadMousekKoncert = new Koncert(DeadMouse,"kl.19:00","d.4-5-2016","Roskilde Kongresscenter");


        Kategori IndieKategori = new Kategori("Indie","placeholder");
        Koncert FonDüKoncert = new Koncert(FonDü, "kl.21:00","d.14-11-2015","Gimle");
        Koncert RedwarszawakKoncert = new Koncert(Redwarszawa,"kl.21:00","d.4-8-2015", "Paramount");

        public MainViewModel()
        {
            RockKategori.ListeAfKoncerter.Add(DADkKoncert);
            RockKategori.ListeAfKoncerter.Add(MagtensKorridorkKoncert);
            
            PopKategori.ListeAfKoncerter.Add(MedinakKoncert);
            PopKategori.ListeAfKoncerter.Add(RasmusSeebachkKoncert);

            TecnoKategori.ListeAfKoncerter.Add(DjTiëstoKoncert);
            TecnoKategori.ListeAfKoncerter.Add(DeadMousekKoncert);

            IndieKategori.ListeAfKoncerter.Add(FonDüKoncert);
            IndieKategori.ListeAfKoncerter.Add(RedwarszawakKoncert);
        }
    }
}
