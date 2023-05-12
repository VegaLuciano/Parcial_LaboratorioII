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
    public partial class FormVerStock : Form
    {
        public Dictionary<string, List<Album>> albumesStock = new Dictionary<string, List<Album>>();

        public FormVerStock()
        {
            InitializeComponent();
            albumesStock = Sistema.AlbumesStockDic;
        }

        private void dtgAlbums_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormVerStock_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
