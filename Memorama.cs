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
    public partial class Memorama : Form
    {
        private string[] info;
        Registro inicio;

        public Memorama(Registro ini, string[] inf)
        {
            InitializeComponent();
            info = inf;
            inicio = ini;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            inicio.Show();
            this.Close();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            b1.Image = Image.FromFile("D:\\Codigos\\Memorama\\Memorama\\imagenes\\t1.jpg");
            b1.AutoSize = true;
        }

        private void testing_Click(object sender, EventArgs e)
        {
            b1.Image = null;
            b1.AutoSize = false;
        }
    }
}
