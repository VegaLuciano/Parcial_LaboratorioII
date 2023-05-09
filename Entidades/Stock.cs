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

        public List<Album> GunsNRoses { get => gunsNRoses; }
        public List<Album> TWICE { get => twice; }
        public List<Album> Ysya { get => ysyA; }
        public List<Album> Metallica { get => metallica; }
        public List<Album> Gorillaz { get => gorillaz; }
        public List<Album> Nirvana { get => nirvana; }


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
            this.Ysya.Add(new Album(2000.00, false, 10, "ysya", TipoMusica.Kpop, 2023, "Ysysmo"));

            this.Metallica.Add(new Album(1500.00, false, 10, "Metallica", TipoMusica.HeavyMetal, 1986, "Ride the Lightning"));
            this.Metallica.Add(new Album(1500.00, false, 10, "Metallica", TipoMusica.HeavyMetal, 1991, "Master of Puppets"));
            this.Metallica.Add(new Album(1500.00, false, 10, "Metallica", TipoMusica.HeavyMetal, 1984, "Metallica (Black Album)"));

            this.Gorillaz.Add(new Album(5000.00, false, 10, "Gorillaz", TipoMusica.RockAlternativo, 2005, "Gorillaz"));
            this.Gorillaz.Add(new Album(5000.00, false, 10, "Gorillaz", TipoMusica.RockAlternativo, 1984, "Plastic Beach"));

            this.Nirvana.Add(new Album(5000.00, false, 20, "Nirvana", TipoMusica.Rock, 1991, "Nervermind"));
            this.Nirvana.Add(new Album(5000.00, false, 20, "Nirvana", TipoMusica.Rock, 1989, "Bleach"));
            this.Nirvana.Add(new Album(6000.00, false, 20, "Nirvana", TipoMusica.Rock, 1994, "MTV Unplugged in New York"));

        }
    }

}
