using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        protected int dni;
        protected int edad;
        protected string nombre;
        protected string apellido;

        protected Persona(int dni, int edad, string nombre, string apellido)
        {
            this.dni = dni;
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public virtual string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Dni: {this.dni}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}