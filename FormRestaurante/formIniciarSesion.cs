using System;
using System.Windows.Forms;
using Usuarios;

namespace FormRestaurante
{
    public partial class formIniciarSesion : Form
    {
        private formMenuPrincipal formMP;
        string[] usuarios;
        string[] contrasenas;
        ErrorProvider miError;

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
                if (formMP == null)
                {
                    formMP = new formMenuPrincipal(this);
                    formMP.Show();
                    this.Hide();
                    formMP = null;
                }
                miError.Clear();

            }
            else
            {
                miError.SetError(txtPassword, "Contraseña incorrecta.");
            }
        }
    }
}
