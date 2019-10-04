using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuarios;

namespace FormRestaurante
{
    public partial class FormRegistrar : Form
    {

        public Persona[] personas;
        private Form formpadre;
        private byte TipoError;
        private ErrorProvider errorProvider;
        private byte indPers;

        public byte IndPers
        {
            get => indPers;

            set
            {
                if (value > 2)
                {
                    indPers = 0;
                }

                else
                {
                    indPers = value;
                }

            }
        }

        public FormRegistrar(Form formpadre)
        {
            this.formpadre = formpadre;
            InitializeComponent();
            personas = new Persona[5];
            errorProvider = new ErrorProvider();
        }

        private void FormRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona persona = new Persona();
                errorProvider.Clear();
                persona.Nickname = txtbNombre.Text;
                if (persona.Nickname == "")
                {
                    string error = "No se puede dejar el campo vacío";
                    TipoError = 0;
                    throw new ApplicationException(error);

                }
                persona.Apellido = txtbApellido.Text;
                if(persona.Nickname== "")
                {
                    string error = "No se puede dejar el campo vacío";
                    TipoError = 1;
                    throw new ApplicationException(error);
                }
                persona.Contrasena = txtbContraseña.Text;
                if (txtbContraseña.Text == "")
                {
                    txtbContraseña.Text = persona.Contrasena;
                    TipoError = 2;
                }
                persona.ConfContraseña = txtbConfirmacionContraseña.Text;
                if (txtbConfirmacionContraseña.Text == "")
                {
                    txtbConfirmacionContraseña.Text = persona.ConfContraseña;
                    TipoError = 2;
                }
                if(persona.Contrasena != persona.ConfContraseña)
                {
                    txtbConfirmacionContraseña.Text = persona.ConfContraseña;
                    txtbContraseña.Text = persona.Contrasena;
                    TipoError = 6;
                }

                persona.Correo = txtbCorreo.Text;
                if (txtbCorreo.Text == "")
                {
                    string error = "No se puede quedar el campo vacío";
                    TipoError = 2;
                    throw new ApplicationException(error);
                }
                else if (!persona.Correo.Contains("@"))
                {
                    string error = "Se debe agregar un símbolo '@'";
                    TipoError = 2;
                    throw new ApplicationException(error);
                }
                else if (!persona.Correo.Contains("."))
                {
                    string error = "Se debe agregar un '.'";
                    TipoError = 2;
                    throw new ApplicationException(error);
                }
                byte pos1 = 0;
                byte pos2 = 0;
                for (int i = 0; i < persona.Correo.Length; i++)
                {
                    char caracter = persona.Correo[i];
                    if (caracter == 64)
                    {
                        pos1 = (byte)i;
                    }
                    if (caracter == 46)
                    {
                        pos2 = (byte)i;
                    }
                }
                if (pos1 > pos2)
                {
                    string error = "NO es valido el correo";
                    TipoError = 2;
                    throw new ApplicationException(error);
                }
                //string comprobarTelefono = txtbTelefono.Text;
                //if()

                persona.Telefono = int.Parse(txtbTelefono.Text);
                if(persona.Telefono <=99999999 && persona.Telefono >=1000000000)
                {
                    string error = "NO es valido el número teléfonico";
                    TipoError = 7;
                    throw new ApplicationException(error);
                }

                persona.Pregunta = cmbPregunta.Items[cmbPregunta.SelectedIndex].ToString();
                persona.Respuesta = txtbRespuesta.Text;
                if (txtbRespuesta.Text == "")
                {
                    string error = "No se puede quedar el campo vacío";
                    TipoError = 3;
                    throw new ApplicationException(error);
                }
                personas[IndPers++] = persona;

                this.Hide();
                formpadre.Show();
            }
            catch (ApplicationException error)
            {
                switch (TipoError)
                {
                    case 0:
                        errorProvider.SetError(txtbNombre, error.Message);
                        break;
                    case 1:
                        errorProvider.SetError(txtbApellido, error.Message);
                        break;
                    case 2:
                        errorProvider.SetError(txtbContraseña, error.Message);
                        break;
                    case 3:
                        errorProvider.SetError(txtbConfirmacionContraseña, error.Message);
                        break;
                    case 4:
                        errorProvider.SetError(txtbCorreo, error.Message);
                        break;
                    case 5:
                        errorProvider.SetError(txtbRespuesta, error.Message);
                        break;
                    case 6:
                        errorProvider.SetError(txtbContraseña, error.Message);
                        errorProvider.SetError(txtbConfirmacionContraseña, error.Message);
                        break;
                    case 7:
                        errorProvider.SetError(txtbTelefono, error.Message);
                        break;

                }

            }
            catch (ArgumentOutOfRangeException)
            {
                errorProvider.SetError(cmbPregunta, "Debes seleccionar una pregunta");

            }
            catch
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void TxtbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
