using System.IO;
using System.Reflection;
using System.Windows.Forms;
namespace Memorama
{
    public partial class Registro : Form
    {
        private static string[] info = new string[3];        
        Memorama mem;
        public Registro()
        {
            InitializeComponent();
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
            mem = new Memorama(this, info);
            mem.Show();
            this.Hide();

        }

        private void Registro_Load(object sender, EventArgs e)
        {
        }
    }
}
