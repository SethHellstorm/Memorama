namespace Memorama
{
    public partial class Registro : Form
    {
        private static string[] info = new string[3];
        
        private static string basePath = Application.StartupPath;
        private static string relativePath = "Memorama\\Resources\\Aki.jpg";
        private static string fullPath = Path.Combine(basePath, relativePath);
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
            MessageBox.Show(basePath);
            /*
            if (File.Exists(fullPath))
            {
                // Realiza operaciones con el archivo
                string fileContents = File.ReadAllText(fullPath);
                MessageBox.Show(fileContents);
            }
            else
            {
                MessageBox.Show("El archivo no se encontró en la ruta especificada.");
            }
            */
        }
    }
}
