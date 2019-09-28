using System;
using System.Windows.Forms;
using Usuarios;

namespace FormRestaurante
{
    public partial class formIniciarSesion : Form
    {

        string[] usuarios;
        string[] contrasenas;

        public formIniciarSesion()
        {
            InitializeComponent();

            usuarios = new string[]
            {
                "prueba"
            };

            contrasenas = new string[]
            {
                "123"
            };

            txtPassword.PasswordChar = '•';
        }

        private void PbIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtNombre.Text;
            string contrasena = txtPassword.Text;

            if (usuario == usuarios[0] && contrasena == contrasenas[0])
            {
                if (formMenuPrincipal == null)
                {
                    formJuego = new formIniciarSesion(this);
                    formJuego.Show();
                    this.Hide();
                    formJuego = null;
                }
                mierror.Clear();

            }
            else
            {
                mierror.SetError(txtbContraseña, "Contraseña incorrecta");
            }
        }
    }
}
