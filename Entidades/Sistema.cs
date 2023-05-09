using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Sistema
    {
        private static List<Usuario> listaUsuarios = new List<Usuario>();
       
        static Sistema() 
        {
            CargarUsuarios();
        }

        public static void CargarUsuarios()
        {
            Usuario UsuarioTurnoMañana = new Usuario(42858222, 24, "Celeste", "Román", "user1A", "CelesteTM");
            Usuario UsuarioTurnoTarde = new Usuario(39254774, 29, "Marcos", "Cruz", "user1B", "MarcosTM");
            Usuario UsuarioAdmin = new Usuario(1111111, 1, "Admin", "Admin", "a", "a");

            listaUsuarios.Add(UsuarioAdmin);
            listaUsuarios.Add(UsuarioTurnoTarde);
            listaUsuarios.Add(UsuarioTurnoMañana);

        }

        public static bool ValidarUsuarios(string nombreUsuario, string contraseñaUsuario, out Usuario? usuarioValidado) 
        {
            bool retorno = false;
            usuarioValidado = null;

            foreach (Usuario usuario in listaUsuarios) 
            {
                if (usuario.ValidarUsuario(nombreUsuario, contraseñaUsuario)) 
                {
                    usuarioValidado = usuario;
                    retorno = true;
                }

               
            }
            
            return retorno;
        }
        
    }
}
