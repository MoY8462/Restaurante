using System;
using System.Windows.Forms;
using Usuarios;

namespace FormRestaurante
{
    public partial class Form1 : Form
    {

        string[] usuarios;
        string[] contraseñas;

        public Form1()
        {
            InitializeComponent();

            usuarios = new string[]
            {
                "prueba"
            };

            contraseñas = new string[]
            {
                "123"
            };

            txtPassword.PasswordChar = '•';
        }



    }
}
