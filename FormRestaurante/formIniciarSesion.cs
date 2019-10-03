using System;
using System.Windows.Forms;

namespace FormRestaurante
{
    public partial class FormIniciarSesion : Form
    {
        string[] usuarios;
        string[] contrasenas;
        //ErrorProvider miError;

        public FormIniciarSesion()
        {
            FormInicioWP formInicioWP = new FormInicioWP();
            formInicioWP.Show();
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
            /*string usuario = txtNombre.Text;
            string contrasena = txtPassword.Text;

            if (usuario == usuarios[0] && contrasena == contrasenas[0])
            {
                if (formMP == null)
                {
                    formMP = new FormMenuPrincipal(this);
                    formMP.Show();
                    this.Hide();
                    formMP = null;
                }
                miError.Clear();

            }
            else
            {
                miError.SetError(txtPassword, "Contraseña incorrecta.");
            }*/
        }
    }
}
