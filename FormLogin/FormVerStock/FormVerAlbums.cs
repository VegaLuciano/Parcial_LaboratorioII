using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class FormVerAlbums : Form
    {
        //public Dictionary<string, List<Album>> albumesStockDic = new Dictionary<string, List<Album>>();
        public List<List<Album>> albumesStockList = new List<List<Album>>();

        public FormVerAlbums(List<List<Album>> albumesStockList)
        {
            InitializeComponent();
            // albumesStockDic = Sistema.AlbumesStockDic;
            this.albumesStockList = albumesStockList;
        }

        private void FormVerStock_Load(object sender, EventArgs e)
        {
            List<Album> listaFinal = new List<Album>();

            foreach (List<Album> lista in albumesStockList)
            {
                foreach (Album album in lista)
                {
                    listaFinal.Add(album);
                }
            }

            Sistema.LimpiarRepetidos(listaFinal);
            dtgAlbum.DataSource = listaFinal;
        }


    }
}
