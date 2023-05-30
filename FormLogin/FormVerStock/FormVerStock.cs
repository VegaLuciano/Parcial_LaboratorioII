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
    public partial class FormVerStock : Form
    {
        private Dictionary<string, List<Album>> albumesStockDic = new Dictionary<string, List<Album>>();
        private List<List<Album>> albumesStockList = new List<List<Album>>();
        private List<Instrumento> instrumentosStock = new List<Instrumento>();
        private Usuario usuario;

        public FormVerStock(Dictionary<string, List<Album>> albumesStockDic, List<List<Album>> albumesStockList, List<Instrumento> instrumentosStock, Usuario usuario)
        {
            InitializeComponent();
            this.albumesStockDic = albumesStockDic;
            this.albumesStockList = albumesStockList;
            this.instrumentosStock = instrumentosStock;
            this.usuario = usuario;
        }

        private void FormVerStock_Load(object sender, EventArgs e)
        {
            if (usuario.Nombre == "admin")
            {
                btnAgregar.Visible = true;
            }
            else
            {
                btnAgregar.Visible = false;
            }
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            FormVerAlbums formVerAlbums = new FormVerAlbums(albumesStockList);
            formVerAlbums.Show();
        }

        private void btnInstrumentos_Click(object sender, EventArgs e)
        {
            FormVerInstrumentos formVerInstrumentos = new FormVerInstrumentos(instrumentosStock);
            formVerInstrumentos.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarStock formAgregarStock = new FormAgregarStock(albumesStockDic, albumesStockList, instrumentosStock, usuario);
            formAgregarStock.Show();
        }
    }
}
