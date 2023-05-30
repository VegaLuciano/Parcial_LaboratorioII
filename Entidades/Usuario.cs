using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Persona
    {
        private string contraseñaUser;
        private string nombreUser;

        public Usuario(int dni, int edad, string nombre, string apellido, string contraseñaUser, string nombreUser) : base(dni, edad, nombre, apellido)
        {
            this.contraseñaUser = contraseñaUser;
            this.nombreUser = nombreUser;
        }

        public Usuario(int dni, int edad, string nombre, string apellido) : base(dni, edad, nombre, apellido)
        {
            this.contraseñaUser = "";
            this.nombreUser = "Usuario sin validar";
        }

        public string ContraseñaUser { get => contraseñaUser; set => contraseñaUser = value; }
        public string MombreUser { get => nombreUser; set => nombreUser = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public string MostrarConstraseña()
        {
            return this.contraseñaUser;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Usuario: {this.nombreUser}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        public bool ValidarUsuario(string nombreUser, string contraseñaUser)
        {
            return this.nombreUser == nombreUser && this.contraseñaUser == contraseñaUser;
        }

        public Cliente VenderProducto(Instrumento instrumento, Cliente clienteCompra)
        {
            Cliente retornoCliente = null;

            if (instrumento.Stock > 1)
            {
                if (instrumento.PreguntarOferta())
                {
                    instrumento.Precio = instrumento.Precio * 0.75;
                    retornoCliente = clienteCompra;
                }
                instrumento.Stock--;
            }

            return retornoCliente;

        }
        public Cliente VenderProducto(Instrumento instrumento, int cantidadProductos, Cliente clienteCompra)
        {
            Cliente retornoCliente = null;

            if (instrumento.Stock > cantidadProductos + 1)
            {
                if (instrumento.PreguntarOferta())
                {
                    instrumento.Precio = instrumento.Precio * 0.75;
                    retornoCliente = clienteCompra;
                }

                instrumento.Stock -= cantidadProductos;
            }
            return retornoCliente;
        }
    }
}
