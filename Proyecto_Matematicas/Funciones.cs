using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculus;//esta es la libreria de terceros que analiza la exprecion desde el texbox

namespace Proyecto_Matematicas
{
    public partial class Funciones : Form
    {
        private Graphics grafico;//creamos el objeto grafico de forma global
        private float X_centro, Y_centro,f;
        //variables a utilizar en la interacion de la funcion
        private float x1, y1, x2, y2, acumulador=0.001f;

        private string expresion;

        Calculo analisador_de_funcion = new Calculo();//creamos el objeto de la clase de terceros

        private void Funciones_Load(object sender, EventArgs e)
        {

        }

        public Funciones()
        {
            InitializeComponent();
        }

        private void pic_grafica_Click(object sender, EventArgs e)
        {

        }

        private void btn_grafica_Click(object sender, EventArgs e)
        {
            
            //al hacer click en este boton se mostrará la grafica
            //capturamos la funcion
            //f = float.Parse(txt_funcion.Text);
            //creamos el objeto de tipo grafico y le asignamos el marco de dibujo de la picturebox
            grafico =pic_grafica.CreateGraphics();
            

            //como estamos trabajando con el plano carteciano necesitamos trasladar las cordenada 0,0 al centro del pictureBox
            //calculamos el centro de la pantalla en la que vamos a graficar
             X_centro = pic_grafica.Width / 2;
             Y_centro = pic_grafica.Height / 2;
            //con este metodo trasladamos el centro a esa coordenada
            grafico.TranslateTransform(X_centro,Y_centro);
            
            dibujar_ejes();//llamamos al metodo
            //-------------------------------------------------------------------------------------------------------------------------------

            expresion = txt_funcion.Text;//guardamos la funcion que se inserte en el texbox

            

            //mostramos la funcion
            grafico.ScaleTransform(4,4);//escalamos la funcion
            x1 = -X_centro;
            while (x1<X_centro)//iteramos la funcion tomando encuenta el desbordamiento de pantalla
            {
                y1 = funcion(x1);
                x2 = x1 + acumulador;
                y2 = funcion(x2);
                if (y2 == 0)
                {
                    MessageBox.Show("La sintaxis de la funcion insertada NO es correcto");//cerramos y terminamos el bucle
                    txt_funcion.Clear();//limpiamos el texbox
                    break;
                }
                grafico.DrawLine(Pens.Red, x1, y1, x2, y2);
                x1=x2;
            }
        }
        private void dibujar_ejes()
        {
            //con este metodo dibujaremos los ejes del plano carteciano
            //los parametros son --> el tipo de lapiz que se va a utilizar y las cordenadas donde empieza y donde termina
            //pic_grafica.BackColor = Color.FromArgb(255, 255, 255);
            //eje X
            grafico.DrawLine(Pens.Black,-X_centro, 0, X_centro, 0);
            //eje Y
            grafico.DrawLine(Pens.Black,0,-Y_centro, 0,Y_centro);
            

        }
        //metodo para evaluar la funcion que va a entrar
        private float funcion(float x)
        {
            float y = 0;
            if (analisador_de_funcion.Sintaxis(expresion,'x'))
            {
               y = (float)analisador_de_funcion.EvaluaFx(x);
               return y * -1;//retornamos la variable ya evaluada en X
            }
            else
            {
                return 0;
            }
           
            
            
        }
    }
}
