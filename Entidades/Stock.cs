using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Stock
    {
        private static List<Album> gunsNRoses = new List<Album>();
        private static List<Album> twice = new List<Album>();
        private static List<Album> ysyA = new List<Album>();
        private static List<Album> metallica = new List<Album>();
        private static List<Album> gorillaz = new List<Album>();
        private static List<Album> nirvana = new List<Album>();
        private static List<Album> theWeekd = new List<Album>();
        private static List<Album> michaelJackson = new List<Album>();
        private static List<Album> instrumentosStock = new List<Album>();
        private static List<Album> badBunny = new List<Album>();
        private static List<Album> cuarteto = new List<Album>();
        private static List<Album> independiente = new List<Album>();
        private static List<Album> cumbiaArgentina = new List<Album>();
        private static List<Instrumento> instrumentoStock = new List<Instrumento>();

        public static List<Album> GunsNRoses { get => gunsNRoses; }
        public static List<Album> TWICE { get => twice; }
        public static List<Album> Ysya { get => ysyA; }
        public static List<Album> Metallica { get => metallica; }
        public static List<Album> Gorillaz { get => gorillaz; }
        public static List<Album> Nirvana { get => nirvana; }
        public static List<Album> TheWeekd { get => theWeekd; }
        public static List<Album> MichaelJackson { get => michaelJackson; }
        public static List<Album> BadBunny { get => badBunny; }
        public static List<Album> Cuarteto { get => cuarteto; }
        public static List<Album> CumbiaArgentina { get => cumbiaArgentina; }
        public static List<Album> Independiente { get => independiente; }
        public static List<Instrumento> InstrumentosStock { get => instrumentoStock; }

        public static Dictionary<string, List<Album>> CargarAlbumesStockDiccionario()
        {
            Dictionary<string, List<Album>> stockAlbums = new Dictionary<string, List<Album>>();
            CargarAlbumes();
            stockAlbums.Add("gorillaz", gorillaz);
            stockAlbums.Add("twice", twice);
            stockAlbums.Add("ysya", ysyA);
            stockAlbums.Add("metallica", metallica);
            stockAlbums.Add("gunsNRoses", gunsNRoses);
            stockAlbums.Add("nirvana", nirvana);
            stockAlbums.Add("theWeeknd", theWeekd);
            stockAlbums.Add("michaelJackson", michaelJackson);
            stockAlbums.Add("badBunny", badBunny);
            stockAlbums.Add("cuarteto", cuarteto);
            stockAlbums.Add("cumbia", cumbiaArgentina);
            stockAlbums.Add("independiente", independiente);

            return stockAlbums;
        }
        public static List<List<Album>> CargarAlbumesStockLista()
        {
            List<List<Album>> stockAlbums = new List<List<Album>>();
            CargarAlbumes();
            stockAlbums.Add(gorillaz);
            stockAlbums.Add(twice);
            stockAlbums.Add(ysyA);
            stockAlbums.Add(metallica);
            stockAlbums.Add(gunsNRoses);
            stockAlbums.Add(nirvana);
            stockAlbums.Add(theWeekd);
            stockAlbums.Add(michaelJackson);
            stockAlbums.Add(badBunny);
            stockAlbums.Add(cuarteto);
            stockAlbums.Add(cumbiaArgentina);
            stockAlbums.Add(independiente);
            return stockAlbums;
        }


        private static void CargarAlbumes()
        {
            GunsNRoses.Add(new Album(4000.00, false, 4, "Guns N' Roses", 2, 1991, "Use your illusion I"));
            GunsNRoses.Add(new Album(4000.00, false, 4, "Guns N' Roses", 2, 1991, "Use your illusion II"));
            GunsNRoses.Add(new Album(4500.00, false, 5, "Guns N' Roses", 2, 1999, "Live Era: '87-'93"));
            GunsNRoses.Add(new Album(3000.00, false, 5, "Guns N' Roses", 2, 2014, "Appetite for Democracy 3D"));
            GunsNRoses.Add(new Album(3000.00, false, 5, "Guns N' Roses", 2, 2008, "Chinese Democracy"));

            TWICE.Add(new Album(2000.00, false, 5, "TWICE", 0, 2022, "Celebrate"));
            TWICE.Add(new Album(2000.00, false, 5, "TWICE", 0, 2023, "Ready to Be"));
            TWICE.Add(new Album(2000.00, false, 5, "TWICE", 0, 2022, "Eyes Wide Open"));

            Ysya.Add(new Album(3500.00, false, 10, "ysy a", 7, 2018, "Antezana"));
            Ysya.Add(new Album(2000.00, false, 10, "ysy a", 7, 2023, "Ysysmo"));

            Metallica.Add(new Album(1500.00, false, 10, "Metallica", 1, 1986, "Ride the Lightning"));
            Metallica.Add(new Album(1500.00, false, 10, "Metallica", 1, 1991, "Master of Puppets"));
            Metallica.Add(new Album(1500.00, false, 10, "Metallica", 1, 1984, "Metallica (Black Album)"));

            Gorillaz.Add(new Album(5000.00, false, 10, "Gorillaz", 5, 2005, "Gorillaz"));
            Gorillaz.Add(new Album(5000.00, false, 10, "Gorillaz", 5, 1984, "Plastic Beach"));

            Nirvana.Add(new Album(5000.00, false, 20, "Nirvana", 3, 1991, "Nervermind"));
            Nirvana.Add(new Album(5000.00, false, 20, "Nirvana", 3, 1989, "Bleach"));
            Nirvana.Add(new Album(6000.00, false, 20, "Nirvana", 3, 1994, "MTV Unplugged in New York"));

            TheWeekd.Add(new Album(5000.00, false, 20, "The Weeknd", 4, 1991, "Starboy"));
            TheWeekd.Add(new Album(5000.00, false, 20, "The Weeknd", 4, 1989, "After Hours"));

            MichaelJackson.Add(new Album(10000.00, false, 20, "Michael Jackson", 4, 1982, "Thriller"));
            MichaelJackson.Add(new Album(10000.00, false, 20, "Michael Jackson", 4, 2001, "Invincible"));
            MichaelJackson.Add(new Album(10000.00, false, 20, "Michael Jackson", 4, 1987, "Bad"));

            CumbiaArgentina.Add(new Album(2000.00, false, 3, "Mario Luis", 10, 1987, "Solo"));
            CumbiaArgentina.Add(new Album(2000.00, false, 3, "Leo Mattioli", 10, 1987, "Lo mejor del Leon"));

            BadBunny.Add(new Album(7000, false, 20, "Bad bunny", 7, 1987, "Un verano sin ti"));
            BadBunny.Add(new Album(7000, false, 20, "Bad bunny", 7, 1987, "El ultimo tour del mundo"));

            Cuarteto.Add(new Album(7000, false, 5, "Rodrigo Bueno", 8, 1999, "A 2000"));
            Cuarteto.Add(new Album(7000, false, 5, "Walter Olmos", 8, 2005, "Megamix"));
            Cuarteto.Add(new Album(7000, false, 5, "Ulises Bueno", 8, 2019, "En la piel"));

            Independiente.Add(new Album(7000, false, 9, "Artic Monkeys", 9, 2013, "AM"));
            Independiente.Add(new Album(7000, false, 9, "Artic Monkeys",9, 2007, "Favourite Worst Nightmare"));
            Independiente.Add(new Album(7000, false, 20, "5 Seconds of summer", 9, 2019, "YOUNGBLOOD"));
        }

        public static List<Instrumento> CargarInstrumentosStock()
        {
            InstrumentosStock.Add(new Instrumento(200000.00, false, 10, 2, "Arpa", 0));
            InstrumentosStock.Add(new Instrumento(250000.00, false, 10, 2, "Contrabajo", 0));
            InstrumentosStock.Add(new Instrumento(200000.00, false, 15, 2, "Violín", 0));
            InstrumentosStock.Add(new Instrumento(200000.00, false, 10, 2, "Bajo", 0));
            InstrumentosStock.Add(new Instrumento(1000000.00, false, 3, 2, "Piano", 0));
            InstrumentosStock.Add(new Instrumento(80000.00, false, 15, 2, "Teclado", 0));
            InstrumentosStock.Add(new Instrumento(100000.00, false, 10, 2, "Guitarra acústica", 0));
            InstrumentosStock.Add(new Instrumento(80000.00, false, 10, 2, "Guitarra eléctrica", 0));
            InstrumentosStock.Add(new Instrumento(200000.00, false, 10, 2, "Guitarra MIDI", 0));

            InstrumentosStock.Add(new Instrumento(50000.00, false, 10, 2, "Saxofón", 1));
            InstrumentosStock.Add(new Instrumento(2000.00, false, 30, 2, "Flauta", 1));
            InstrumentosStock.Add(new Instrumento(80000.00, false, 10, 2, "Tuba", 1));
            InstrumentosStock.Add(new Instrumento(4000.00, false, 20, 2, "Armónica", 1));
            InstrumentosStock.Add(new Instrumento(200000.00, false, 10, 2, "Acordeón", 1));

            InstrumentosStock.Add(new Instrumento(20000.00, false, 10, 2, "Tambór", 2));
            InstrumentosStock.Add(new Instrumento(300000.00, false, 5, 2, "Bateria", 2));
            InstrumentosStock.Add(new Instrumento(250000.00, false, 5, 2, "Bateria Electronica", 2));
            InstrumentosStock.Add(new Instrumento(60000.00, false, 10, 2, "Bombo", 2));

            return InstrumentosStock;
        }

    }

}
