using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void importe_TextChanged(object sender, EventArgs e)
        {

        }

        private void añadir_Click(object sender, EventArgs e)
        {
            Codigo acciones = new Codigo();
            var cliente = acciones.guardar(nombreCliente.Text, importe.Text);
            var sumar = acciones.sumar();
            label4.Text = sumar.ToString();
        }
    }
}
