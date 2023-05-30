using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Album : Producto
    {
        private string autor;
        private string nombreDelAlbum;
        private TipoMusica tipoMusica;
        private int añoDeSalida;

        public Album(double precio, bool estaEnOferta, int stock, string autor, int tipoMusica, int añoDeSalida, string nombreDelAlbum) : base(precio, estaEnOferta, stock)
        {
            seleccionarTipoMusica(tipoMusica);
            this.autor = autor;
            this.añoDeSalida = añoDeSalida;
            this.nombreDelAlbum = nombreDelAlbum;
        }

        public Album(double precio, bool estaEnOferta, int stock, string autor, int tipoMusica, int añoDeSalida, string nombreDelAlbum, DateTime fechaDeVenta, Cliente comprador ) : this(precio, estaEnOferta, stock, autor, tipoMusica, añoDeSalida, nombreDelAlbum)
        {
            this.fechaDeVenta = fechaDeVenta;
            this.comprador = comprador;
        }

        public double Precio { get => precio; set => precio = value; }
        public bool EstaEnOferta { get => estaEnOferta; set => estaEnOferta = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Autor { get => autor; set => autor = value; }
        public string NombreDelAlbum { get => nombreDelAlbum; set => nombreDelAlbum = value; }
        public int AñoDeSalida { get => añoDeSalida; set => añoDeSalida = value; }
        public TipoMusica TipoMusica { get => tipoMusica; set => tipoMusica = value; }
        public DateTime FechaDeVenta { get => fechaDeVenta; set => fechaDeVenta = value; }
        public Cliente Comprador { get => comprador; set => comprador = value; }


        public override bool PreguntarOferta()
        {
            bool retorno = false;

            if (this.stock >= 20) 
            {
                this.estaEnOferta = true;
                retorno = true;
            }

            return retorno;
        }

        public override bool ReclamarGarantia()
        {
            bool retorno = false;
            DateTime diaDeDevolucion = DateTime.Now;

            if ((this.FechaDeVenta.Year + 1) < diaDeDevolucion.Year)
            {
                retorno = true;
            }
            return retorno;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Autor: {this.autor}");
            sb.AppendLine($"Nombre del albúm: {this.nombreDelAlbum}");
            sb.AppendLine($"Tipo: {this.tipoMusica}");
            sb.AppendLine($"Año de slaida {this.añoDeSalida}");
            sb.AppendLine(base.Mostrar());

            return sb.ToString();
        }

        public string MostrarVenta()
        {
            string retorno = "";
            if (!(this.Comprador == null))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(this.Mostrar());
                sb.AppendLine(this.Comprador.ToString());
                sb.AppendLine(this.fechaDeVenta.ToLongDateString());
            }

            return retorno;
        }

        private void seleccionarTipoMusica(int tipo) 
        {
            switch (tipo) 
            {
                case 0:
                    this.tipoMusica = TipoMusica.Kpop;
                    break;
                case 1:
                    this.tipoMusica = TipoMusica.HeavyMetal;
                    break;
                case 2:
                    this.tipoMusica = TipoMusica.HardRock;
                    break;
                case 3:
                    this.tipoMusica = TipoMusica.Rock;
                    break;
                case 4:
                    this.tipoMusica = TipoMusica.Pop;
                    break;
                case 5:
                    this.tipoMusica = TipoMusica.RockAlternativo;
                    break;
                case 6:
                    this.tipoMusica = TipoMusica.Regueton;
                    break;
                case 7:
                    this.tipoMusica = TipoMusica.Trap;
                    break;
                case 8:
                    this.tipoMusica = TipoMusica.Cuarteto;
                    break;
                case 9:
                    this.tipoMusica = TipoMusica.Independiente;
                    break;
                case 10:
                    this.tipoMusica = TipoMusica.Cumbia;
                    break;
            }
        }

    }
}
