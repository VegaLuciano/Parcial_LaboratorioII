using Entidades;
using System.Runtime.InteropServices;

namespace FormLogin
{
    public partial class FormLogin : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario;

            if (Sistema.ValidarUsuarios(txtUsuario.Text, txtContrase�a.Text, out usuario))
            {
                FormMenuPrincipal FormMenuPrincipal = new FormMenuPrincipal(usuario);
                FormMenuPrincipal.Show();
                this.Hide();
            }
            else
            {
                lblContrase�a.Visible = true;
                lblUsuario.Visible = true;

            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "")
                {
                    txtUsuario.Text = "Ingresar  Usuario";
                }

                txtUsuario.ForeColor = Color.White;
                lblErrorUsuario.Visible = false;
            }
            catch { }
        }

        private void txtContrase�a_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtContrase�a.Text == "")
                {
                    txtContrase�a.Text = "Contrase�a";
                }
                txtContrase�a.ForeColor = Color.White;
                txtContrase�a.PasswordChar = '*';
                lblErroContrase�a.Visible = false;
            }
            catch { }
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.SelectAll();
        }

        private void txtContrase�a_Click(object sender, EventArgs e)
        {
            txtContrase�a.SelectAll();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}