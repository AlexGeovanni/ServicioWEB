﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiciosWE.Practica.Net.client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculabutton_Click(object sender, EventArgs e)
        {
            AreRectagulo_ServiceReference.Calcula_AreaWebServiceSoapClient WebS = new AreRectagulo_ServiceReference.Calcula_AreaWebServiceSoapClient();

            Resultado.Text = WebS.Rectagulo(BasetextBox1.Text, AlturatextBox2.Text);

        }
    }
}
