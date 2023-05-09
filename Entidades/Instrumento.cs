using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Instrumento : Producto
    {
        private string nombre;
        private TipoInstrumento tipoInstrumento;
        private int garantia;


        public Instrumento(double precio, bool estaEnOferta, int stock, int garantia, string nombre, TipoInstrumento tipo) : base(precio, estaEnOferta, stock)
        {
            this.garantia = garantia;
            this.tipoInstrumento = tipo;
            this.nombre = nombre;
            this.comprador = null;
        }

        public Instrumento(double precio, bool estaEnOferta, int stock, int garantia, string nombre, TipoInstrumento tipo, DateTime fechaDeVenta, Cliente comprador) : this(precio, estaEnOferta, stock, garantia, nombre, tipo)
        {
            this.FechaDeVenta = fechaDeVenta;
            this.Comprador = comprador;
        }

        public double Precio { get => precio; set => precio = value; }
        public bool EstaEnOferta { get => estaEnOferta; set => estaEnOferta = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Garantia { get => garantia; set => garantia = value; }
        public DateTime FechaDeVenta { get => fechaDeVenta; set => fechaDeVenta = value; }
        public Cliente? Comprador { get => comprador; set => comprador = value; }
        internal TipoInstrumento TipoInstrumento { get => tipoInstrumento; set => tipoInstrumento = value; }


        public override bool PreguntarOferta() 
        {
            bool retorno =  false;

            if (this.stock > 15) 
            {
                retorno = true;
                this.estaEnOferta = true;
            }

            return retorno;
        }

        public override bool ReclamarGarantia() 
        {
            bool retorno = false;
            DateTime diaDeDevolucion = DateTime.Now;

            if ((this.FechaDeVenta.Year + 2) < diaDeDevolucion.Year)
            {
                retorno = true;
            }
            return retorno;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre}");
            sb.AppendLine($"Tipo: {this.tipoInstrumento}");
            sb.AppendLine($"Garantia: {this.garantia}");
            sb.AppendLine(base.ToString());

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
