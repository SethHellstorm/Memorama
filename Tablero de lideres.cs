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
        string[] informacion, informacion2;
        string[,] memoria;
        public Tablero_de_lideres(string[,] memo, string[] info1, string[]info2)
        {
            InitializeComponent();
            memoria= memo;
            informacion = info1;
            informacion2 = info2;
        }
    }
}
