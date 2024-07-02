using System.IO;
using System.Reflection;
using System.Windows.Forms;
namespace Memorama
{
    public partial class Registro : Form
    {
        private static string[] info = new string[3]; //Instanciamos e inicializamos el arreglo info el cual guardara nombre, nickname y edad del participante
        string[,] memo; //Instanciamos el arreglo memo para en este guardar lo que se nos pase de memoria
        Memorama mem; //Instanciamos la siguiente ventana
        public Registro(string[,] memoria)
        {//Recivimos como argumento el arreglo multidimensional de memoria
            InitializeComponent(); // Inicializamos los componentes
            memo = memoria; // Pasamos lo que recibimos al arreglo local
        }

        private void button1_Click(object sender, EventArgs e)
        {// Evento click para el boton salir
            Application.Exit(); // Damos para que la aplicacion se cierre completamente
        }

        private void botonIniciar_Click(object sender, EventArgs e)
        {// Evento click para el boton inciar
            info[0] = textoNombre.Text; //
            info[1] = textoNickname.Text;
            info[2] = textoEdad.Text;
            mem = new Memorama(this, memo,info);
            mem.Show();
            this.Hide();

        }
        

        private void Registro_Load(object sender, EventArgs e)
        {
        }
    }
}
