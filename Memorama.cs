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
            
        }
    }
}
