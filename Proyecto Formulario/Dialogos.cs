using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Formulario
{
    public partial class Dialogos : Form
    {
        public Dialogos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje con boton de aceptar", "Ejemplo Mensaje Aceptar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje de información con botones Aceptar y Cancelar", "Ejemplo Mensaje OKCanccel", MessageBoxButtons.OKCancel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje informativo con botones Sí, No y Cancelar",
                    "Ejemplo Mensaje YesNoCanccel", MessageBoxButtons.YesNoCancel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje informativo con boton Aceptar", "Ejemplo Mensaje Exclamation", MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje interrogativo", "Ejemplo Mensaje Question",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje informativo", "Titulo Ventana",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
