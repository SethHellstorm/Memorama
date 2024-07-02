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
        string[] informacion; // Arreglo donde guardaremos toda la información de la partida
        string[,] memoria; // Arreglo multidimensional donde guardaremos la información de todas las partidas
        public Tablero_de_lideres(string[,] memo, string[] info1, string[] info2)
        { // Funcion de inicializacion, que toma como argumento el arreglo de memoria, y las dos arreglos de informacion
            InitializeComponent(); // Iniciamos los componente
            memoria = memo; //Pasamos la variable de argumento una variable global
            informacion = info1.Concat(info2).ToArray(); // Concatenamos los dos arreglos de información en uno solo
        }

        private void Tablero_de_lideres_Load(object sender, EventArgs e)
        { // Función de carga de la ventana
            TimeSpan a = TimeSpan.Parse(informacion[4]); //Transformamos lo que esta en la quinta posición, donde guardamos el tiempo
            TimeSpan b = TimeSpan.Parse(memoria[4, 4]); //Transformamos lo que esta en la quinta posición, donde guardamos el tiempo, del último lugar
            if (a < b)
            { //Comparamos si el tiempo es menor
                memoria[4, 0] = informacion[0]; // Reemplazamos la información del último lugar con la partida ganada
                memoria[4, 1] = informacion[1]; // Reemplazamos la información del último lugar con la partida ganada
                memoria[4, 2] = informacion[2]; // Reemplazamos la información del último lugar con la partida ganada
                memoria[4, 3] = informacion[3]; // Reemplazamos la información del último lugar con la partida ganada
                memoria[4, 4] = informacion[4]; // Reemplazamos la información del último lugar con la partida ganada
            }
            ordenarMemoria(memoria, 4); //Llamamos a la función para ordenar la memoria
            rellenarTablero(); //Llamamos a la función para rellenar los labels
        }

        private void ordenarMemoria(string[,] array, int columnIndex)
        {// Función para ordenar la información del arreglo
            int rows = array.GetLength(0); // Tomamos el tamaño para ordenar
            int cols = array.GetLength(1); // Tomamos el tamaño para ordenar

            string[][] arrayList = new string[rows][]; //Declaramos un arreglo para convertir el arreglo multidimensional en una unidimensional y poder ordenar
            for (int i = 0; i < rows; i++)
            { // Hasta llegar a la cantidad de filas
                arrayList[i] = new string[cols]; //Declaramos la lista para ser tan grande como las columnas
                for (int j = 0; j < cols; j++)
                { // Hasta llegar hasta las columnas
                    arrayList[i][j] = array[i, j]; //Construimos el arreglo
                }
            }

            Array.Sort(arrayList, (a, b) =>
            { //Teniendo el arreglo y las variables las ordenamos
                TimeSpan timeA = TimeSpan.Parse(a[columnIndex]); //Transformamos lo que esté en la quinta columna a timespan
                TimeSpan timeB = TimeSpan.Parse(b[columnIndex]); //Transformamos lo que esté en la quinta columna a timespan
                return timeA.CompareTo(timeB); //Regresamos la comparación del primer tiempo con el segundo tiempo
            });

            for (int i = 0; i < rows; i++)
            {  // Hasta que lleguemos a la cantidad de filas
                for (int j = 0; j < cols; j++)
                { // Hasta que lleguemos a la cantidad de columnas
                    array[i, j] = arrayList[i][j]; //Reconstruimos el arreglo multidimensional
                }
            }
        }

        private void rellenarTablero()
        { // Función para rellenar los labels con la información de la memoria
            nombre1ro.Text = memoria[0, 0]; //Vaciamos los nombres
            nombre2do.Text = memoria[1, 0]; //Vaciamos los nombres
            nombre3ro.Text = memoria[2, 0]; //Vaciamos los nombres
            nombre4to.Text = memoria[3, 0]; //Vaciamos los nombres
            nombre5to.Text = memoria[4, 0]; //Vaciamos los nombres

            nickname1ro.Text = memoria[0, 1]; //Vaciamos los nicknames
            nickname2do.Text = memoria[1, 1]; //Vaciamos los nicknames
            nickname3ro.Text = memoria[2, 1]; //Vaciamos los nicknames
            nickname4to.Text = memoria[3, 1]; //Vaciamos los nicknames
            nickname5to.Text = memoria[4, 1]; //Vaciamos los nicknames

            edad1ro.Text = memoria[0, 2]; //Vaciamos las edades
            edad2do.Text = memoria[1, 2]; //Vaciamos las edades
            edad3ro.Text = memoria[2, 2]; //Vaciamos las edades
            edad4to.Text = memoria[3, 2]; //Vaciamos las edades
            edad5to.Text = memoria[4, 2]; //Vaciamos las edades

            movimientos1ro.Text = memoria[0, 3]; //Vaciamos el número de movimientos
            movimientos2do.Text = memoria[1, 3]; //Vaciamos el número de movimientos
            movimientos3ro.Text = memoria[2, 3]; //Vaciamos el número de movimientos
            movimientos4to.Text = memoria[3, 3]; //Vaciamos el número de movimientos
            movimientos5to.Text = memoria[4, 3]; //Vaciamos el número de movimientos

            tiempo1ro.Text = memoria[0, 4]; //Vaciamos los tiempos
            tiempo2do.Text = memoria[1, 4]; //Vaciamos los tiempos
            tiempo3ro.Text = memoria[2, 4]; //Vaciamos los tiempos
            tiempo4to.Text = memoria[3, 4]; //Vaciamos los tiempos
            tiempo5to.Text = memoria[4, 4]; //Vaciamos los tiempos

        }
        private void bTerminar_Click(object sender, EventArgs e)
        { //Evento para cerrar la aplicación
            Application.Exit(); //Damos la orden de cerrar la aplicación
        }
        private void bNuevaP_Click(object sender, EventArgs e)
        { // Funcion para el botón de nueva partida
            Registro nuevPart = new Registro(memoria); //Instanciamos, inicializamos la ventana de registro, y damos como argumento la memoria actual
            nuevPart.Show(); //Mostramos la nueva ventana
            this.Hide(); //Ocultamos esta ventana
        }
    }
}
