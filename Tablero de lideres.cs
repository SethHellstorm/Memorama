using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorama
{
    public partial class Tablero_de_lideres : Form
    {
        string[] informacion;
        string[,] memoria;
        public Tablero_de_lideres(string[,] memo, string[] info1, string[] info2)
        {
            InitializeComponent();
            memoria = memo;
            informacion = info1.Concat(info2).ToArray();
        }

        private void Tablero_de_lideres_Load(object sender, EventArgs e)
        {
            TimeSpan a = TimeSpan.Parse(informacion[4]);
            TimeSpan b = TimeSpan.Parse(memoria[4, 4]);
            if (a < b)
            {
                memoria[4, 0] = informacion[0];
                memoria[4, 1] = informacion[1];
                memoria[4, 2] = informacion[2];
                memoria[4, 3] = informacion[3];
                memoria[4, 4] = informacion[4];
            }
            ordenarMemoria(memoria, 4);
            rellenarTablero();
        }

        private void ordenarMemoria(string[,] array, int columnIndex)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            // Convertir el arreglo 2D a una lista de arrays para facilitar la ordenación
            string[][] arrayList = new string[rows][];
            for (int i = 0; i < rows; i++)
            {
                arrayList[i] = new string[cols];
                for (int j = 0; j < cols; j++)
                {
                    arrayList[i][j] = array[i, j];
                }
            }

            // Ordenar la lista de arrays en función del valor en columnIndex convertido a TimeSpan
            Array.Sort(arrayList, (a, b) =>
            {
                TimeSpan timeA = TimeSpan.Parse(a[columnIndex]);
                TimeSpan timeB = TimeSpan.Parse(b[columnIndex]);
                return timeA.CompareTo(timeB);
            });

            // Convertir la lista de arrays de nuevo a un arreglo 2D
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = arrayList[i][j];
                }
            }

        }

        private void rellenarTablero()
        {
            nombre1ro.Text = memoria[0, 0];
            nombre2do.Text = memoria[1, 0];
            nombre3ro.Text = memoria[2, 0];
            nombre4to.Text = memoria[3, 0];
            nombre5to.Text = memoria[4, 0];

            nickname1ro.Text = memoria[0, 1];
            nickname2do.Text = memoria[1, 1];
            nickname3ro.Text = memoria[2, 1];
            nickname4to.Text = memoria[3, 1];
            nickname5to.Text = memoria[4, 1];

            edad1ro.Text = memoria[0, 2];
            edad2do.Text = memoria[1, 2];
            edad3ro.Text = memoria[2, 2];
            edad4to.Text = memoria[3, 2];
            edad5to.Text = memoria[4, 2];

            movimientos1ro.Text = memoria[0, 3];
            movimientos2do.Text = memoria[1, 3];
            movimientos3ro.Text = memoria[2, 3];
            movimientos4to.Text = memoria[3, 3];
            movimientos5to.Text = memoria[4, 3];

            tiempo1ro.Text = memoria[0, 4];
            tiempo2do.Text = memoria[1, 4];
            tiempo3ro.Text = memoria[2, 4];
            tiempo4to.Text = memoria[3, 4];
            tiempo5to.Text = memoria[4, 4];

        }

        private void bTerminar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bNuevaP_Click(object sender, EventArgs e)
        {
            Registro nuevPart = new Registro(memoria);
            nuevPart.Show();
            this.Hide();
        }
    }
}
