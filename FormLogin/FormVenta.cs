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
    public partial class FormVenta : Form
    {
        public FormVenta()
        {
            InitializeComponent();
        }



        private void FormVenta_Load(object sender, EventArgs e)
        {


        }

        private void ckbAlbum_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAlbum.Checked)
            {
                txtBuscador.Visible = true;
                dtgAlbum.Visible = true;
            }
            else
            {
                txtBuscador.Visible = false;
                dtgAlbum.Visible = false;
            }
        }

        private void ckbInstrumento_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbInstrumento.Checked)
            {
                lstbInstrumento.Visible = true;
            }
            else
            {
                lstbInstrumento.Visible = false;
            }
        }

        private void btnBuscarAlbum_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscador.Text))
            {
                Dictionary<string, List<Album>> albumes = Stock.CargarAlbumesStockDiccionario();

                if (albumes.ContainsKey(txtBuscador.Text))
                {
                    List<Album> listAlbum = albumes[txtBuscador.Text];
                    dtgAlbum.DataSource = listAlbum;
                }
                else
                {
                    MessageBox.Show(txtBuscador.Text);
                    txtBuscador.Text = "si se puede";
                }
            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
