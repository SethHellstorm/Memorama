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
        string[,] memoriaInicial = new string[5, 5]; //

        public Bienvenida()
        {
            InitializeComponent();
        }

        private void bIniciar_Click(object sender, EventArgs e)
        {
            memoriaInicial[0, 0] = "Rafael";
            memoriaInicial[0, 1] = "Seth";
            memoriaInicial[0, 2] = "29";
            memoriaInicial[0, 3] = "85";
            memoriaInicial[0, 4] = "00:15:31";

            memoriaInicial[1, 0] = "";
            memoriaInicial[1, 1] = "";
            memoriaInicial[1, 2] = "";
            memoriaInicial[1, 3] = "";
            memoriaInicial[1, 4] = "22:58:58";

            memoriaInicial[2, 0] = "";
            memoriaInicial[2, 1] = "";
            memoriaInicial[2, 2] = "";
            memoriaInicial[2, 3] = "";
            memoriaInicial[2, 4] = "22:58:58";

            memoriaInicial[3, 0] = "";
            memoriaInicial[3, 1] = "";
            memoriaInicial[3, 2] = "";
            memoriaInicial[3, 3] = "";
            memoriaInicial[3, 4] = "22:58:58";

            memoriaInicial[4, 0] = "";
            memoriaInicial[4, 1] = "";
            memoriaInicial[4, 2] = "";
            memoriaInicial[4, 3] = "";
            memoriaInicial[4, 4] = "22:58:58";

            regis = new Registro(memoriaInicial);
            regis.Show();
            this.Hide();
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
        }
    }
}
