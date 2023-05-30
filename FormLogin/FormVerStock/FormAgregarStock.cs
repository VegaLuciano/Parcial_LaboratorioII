using Entidades;
using System;
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
    public partial class FormAgregarStock : Form
    {
        private Dictionary<string, List<Album>> albumesStockDic = new Dictionary<string, List<Album>>();
        private List<List<Album>> albumesStockList = new List<List<Album>>();
        private List<Instrumento> instrumentosStock = new List<Instrumento>();

        public FormAgregarStock(Dictionary<string, List<Album>> albumesStockDic, List<List<Album>> albumesStockList, List<Instrumento> instrumentosStock, Usuario usuario)
        {
            InitializeComponent();
            this.albumesStockDic = albumesStockDic;
            this.albumesStockList = albumesStockList;
            this.instrumentosStock = instrumentosStock;
            Stack<Object> stockAgregar = new Stack<Object>();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            //funcion para verificar los inputs
            double precioAlbum = double.Parse(txtPrecioAlbum.Text);
            Album nuevoAlbum = new Album(precioAlbum, false, (int)npdCopias.Value, txtAutor.Text, cmbTipoMusica.SelectedIndex, (int)npdSalida.Value, txtNombreAlbum.Text);
            MessageBox.Show(nuevoAlbum.ToString());
            AgregarAlbumList(nuevoAlbum);
        }

        private void bynAgregarInstrumento_Click(object sender, EventArgs e)
        {
            //funcion para verificar los inputs
            double precioInstrumento = double.Parse(txtPrecioInstrumento.Text);
            Instrumento nuevoInstrumento = new Instrumento(precioInstrumento, false, (int)npdStockInstrumento.Value, (int)npdGarantia.Value, txtNombreInstrumento.Text, cmbTipoInstrumento.SelectedIndex);
            MessageBox.Show(nuevoInstrumento.ToString());
            instrumentosStock.Add(nuevoInstrumento);
        }

        private void FormAgregarStock_Load(object sender, EventArgs e)
        {

        }

        private void AgregarAlbumList(Album album) 
        {
            foreach (List<Album> lista in albumesStockList) 
            {
                foreach(Album albumlist in lista) 
                {
                    if (albumlist.TipoMusica == album.TipoMusica) 
                    {
                        lista.Add(album);
                        break;
                    }
                }
            }
        }

        private void AgregarAlbumDic(Album album) 
        {
            foreach (string key in albumesStockDic.Keys) 
            {
                if (album.Autor == key)
                {
                    albumesStockDic[key].Add(album);
                    break;
                }
                else 
                {
                    albumesStockDic.Add(album.Autor, album);
                }
            }
        }
    }
}
