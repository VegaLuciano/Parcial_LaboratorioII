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

            if (Sistema.ValidarUsuarios(txtUsuario.Text, txtContraseña.Text, out usuario))
            {
                FormMenuPrincipal FormMenuPrincipal = new FormMenuPrincipal(usuario);
                FormMenuPrincipal.Show();
                this.Hide();
            }
            else
            {
                lblContraseña.Visible = true;
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

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtContraseña.Text == "")
                {
                    txtContraseña.Text = "Contraseña";
                }
                txtContraseña.ForeColor = Color.White;
                txtContraseña.PasswordChar = '*';
                lblErroContraseña.Visible = false;
            }
            catch { }
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.SelectAll();
        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.SelectAll();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}