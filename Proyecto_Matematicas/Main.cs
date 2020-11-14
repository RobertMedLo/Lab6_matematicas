using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Matematicas
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Home home = new Home();
            AbrirForm_EnPanel(home);
        }
        //funcion para abrir un 
        private void AbrirForm_EnPanel(object formHijo)
        {
            //el contenedor de formularios es el panel en el que se abre los formularios
            if (this.contenedor_de_formularios.Controls.Count > 0)
                this.contenedor_de_formularios.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.contenedor_de_formularios.Controls.Add(fh);
            this.contenedor_de_formularios.Tag = fh;
            //pictureBox10.BackColor = Color.FromArgb(22, 23, 22);
            fh.Show();
        }//fin metodo

        private void btn_Matrices_Click(object sender, EventArgs e)
        {
            Matrices matrices = new Matrices();
            AbrirForm_EnPanel(matrices);
        }

        private void btn_funciones_Click(object sender, EventArgs e)
        {
            Funciones funciones = new Funciones();
            AbrirForm_EnPanel(funciones);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            AbrirForm_EnPanel(home);
        }

        private void btn_derivadas_Click(object sender, EventArgs e)
        {
            Derivadas derivadas = new Derivadas();
            AbrirForm_EnPanel(derivadas);
        }
        //----------------------------------------------------------------------------------------------
    }
}
