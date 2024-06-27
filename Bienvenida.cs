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
        Registro regis;
        string[] memoriVacia;
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void bIniciar_Click(object sender, EventArgs e)
        {
            regis = new Registro(memoriVacia);
            regis.Show();
            this.Hide();
        }
    }
}
