using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculus;//importamos la clase para  el analizador sintaxtico

namespace Proyecto_Matematicas
{
    public partial class Derivadas : Form
    {
        private string expresion;
        Calculo analisador_de_funcion = new Calculo();//creamos el objeto de la clase de terceros
        public Derivadas()
        {
            InitializeComponent();
        }

        private void btn_calculo_Click(object sender, EventArgs e)
        {
            //calculamos la derivada
            //obtenemos la funcion del textbox
            expresion = txt_funcion.Text;
            double h = 1e-10, x = Convert.ToDouble(txt_parametro.Text);//defimos los parametros con los que vamos a derivar
            double derivada = (f(h + x) - f(x)) / h;
            txt_respuesta.Text = "La derivada es de "+ Math.Truncate(derivada*10000)/10000;

        }
        private double f(double x)
        {
            double y = 0;
            if (analisador_de_funcion.Sintaxis(expresion, 'x'))
            {
                y = analisador_de_funcion.EvaluaFx(x);
                return y;//retornamos la variable ya evaluada en X
            }
            else
            {
                return 0;
            }
        }
        //---------------------------------------

    }
}
