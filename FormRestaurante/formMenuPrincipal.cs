﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRestaurante
{
    public partial class FormMenuPrincipal : Form
    {
        private Form formPadre;

        public FormMenuPrincipal(Form formPadre)
        {
            this.formPadre = formPadre;
            InitializeComponent();
        }
    }
}
