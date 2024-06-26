using Memorama.Properties;
using Microsoft.VisualBasic.ApplicationServices;
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
        private System.Windows.Forms.Timer cronometro;
        private TimeSpan tiempoTranscurrido;
        private DateTime horaInicio;
        private bool corriendo;
        private string[] info;
        Registro inicio;

        private void InicializarCronometro()
        {
            tiempoTranscurrido = TimeSpan.Zero;
            cronometro = new System.Windows.Forms.Timer();
            cronometro.Interval = 1000; // Intervalo de 1 segundo
            cronometro.Tick += Cronometro_Tick;
        }
        private void Cronometro_Tick(object sender, EventArgs e)
        {
            tiempoTranscurrido = DateTime.Now - horaInicio;
            contadorTiempo.Text = tiempoTranscurrido.ToString(@"hh\:mm\:ss");
        }
        public Memorama(Registro ini, string[] inf)
        {
            InitializeComponent();
            InicializarCronometro();
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
            b1.Text = null;
            b1.Image = Image.FromFile("C:\\Users\\Caoz0\\source\\repos\\Memorama\\Resources\\Risu.jpg");
            b1.AutoSize = true;
        }

        private void testing_Click(object sender, EventArgs e)
        {
            b1.Image = null;
            b2.Image = null;
            b3.Image = null;
            b4.Image = null;
            b5.Image = null;
            b6.Image = null;
            b7.Image = null;
            b8.Image = null;
            b9.Image = null;
            b10.Image = null;
            b11.Image = null;
            b12.Image = null;
            b13.Image = null;
            b14.Image = null;
            b15.Image = null;
            b16.Image = null;
            b17.Image = null;
            b18.Image = null;
            b19.Image = null;
            b20.Image = null;

            b1.AutoSize = false;
            b2.AutoSize = false;
            b3.AutoSize = false;
            b4.AutoSize = false;
            b5.AutoSize = false;
            b6.AutoSize = false;
            b7.AutoSize = false;
            b8.AutoSize = false;
            b9.AutoSize = false;
            b10.AutoSize = false;
            b11.AutoSize = false;
            b12.AutoSize = false;
            b13.AutoSize = false;
            b14.AutoSize = false;
            b15.AutoSize = false;
            b16.AutoSize = false;
            b17.AutoSize = false;
            b18.AutoSize = false;
            b19.AutoSize = false;
            b20.AutoSize = false;

        }

        private void Memorama_Load(object sender, EventArgs e)
        {
            horaInicio = DateTime.Now - tiempoTranscurrido;
            cronometro.Start();
            corriendo = true;
        }

        private void b15_Click(object sender, EventArgs e)
        {
            b15.Text = null;
            b15.Image = Image.FromFile("C:\\Users\\Caoz0\\source\\repos\\Memorama\\Resources\\Bae.jpg");
            b15.AutoSize = true;
        }

        private void b10_Click(object sender, EventArgs e)
        {
            b10.Text = null;
            b10.Image = Image.FromFile("C:\\Users\\Caoz0\\source\\repos\\Memorama\\Resources\\Sora.jpg");
            b10.AutoSize = true;
        }

        private void b11_Click(object sender, EventArgs e)
        {
            b11.Text = null;
            b11.Image = Image.FromFile("D:\\Codigos\\Memorama\\Memorama\\Resources\\Aki.jpg");
            b11.AutoSize = true;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            b5.Text = null;
            b5.Image = Image.FromFile("D:\\Codigos\\Memorama\\Memorama\\Resources\\Aki.jpg");
            b5.AutoSize = true;
        }

        private void b13_Click(object sender, EventArgs e)
        {
            b13.Text = null;
            b13.Image = Image.FromFile("C:\\Users\\Caoz0\\source\\repos\\Memorama\\Resources\\AZKi.jpg");
            b13.AutoSize = true;
        }

        private void b12_Click(object sender, EventArgs e)
        {
            b12.Text = null;
            b12.Image = Image.FromFile("C:\\Users\\Caoz0\\source\\repos\\Memorama\\Resources\\AZKi.jpg");
            b12.AutoSize = true;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            b2.Text = null;
            b2.Image = Image.FromFile("C:\\Users\\Caoz0\\source\\repos\\Memorama\\Resources\\Bae.jpg");
            b2.AutoSize = true;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            b4.Text = null;
            b4.Image = Image.FromFile("C:\\Users\\Caoz0\\source\\repos\\Memorama\\Resources\\Calli.jpg");
            b4.AutoSize = true;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            b6.Text = null;
            b6.Image = Image.FromFile("C:\\Users\\Caoz0\\source\\repos\\Memorama\\Resources\\Calli.jpg");
            b6.AutoSize = true;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            b8.Text = null;
            b8.Image = Image.FromFile("C:\\Users\\Caoz0\\source\\repos\\Memorama\\Resources\\IRyS.jpg");
            b8.AutoSize = true;
        }

        private void b16_Click(object sender, EventArgs e)
        {
            b16.Text = null;
            b16.Image = Image.FromFile("C:\\Users\\Caoz0\\source\\repos\\Memorama\\Resources\\IRyS.jpg");
            b16.AutoSize = true;
        }

        private void b19_Click(object sender, EventArgs e)
        {
            b19.Text = null;
            b19.Image = Image.FromFile("C:\\Users\\Caoz0\\source\\repos\\Memorama\\Resources\\Kiara.jpg");
            b19.AutoSize = true;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            b7.Text = null;
            b7.Image = Image.FromFile("C:\\Users\\Caoz0\\source\\repos\\Memorama\\Resources\\Kiara.jpg");
            b7.AutoSize = true;
        }

        private void b18_Click(object sender, EventArgs e)
        {
            b18.Text = null;
            b18.Image = Image.FromFile("C:\\Users\\Caoz0\\source\\repos\\Memorama\\Resources\\Korone.jpg");
            b18.AutoSize = true;
        }

        private void b17_Click(object sender, EventArgs e)
        {
            b17.Text = null;
            b17.Image = Image.FromFile("C:\\Users\\Caoz0\\source\\repos\\Memorama\\Resources\\Korone.jpg");
            b17.AutoSize = true;
        }

        private void b14_Click(object sender, EventArgs e)
        {
            b14.Text = null;
            b14.Image = Image.FromFile("C:\\Users\\Caoz0\\source\\repos\\Memorama\\Resources\\Ollie.jpg");
            b14.AutoSize = true;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            b3.Text = null;
            b3.Image = Image.FromFile("C:\\Users\\Caoz0\\source\\repos\\Memorama\\Resources\\Ollie.jpg");
            b3.AutoSize = true;
        }

        private void b20_Click(object sender, EventArgs e)
        {
            b20.Text = null;
            b20.Image = Image.FromFile("C:\\Users\\Caoz0\\source\\repos\\Memorama\\Resources\\Risu.jpg");
            b20.AutoSize = true;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            b9.Text = null;
            b9.Image = Image.FromFile("C:\\Users\\Caoz0\\source\\repos\\Memorama\\Resources\\Sora.jpg");
            b9.AutoSize = true;
        }

        

        private void botonPausar_Click(object sender, EventArgs e)
        {
            if (!corriendo)
            {
                horaInicio = DateTime.Now - tiempoTranscurrido;
                cronometro.Start();
                corriendo = true;
            } else if (corriendo)
            {
                cronometro.Stop();
                corriendo = false;
            }
        }
    }
}
