namespace Entidades
{
    public abstract class Personaje
    {
        protected int cantidadDeVida;
        protected string nombre;
        protected int dañoBase;
        protected int nivel;


        public Personaje(int cantidadDeVida, string nombre, int curacion, int nivel)
        {
            this.cantidadDeVida = cantidadDeVida;
            this.nombre = nombre;
            this.nivel = nivel;
        }

        public int CantidadDeVida { get => cantidadDeVida; set => cantidadDeVida = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int DañoBase { get => dañoBase; set => dañoBase = value; }

        internal abstract int Atacar() 
        {
            
        }

        internal bool Morir() 
        {
            bool retorno =  false;

            if (this.cantidadDeVida == 0) 
            {
                retorno = true;
            }

            return retorno;
        }
    }
}