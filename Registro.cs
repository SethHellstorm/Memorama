using System.IO;
using System.Reflection;
using System.Windows.Forms;
namespace Memorama
{
    public partial class Registro : Form
    {
        private static string[] info = new string[3]; //Instanciamos e inicializamos el arreglo info el cual guardará nombre, nickname y edad del participante
        string[,] memo; //Instanciamos el arreglo memo para en este guardar lo que se nos pase de memoria
        Memorama mem; //Instanciamos la siguiente ventana
        public Registro(string[,] memoria)
        {//Recibimos como argumento el arreglo multidimensional de memoria
            InitializeComponent(); // Inicializamos los componentes
            memo = memoria; // Pasamos lo que recibimos al arreglo local
        }
        private void button1_Click(object sender, EventArgs e)
        {// Evento click para el botón salir
            Application.Exit(); // Damos para que la aplicación se cierre completamente
        }
        private void botonIniciar_Click(object sender, EventArgs e)
        {// Evento click para el boton iniciar
            info[0] = textoNombre.Text; //Capturamos el nombre al arreglo
            info[1] = textoNickname.Text;//Capturamos el nickname al arreglo
            info[2] = textoEdad.Text;//Capturamos la edad al arreglo
            mem = new Memorama(this, memo, info);//Inicializamos la siguiente ventana y pasamos como argumento, la instancia de esta ventana, la memoria y la información capturada
            mem.Show();// Mostramos la siguiente ventana
            this.Hide();// Ocultamos esta ventana
        }
        private void Registro_Load(object sender, EventArgs e)
        {
        }
    }
}

