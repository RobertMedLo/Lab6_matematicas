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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //al cargar el formulario
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("hh : mm : ss");
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Integrantes_Click(object sender, EventArgs e)
        {

        }
    }
}
