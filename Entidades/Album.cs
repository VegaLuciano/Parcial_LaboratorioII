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
        private string? autor;
        private string? nombreDelAlbum;
        private TipoMusica tipoMusica;
        private int añoDeSalida;

        public Album(double precio, bool estaEnOferta, int stock, string autor, TipoMusica tipoMusica, int añoDeSalida, string? nombreDelAlbum) : base(precio, estaEnOferta, stock)
        {
            this.tipoMusica = tipoMusica;
            this.autor = autor;
            this.añoDeSalida = añoDeSalida;
            this.nombreDelAlbum = nombreDelAlbum;
        }
        public Album(double precio, bool estaEnOferta, int stock, string autor, TipoMusica tipoMusica, int añoDeSalida, string? nombreDelAlbum, DateTime fechaDeVenta, Cliente? comprador ) : this(precio, estaEnOferta, stock, autor, tipoMusica, añoDeSalida, nombreDelAlbum)
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

            sb.AppendLine($"{this.autor}");
            sb.AppendLine($"Nombre del albúm: {this.nombreDelAlbum}");
            sb.AppendLine($"Tipo: {this.tipoMusica}");
            sb.AppendLine($"Año de slaida {this.añoDeSalida}");
            //sb.AppendLine(base.ToString());

            return sb.ToString();
        }

        public string MostrarVenta()
        {
            string? retorno = "";
            if (!(this.Comprador == null))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(this.Mostrar());
                sb.AppendLine(this.Comprador.ToString());
                sb.AppendLine(this.fechaDeVenta.ToLongDateString());
            }

            return retorno;
        }



    }
}
