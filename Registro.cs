using System.IO;
using System.Reflection;
using System.Windows.Forms;
namespace Memorama
{
    public partial class Registro : Form
    {
        private static string[] info = new string[3];
        string[,] memo;
        Memorama mem;
        public Registro(string[,] memoria)
        {
            InitializeComponent();
            memo = memoria;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonIniciar_Click(object sender, EventArgs e)
        {
            info[0] = textoNombre.Text;
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
