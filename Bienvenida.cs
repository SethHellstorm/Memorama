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
    public partial class Bienvenida : Form
    {
        Registro regis; //Crea la instancia de la siguiente ventana
        string[,] memoriaInicial = new string[5, 5]; //Instaciamos e inicializamos el arreglo de 5 por 5 el cual contendra los puntuajes mas altos.

        public Bienvenida()
        {
            InitializeComponent(); // Inicializamos los componentes de la ventana
        }

        private void bIniciar_Click(object sender, EventArgs e)
        { //Funcion de lcik para el boton de iniciar
            memoriaInicial[0, 0] = "Rafael"; //Rellenamos el arreglo con la informacion base, damos nombre
            memoriaInicial[0, 1] = "Seth"; // Damos nickname
            memoriaInicial[0, 2] = "29"; // Damos edad
            memoriaInicial[0, 3] = "85"; //Damos movimientos
            memoriaInicial[0, 4] = "00:15:31"; // Damos tiempo en el formate Horas:Minutos:Segundos

            memoriaInicial[1, 0] = ""; // Damos nombre
            memoriaInicial[1, 1] = ""; // Damos nickname
            memoriaInicial[1, 2] = ""; // Damos edad
            memoriaInicial[1, 3] = ""; //Damos movimientos
            memoriaInicial[1, 4] = "22:58:58"; // Damos tiempo en el formate Horas:Minutos:Segundos

            memoriaInicial[2, 0] = ""; // Damos nombre
            memoriaInicial[2, 1] = ""; // Damos nickname
            memoriaInicial[2, 2] = ""; // Damos edad
            memoriaInicial[2, 3] = ""; //Damos movimientos
            memoriaInicial[2, 4] = "22:58:58"; // Damos tiempo en el formate Horas:Minutos:Segundos

            memoriaInicial[3, 0] = ""; // Damos nombre
            memoriaInicial[3, 1] = ""; // Damos nickname
            memoriaInicial[3, 2] = ""; // Damos edad
            memoriaInicial[3, 3] = ""; //Damos movimientos
            memoriaInicial[3, 4] = "22:58:58"; // Damos tiempo en el formate Horas:Minutos:Segundos

            memoriaInicial[4, 0] = ""; // Damos nombre
            memoriaInicial[4, 1] = ""; // Damos nickname
            memoriaInicial[4, 2] = ""; // Damos edad
            memoriaInicial[4, 3] = ""; //Damos movimientos
            memoriaInicial[4, 4] = "22:58:58"; // Damos tiempo en el formate Horas:Minutos:Segundos

            regis = new Registro(memoriaInicial); //Inicializamos la ventana siguiente y ke damos como argumenta el arreglo de memoria
            regis.Show(); //Mostramos la siguiente ventana
            this.Hide(); //Escondemos esta
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
        }
    }
}
