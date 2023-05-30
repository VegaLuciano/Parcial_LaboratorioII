using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Sistema
    {
        private static List<Usuario> listaUsuarios = new List<Usuario>();
        private static Dictionary<string, List<Album>> albumesStockDic = new Dictionary<string, List<Album>>();
        private static List<List<Album>> albumesStockList = new List<List<Album>>();
        private static List<Instrumento> instrumentosStock = new List<Instrumento>();

        public static List<Usuario> ListaUsuarios { get => listaUsuarios; set => listaUsuarios = value; }
        public static Dictionary<string, List<Album>> AlbumesStockDic { get => albumesStockDic; set => albumesStockDic = value; }
        public static List<List<Album>> AlbumesStockList { get => albumesStockList; set => albumesStockList = value; }
        public static List<Instrumento> InstrumentosStock { get => instrumentosStock; set => instrumentosStock = value; }

        static Sistema()
        {
            CargarUsuarios();
            albumesStockDic = Stock.CargarAlbumesStockDiccionario();
            albumesStockList = Stock.CargarAlbumesStockLista();
            instrumentosStock = Stock.CargarInstrumentosStock();
        }


        public static void CargarUsuarios()
        {
            Usuario UsuarioTurnoMañana = new Usuario(42858222, 24, "Celeste", "Román", "user1A", "CelesteTM");
            Usuario UsuarioTurnoTarde = new Usuario(39254774, 29, "Marcos", "Cruz", "user1B", "MarcosTM");
            Usuario UsuarioAdmin = new Usuario(1111111, 1, "admin", "admin", "a", "a");

            listaUsuarios.Add(UsuarioAdmin);
            listaUsuarios.Add(UsuarioTurnoTarde);
            listaUsuarios.Add(UsuarioTurnoMañana);
        }

        public static bool ValidarUsuarios(string nombreUsuario, string contraseñaUsuario, out Usuario usuarioValidado)
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

        public static void LimpiarRepetidos(List<Album> listaDeAlbums)
        {
            for (int i = 0; i < listaDeAlbums.Count; i++)
            {
                for (int j = i + 1; j < listaDeAlbums.Count; j++)
                {
                    if (listaDeAlbums[i].NombreDelAlbum == listaDeAlbums[j].NombreDelAlbum)
                    {
                        listaDeAlbums.Remove(listaDeAlbums[j]);
                    }
                }
            }
        }

    }
}
