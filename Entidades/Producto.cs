using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        protected double precio;
        protected bool estaEnOferta;
        protected int stock;
        protected DateTime fechaDeVenta;
        protected Cliente? comprador;

        public Producto(double precio, bool estaEnOferta, int stock)
        {
            this.precio = precio;
            this.estaEnOferta = estaEnOferta;
            this.stock = stock;
        }

        public abstract bool PreguntarOferta();

        public abstract bool ReclamarGarantia();
  

        public virtual string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Precio: {this.precio}");
            sb.AppendLine($"Stock: {this.stock}");
            if (this.PreguntarOferta()) 
            {
                sb.AppendLine("Esta en oferta");
            }

            return sb.ToString();

        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
