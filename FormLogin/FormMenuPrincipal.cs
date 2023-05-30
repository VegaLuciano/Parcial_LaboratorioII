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
    public partial class FormMenuPrincipal : Form
    {
        private Usuario usuario;
        public Dictionary<string, List<Album>> albumesStockDic = new Dictionary<string, List<Album>>();
        public List<List<Album>> albumesStockList = new List<List<Album>>();
        public List<Instrumento> instrumentosStock = new List<Instrumento>();

        public FormMenuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            albumesStockDic = Sistema.AlbumesStockDic;
            albumesStockList = Sistema.AlbumesStockList;
            instrumentosStock = Sistema.InstrumentosStock;
        }

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {

        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVerStock_Click(object sender, EventArgs e)
        {
            FormVerStock FormVerStock = new FormVerStock(albumesStockDic, albumesStockList, instrumentosStock, usuario);
            FormVerStock.Show();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            FormVenta formVenta = new FormVenta();  
            formVenta.Show();
          
        }
    }
}
