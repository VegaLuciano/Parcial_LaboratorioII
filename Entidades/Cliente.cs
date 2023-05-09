using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        protected int cantidadOperaciones;
        protected bool clienteHabitual;

        public Cliente(int dni, int edad, string nombre, string apellido, int cantidadOperaciones, bool clienteHabitual) : base(dni, edad, nombre, apellido)
        {
            this.dni = dni;
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellido;
            this.clienteHabitual = clienteHabitual;
            this.cantidadOperaciones = cantidadOperaciones;
        }

        public bool ClienteHabitual { get => clienteHabitual; set => clienteHabitual = value; }
        public int CantidadOperaciones { get => cantidadOperaciones; set => cantidadOperaciones = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Cantidad de operaciones realizadas: {this.CantidadOperaciones}");
            if (clienteHabitual) 
            {
                sb.AppendLine("Es un cliente habitual");
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        protected void EsClienteHabitual() 
        {
            if (this.cantidadOperaciones >= 5)
            {
                this.clienteHabitual = true;
            }
            else 
            {
                this.clienteHabitual = false;
            }
        }

        public static bool operator ==(Cliente? unCliente, Cliente? otroCliente) 
        {
            bool retorno = false;

            if (!(unCliente == null || otroCliente == null))
            {
                if (unCliente.dni == otroCliente.dni)
                {
                    retorno = true;
                }
            }
               

            return retorno;
        }
        public static bool operator !=(Cliente unCliente, Cliente otroCliente)
        {
            return !(unCliente == otroCliente);
        }

        public bool verificarCliente(Cliente unCliente, Cliente otroCliente) 
        {
            return unCliente == otroCliente;
        }

        public bool DevolverInstrumento(Instrumento instrumento)
        {
            bool retorno = false;

            if (instrumento.Comprador == this)
            {
                if (instrumento.ReclamarGarantia())
                {
                    retorno = true;
                    instrumento.Stock++;
                    instrumento.EstaEnOferta = true;
                    instrumento.Precio += 0.90;
                }
            }

            return retorno;
        }

        public bool DevolverAlbum(Album album) 
        {
            bool retorno = false;

            if (album.Comprador == this) 
            {
                if (album.ReclamarGarantia()) 
                {
                    retorno = true;

                }
            }

            return retorno;
        }
    }
}
