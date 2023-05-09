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

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            
            if(Sistema.ValidarUsuarios(txtUsuario.Text, txtContraseña.Text, out usuario))
            {
                FormMenuPrincipal FormMenuPrincipal = new FormMenuPrincipal(usuario);
                FormMenuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("a");
            }

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}