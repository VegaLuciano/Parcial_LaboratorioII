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
    public partial class FormVerInstrumentos : Form
    {
        private List<Instrumento> instrumentosList = new List<Instrumento>();

        public FormVerInstrumentos(List<Instrumento> instrumentosList)
        {
            InitializeComponent();
            this.instrumentosList = instrumentosList;
        }

        private void FormVerInstrumentos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = instrumentosList;
        }
    }
}
