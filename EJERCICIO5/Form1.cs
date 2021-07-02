using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int columnas;
            int filas;
            filas = Convert.ToInt32(textBoFilas.Text);
            columnas = Convert.ToInt32(textBoXColum.Text);
            int[,] matrizEjemplo = new int[filas, columnas];
            Random aleatorio = new Random();

            for (int IndiceFila = 0; IndiceFila < matrizEjemplo.GetLength(0); IndiceFila++)
            {
                for (int IndiceColumna = 0; IndiceColumna < matrizEjemplo.GetLength(1); IndiceColumna++)
                {
                    matrizEjemplo[IndiceFila, IndiceColumna] = aleatorio.Next(100);
                }
            }
            for (int IndiceFila = 0; IndiceFila < matrizEjemplo.GetLength(0); IndiceFila++)
            {
                for (int IndiceColumna = 0; IndiceColumna < matrizEjemplo.GetLength(1); IndiceColumna++)
                {
                    MessageBox.Show("La posicion es : " + IndiceFila + "," + IndiceColumna + " = " + matrizEjemplo[IndiceFila, IndiceColumna].ToString());
                }
            }
        }
    }
}
