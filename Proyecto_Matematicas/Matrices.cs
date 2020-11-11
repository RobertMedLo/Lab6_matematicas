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
    public partial class Matrices : Form
    {
        
        public Matrices()
        {
            InitializeComponent();
        }

        private void Matrices_Load(object sender, EventArgs e)
        {
            
        }

       
       

        private void button1_Click(object sender, EventArgs e)
        {
            //agregar filas a la matriz
            Matriz_principal.Rows.Add();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //quitar fila 
            try
            {
                if (Matriz_principal.CurrentRow.Index != -1)//validamos si existe una fila selecciona para la eliminacion
                {
                    Matriz_principal.Rows.RemoveAt(Matriz_principal.CurrentRow.Index);
                    
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error try again");
            }
           
        }

        private void btn_escalar_Click(object sender, EventArgs e)
        {
            //copiamos las dimensiones de la matriz original
            InputBoxEscalar ib = new InputBoxEscalar();
            ib.ShowDialog();
            int escalar=ib.dato();
            igualar_dimensiones();
            
            //---------------------------------------------
            //recorremos la matriz original
            for (int filas = 0;filas < Matriz_principal.Rows.Count - 1; filas++)
            {
                for(int columnas = 0; columnas < 2; columnas++)
                {
                    
                    int resultado = Convert.ToInt32(Matriz_principal.Rows[filas].Cells[columnas].Value.ToString());//capturamos el valor de esa celda
                    Matriz_resultado.Rows[filas].Cells[columnas].Value = (resultado*escalar).ToString();
                }
            }
            
        }
        private void igualar_dimensiones()
        {
            for (int i = 0; i < Matriz_principal.Rows.Count - 1; i++)
            {
                Matriz_resultado.Rows.Add();
            }
        }

        private void btn_rotar_Click(object sender, EventArgs e)
        {
            igualar_dimensiones();
            ImputBoxRotar ir = new ImputBoxRotar();
            ir.ShowDialog();
            int angulo = ir.dato();
            
            MessageBox.Show("El angulo es de : " + angulo +"grados y en radianes es de : "+Math.Cos(((180/Math.PI)*Convert.ToDouble(angulo))));
            int tamaño = Matriz_principal.Rows.Count - 1;//obtenemos la cantidad de filas que existen en la matriz principal

            //creamos y llenamos la matriz con la que se rota
            int [,]matriz_de_rotacion=new int[2,2];
            matriz_de_rotacion[0, 0] = 0;
            matriz_de_rotacion[0,1] = 0;
            matriz_de_rotacion[1,0] = 0;
            matriz_de_rotacion[1, 1] = 0;
        }
    }
}
