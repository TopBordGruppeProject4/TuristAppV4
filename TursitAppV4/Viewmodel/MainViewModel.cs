﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TursitAppV4.Model;

namespace TursitAppV4.Viewmodel
{
    class MainViewModel
    {
        public Kategori SelectedKategori { get; set; }

        static Spillested Paramount = new Spillested("Paramount","Placehonder","eriksvej 40 , 4000 Roskilde");
        static Spillested Gimle = new Spillested("Gimle","Placeholder","Helligkorsvej 2, 4000 Roskilde");
        static Spillested RoskildeKongresscenter = new Spillested("Roskilde Kongresscenter", "placeholder","Møllehusvej 15, 4000 Roskilde");
        
        static Band DAD = new Band("DAD","Placeholder");
        static Band MagtensKorridor = new Band("Magtens Korridor","Placeholder");
        static Band Medina = new Band("Medina","Placeholder");
        static Band RasmusSeebach = new Band("Rasmus Seebach","placeholder");
        static Band DjTiësto = new Band("DJTiësto","placeholder");
        static Band DeadMau5 = new Band("DeadMau5","placeholder");
        static Band VonDü = new Band("Von Dü","placeholder");
        static Band Redwarszawa = new Band("Red warszawa","placeholder");

        Kategori RockKategori = new Kategori("Rock", "placeholder");
        Koncert DADkKoncert = new Koncert(DAD, "kl.20:00", "d.2-2-2020", Gimle);
        Koncert MagtensKorridorkKoncert = new Koncert(MagtensKorridor,"kl:19:00","d.2-02-2020",Paramount);
        
        Kategori PopKategori = new Kategori("Pop","placeholder");
        Koncert MedinakKoncert = new Koncert(Medina,"kl.15:00","D.30-4-2015",RoskildeKongresscenter);
        Koncert RasmusSeebachkKoncert = new Koncert(RasmusSeebach,"kl.13:00","D.10-07-2015",RoskildeKongresscenter);
        
        Kategori TecnoKategori = new Kategori("Tecno","placeholder");
        Koncert DjTiëstoKoncert = new Koncert(DjTiësto, "kl.21:30", "d.3-6-2015", Gimle);
        Koncert DeadMau5kKoncert = new Koncert(DeadMau5,"kl.19:00","d.4-5-2016",RoskildeKongresscenter);


        Kategori IndieKategori = new Kategori("Indie","placeholder");
        Koncert VonDüKoncert = new Koncert(VonDü, "kl.21:00","d.14-11-2015",Gimle);
        Koncert RedwarszawakKoncert = new Koncert(Redwarszawa,"kl.21:00","d.4-8-2015", Paramount);

        public MainViewModel()
        {
            RockKategori.ListeAfKoncerter.Add(DADkKoncert);
            RockKategori.ListeAfKoncerter.Add(MagtensKorridorkKoncert);
            
            PopKategori.ListeAfKoncerter.Add(MedinakKoncert);
            PopKategori.ListeAfKoncerter.Add(RasmusSeebachkKoncert);

            TecnoKategori.ListeAfKoncerter.Add(DjTiëstoKoncert);
            TecnoKategori.ListeAfKoncerter.Add(DeadMau5kKoncert);

            IndieKategori.ListeAfKoncerter.Add(VonDüKoncert);
            IndieKategori.ListeAfKoncerter.Add(RedwarszawakKoncert);
        }
    }
}
