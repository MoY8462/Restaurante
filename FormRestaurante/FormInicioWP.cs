using System;
using System.Windows.Forms;

namespace FormRestaurante
{
    public partial class FormInicioWP : Form
    {
        private FormIniciarSesion formRegistro;

        public FormInicioWP()
        {
            InitializeComponent();
            
        }

        private void TimerPanatallaInicio_Tick(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(5000);
        }
    }
}
