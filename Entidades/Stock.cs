using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Stock
    {
        private List<Album> gunsNRoses = new List<Album>();
        private List<Album> twice = new List<Album>();
        private List<Album> ysyA = new List<Album>();
        private List<Album> metallica = new List<Album>();
        private List<Album> gorillaz = new List<Album>();
        private List<Album> nirvana = new List<Album>();
        private List<Album> theWeekd = new List<Album>();
        private List<Album> michaelJackson = new List<Album>();
        private List<Album> instrumentosStock = new List<Album>();
        private List<Album> badBunny = new List<Album>();
        private List<Album> cuarteto = new List<Album>();
        private List<Album> independiente = new List<Album>();
        private List<Album> cumbiaArgentina = new List<Album>();
        private List<Instrumento> instrumentoStock = new List<Instrumento>();

        public List<Album> GunsNRoses { get => gunsNRoses; }
        public List<Album> TWICE { get => twice; }
        public List<Album> Ysya { get => ysyA; }
        public List<Album> Metallica { get => metallica; }
        public List<Album> Gorillaz { get => gorillaz; }
        public List<Album> Nirvana { get => nirvana; }
        public List<Album> TheWeekd { get => theWeekd; }
        public List<Album> MichaelJackson { get => michaelJackson; }
        public List<Album> BadBunny { get => badBunny; }
        public List<Album> Cuarteto { get => cuarteto; }
        public List<Album> CumbiaArgentina { get => cumbiaArgentina; }
        public List<Album> Independiente { get => independiente; }
        public List<Instrumento> InstrumentosStock { get => instrumentoStock; }


        public void CargarAlbumesStock()
        {
            Dictionary<string, List<Album>> stockAlbums = new Dictionary<string, List<Album>>();
            CargarAlbumes();
            stockAlbums.Add("horillaz", this.gorillaz);
            stockAlbums.Add("twice", this.twice);
            stockAlbums.Add("ysya", this.ysyA);
            stockAlbums.Add("metallica", this.metallica);
            stockAlbums.Add("gunsNRoses", this.gunsNRoses);
            stockAlbums.Add("nirvana", this.nirvana);
            stockAlbums.Add("theWeeknd", this.theWeekd);
            stockAlbums.Add("michaelJackson", this.michaelJackson);
            stockAlbums.Add("badBunny", this.badBunny);
            stockAlbums.Add("cuarteto", this.cuarteto);
            stockAlbums.Add("independiente", this.independiente);
        }

        public void CargarAlbumes()
        {
            this.GunsNRoses.Add(new Album(4000.00, false, 4, "Guns N' Roses", TipoMusica.HardRock, 1991, "Use your illusion I"));
            this.GunsNRoses.Add(new Album(4000.00, false, 4, "Guns N' Roses", TipoMusica.HardRock, 1991, "Use your illusion II"));
            this.GunsNRoses.Add(new Album(4500.00, false, 5, "Guns N' Roses", TipoMusica.HardRock, 1999, "Live Era: '87-'93"));
            this.GunsNRoses.Add(new Album(3000.00, false, 5, "Guns N' Roses", TipoMusica.HardRock, 2014, "Appetite for Democracy 3D"));
            this.GunsNRoses.Add(new Album(3000.00, false, 5, "Guns N' Roses", TipoMusica.HardRock, 2008, "Chinese Democracy"));

            this.TWICE.Add(new Album(2000.00, false, 5, "TWICE", TipoMusica.Kpop, 2017, "Chinese Democracy"));
            this.TWICE.Add(new Album(2000.00, false, 5, "TWICE", TipoMusica.Kpop, 2023, "Ready to Be"));
            this.TWICE.Add(new Album(2000.00, false, 5, "TWICE", TipoMusica.Kpop, 2023, "Ready to Be"));

            this.Ysya.Add(new Album(3500.00, false, 10, "ysy a", TipoMusica.Trap, 2018, "Antezana"));
            this.Ysya.Add(new Album(2000.00, false, 10, "ysy a", TipoMusica.Trap, 2023, "Ysysmo"));

            this.Metallica.Add(new Album(1500.00, false, 10, "Metallica", TipoMusica.HeavyMetal, 1986, "Ride the Lightning"));
            this.Metallica.Add(new Album(1500.00, false, 10, "Metallica", TipoMusica.HeavyMetal, 1991, "Master of Puppets"));
            this.Metallica.Add(new Album(1500.00, false, 10, "Metallica", TipoMusica.HeavyMetal, 1984, "Metallica (Black Album)"));

            this.Gorillaz.Add(new Album(5000.00, false, 10, "Gorillaz", TipoMusica.RockAlternativo, 2005, "Gorillaz"));
            this.Gorillaz.Add(new Album(5000.00, false, 10, "Gorillaz", TipoMusica.RockAlternativo, 1984, "Plastic Beach"));

            this.Nirvana.Add(new Album(5000.00, false, 20, "Nirvana", TipoMusica.Rock, 1991, "Nervermind"));
            this.Nirvana.Add(new Album(5000.00, false, 20, "Nirvana", TipoMusica.Rock, 1989, "Bleach"));
            this.Nirvana.Add(new Album(6000.00, false, 20, "Nirvana", TipoMusica.Rock, 1994, "MTV Unplugged in New York"));

            this.TheWeekd.Add(new Album(5000.00, false, 20, "The Weeknd", TipoMusica.Pop, 1991, "Starboy"));
            this.TheWeekd.Add(new Album(5000.00, false, 20, "The Weeknd", TipoMusica.Pop, 1989, "After Hours"));

            this.MichaelJackson.Add(new Album(10000.00, false, 20, "Michael Jackson", TipoMusica.Pop, 1982, "Thriller"));
            this.MichaelJackson.Add(new Album(10000.00, false, 20, "Michael Jackson", TipoMusica.Pop, 2001, "Invincible"));
            this.MichaelJackson.Add(new Album(10000.00, false, 20, "Michael Jackson", TipoMusica.Pop, 1987, "Bad"));

            this.CumbiaArgentina.Add(new Album(2000.00, false, 3, "Mario Luis", TipoMusica.Cumbia, 1987, "Solo"));
            this.CumbiaArgentina.Add(new Album(2000.00, false, 3, "Leo Mattioli", TipoMusica.Cumbia, 1987, "Lo mejor del Leon"));

            this.BadBunny.Add(new Album(7000, false, 20, "Bad bunny", TipoMusica.Trap, 1987, "Un verano sin ti"));
            this.BadBunny.Add(new Album(7000, false, 20, "Bad bunny", TipoMusica.Trap, 1987, "El ultimo tour del mundo"));

            this.Cuarteto.Add(new Album(7000, false, 5, "Rodrigo Bueno", TipoMusica.Cuarteto, 1999, "A 2000"));
            this.Cuarteto.Add(new Album(7000, false, 5, "Walter Olmos", TipoMusica.Cuarteto, 2005, "Megamix"));
            this.Cuarteto.Add(new Album(7000, false, 5, "Ulises Bueno", TipoMusica.Cuarteto, 2019, "En la piel"));

            this.Independiente.Add(new Album(7000, false, 9, "Artic Monkeys", TipoMusica.Independiente, 2013, "AM"));
            this.Independiente.Add(new Album(7000, false, 9, "Artic Monkeys", TipoMusica.Independiente, 2007, "Favourite Worst Nightmare"));
            this.Independiente.Add(new Album(7000, false, 20, "5 Seconds of summer", TipoMusica.Independiente, 2019, "YOUNGBLOOD"));
        }

        public void CargarInstrumentosStock()
        {
            InstrumentosStock.Add(new Instrumento(200000.00, false, 10, 2, "Arpa", TipoInstrumento.Cuerda));
            InstrumentosStock.Add(new Instrumento(250000.00, false, 10, 2, "Contrabajo", TipoInstrumento.Cuerda));
            InstrumentosStock.Add(new Instrumento(200000.00, false, 15, 2, "Violín", TipoInstrumento.Cuerda));
            InstrumentosStock.Add(new Instrumento(200000.00, false, 10, 2, "Bajo", TipoInstrumento.Cuerda));
            InstrumentosStock.Add(new Instrumento(1000000.00, false, 3, 2, "Piano", TipoInstrumento.Cuerda));
            InstrumentosStock.Add(new Instrumento(80000.00, false, 15, 2, "Teclado", TipoInstrumento.Cuerda));
            InstrumentosStock.Add(new Instrumento(100000.00, false, 10, 2, "Guitarra acústica", TipoInstrumento.Cuerda));
            InstrumentosStock.Add(new Instrumento(80000.00, false, 10, 2, "Guitarra eléctrica", TipoInstrumento.Cuerda));
            InstrumentosStock.Add(new Instrumento(200000.00, false, 10, 2, "Guitarra MIDI", TipoInstrumento.Cuerda));

            InstrumentosStock.Add(new Instrumento(50000.00, false, 10, 2, "Saxofón", TipoInstrumento.Viento));
            InstrumentosStock.Add(new Instrumento(2000.00, false, 30, 2, "Flauta", TipoInstrumento.Viento));
            InstrumentosStock.Add(new Instrumento(80000.00, false, 10, 2, "Tuba", TipoInstrumento.Viento));
            InstrumentosStock.Add(new Instrumento(4000.00, false, 20, 2, "Armónica", TipoInstrumento.Viento));
            InstrumentosStock.Add(new Instrumento(200000.00, false, 10, 2, "Acordeón", TipoInstrumento.Viento));

            InstrumentosStock.Add(new Instrumento(20000.00, false, 10, 2, "Tambór", TipoInstrumento.Percusión));
            InstrumentosStock.Add(new Instrumento(300000.00, false, 5, 2, "Bateria", TipoInstrumento.Percusión));
            InstrumentosStock.Add(new Instrumento(250000.00, false, 5, 2, "Bateria Electronica", TipoInstrumento.Percusión));
            InstrumentosStock.Add(new Instrumento(60000.00, false, 10, 2, "Bombo", TipoInstrumento.Percusión));

        }
    }
}
