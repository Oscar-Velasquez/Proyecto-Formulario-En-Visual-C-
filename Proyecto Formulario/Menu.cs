using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Formulario
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void baceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje con boton de aceptar", "Ejemplo Mensaje Aceptar");
        }

        private void baceptar__Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje de información con botones Aceptar y Cancelar", "Ejemplo Mensaje OKCanccel", MessageBoxButtons.OKCancel);
        }

        private void bsi_no_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje informativo con botones Sí, No y Cancelar",
                    "Ejemplo Mensaje YesNoCanccel", MessageBoxButtons.YesNoCancel);
        }

        private void bexclamacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje informativo con boton Aceptar", "Ejemplo Mensaje Exclamation", MessageBoxButtons.OK, 
            MessageBoxIcon.Exclamation);
        }

        private void binterrogacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje interrogativo", "Ejemplo Mensaje Question",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void berror_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje informativo", "Titulo Ventana",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void acercadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codigo de ejemplo para abrir unformulario SDI flotante sobre menu
            acercade abrir_acercade = new acercade();
            abrir_acercade.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codigo de ejemplo para abrir un formulario SDI dentro del menu
            ayuda abrir_ayuda = new ayuda();
            abrir_ayuda.MdiParent = this;
            abrir_ayuda.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cuadroDeDialogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialogos abrir_dialogos = new Dialogos();
            abrir_dialogos.ShowDialog();
        }
    }
}
