using Memorama.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
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
        private int[] par = new int[2];
        private static int conteoSeleccionado = 0, parResuleto = 0;
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

        public void revPar(int a)
        {
            par[conteoSeleccionado] = a;
            conteoSeleccionado++;
            if (conteoSeleccionado == 2)
            {
                parConteo(par);
            }

        }

        public void parConteo(int[] a)
        {
            int p1 = a[0], p2 = a[1];
            switch ((p1, p2))
            {
                case (10, 9):
                    parResuleto++;
                    break;
                case (9, 10):
                    parResuleto++;
                    break;
                case (11, 5):
                    parResuleto++;
                    break;
                case (5, 11):
                    parResuleto++;
                    break;
                case (13, 12):
                    parResuleto++;
                    break;
                case (12, 13):
                    parResuleto++;
                    break;
                case (2, 15):
                    parResuleto++;
                    break;
                case (15, 2):
                    parResuleto++;
                    break;
                case (4, 6):
                    parResuleto++;
                    break;
                case (6, 4):
                    parResuleto++;
                    break;
                case (8, 16):
                    parResuleto++;
                    break;
                case (16, 8):
                    parResuleto++;
                    break;
                case (19, 7):
                    parResuleto++;
                    break;
                case (7, 19):
                    parResuleto++;
                    break;
                case (17, 18):
                    parResuleto++;
                    break;
                case (18, 17):
                    parResuleto++;
                    break;
                case (14, 3):
                    parResuleto++;
                    break;
                case (3, 14):
                    parResuleto++;
                    break;
                case (20, 1):
                    parResuleto++;
                    break;
                case (1, 20):
                    parResuleto++;
                    break;
                default:
                    reinicioBotones(a);
                    break;
            }
            ganar(parResuleto);
        }

        private void ganar(int a)
        {

        }
        private void reinicioBotones(int[] a)
        {
            switch (a[0])
            {
                case 1:
                    b1.Image = null;
                    b1.Text = "1";
                    b1.AutoSize = false;
                    b1.Enabled = true;
                    break;
                case 2:
                    b2.Image = null;
                    b2.Text = "2";
                    b2.AutoSize = false;
                    b2.Enabled = true;
                    break;
                case 3:
                    b3.Image = null;
                    b3.Text = "3";
                    b3.AutoSize = false;
                    b3.Enabled = true;
                    break;
                case 4:
                    b4.Image = null;
                    b4.Text = "4";
                    b4.AutoSize = false;
                    b4.Enabled = true;
                    break;
                case 5:
                    b5.Image = null;
                    b5.Text = "5";
                    b5.AutoSize = false;
                    b5.Enabled = true;
                    break;
                case 6:
                    b6.Image = null;
                    b6.Text = "6";
                    b6.AutoSize = false;
                    b6.Enabled = true;
                    break;
                case 7:
                    b7.Image = null;
                    b7.Text = "7";
                    b7.AutoSize = false;
                    b7.Enabled = true;
                    break;
                case 8:
                    b8.Image = null;
                    b8.Text = "8";
                    b8.AutoSize = false; 
                    b8.Enabled = true;
                    break;
                case 9:
                    b9.Image = null;
                    b9.Text = "9";
                    b9.AutoSize = false; 
                    b9.Enabled = true;
                    break;
                case 10:
                    b10.Image = null;
                    b10.Text = "10";
                    b10.AutoSize = false;
                    b10.Enabled = true;
                    break;
                case 11:
                    b11.Image = null;
                    b11.Text = "11";
                    b11.AutoSize = false;
                    b11.Enabled = true;
                    break;
                case 12:
                    b12.Image = null;
                    b12.Text = "12"; 
                    b12.AutoSize = false;
                    b12.Enabled = true; 
                    break;
                case 13:
                    b13.Image = null;
                    b13.Text = "13";
                    b13.AutoSize = false; 
                    b13.Enabled = true;
                    break;
                case 14:
                    b14.Image = null;
                    b14.Text = "14";
                    b14.AutoSize = false;
                    b14.Enabled = true;
                    break;
                case 15:
                    b15.Image = null;
                    b15.Text = "15";
                    b15.AutoSize = false;
                    b15.Enabled = true;
                    break;
                case 16:
                    b16.Image = null;
                    b16.Text = "16";
                    b16.AutoSize = false;
                    b16.Enabled = true;
                    break;
                case 17:
                    b17.Image = null;
                    b17.Text = "17";
                    b17.AutoSize = false;
                    b17.Enabled = true;
                    break;
                case 18:
                    b18.Image = null;
                    b18.Text = "18";
                    b18.AutoSize = false;
                    b18.Enabled = true;
                    break;
                case 19:
                    b19.Image = null;
                    b19.Text = "19";
                    b19.AutoSize = false;
                    b19.Enabled = true;
                    break;
                case 20:
                    b20.Image = null;
                    b20.Text = "15";
                    b20.AutoSize = false;
                    b20.Enabled = true;
                    break;
                default:
                    Console.WriteLine("Error critico");
                    break;
            }
            switch (a[1])
            {
                case 1:
                    b1.Image = null;
                    b1.Text = "1";
                    b1.AutoSize = false;
                    b1.Enabled = true;
                    break;
                case 2:
                    b2.Image = null;
                    b2.Text = "2";
                    b2.AutoSize = false;
                    b2.Enabled = true;
                    break;
                case 3:
                    b3.Image = null;
                    b3.Text = "3";
                    b3.AutoSize = false;
                    b3.Enabled = true;
                    break;
                case 4:
                    b4.Image = null;
                    b4.Text = "4";
                    b4.AutoSize = false;
                    b4.Enabled = true;
                    break;
                case 5:
                    b5.Image = null;
                    b5.Text = "5";
                    b5.AutoSize = false;
                    b5.Enabled = true;
                    break;
                case 6:
                    b6.Image = null;
                    b6.Text = "6";
                    b6.AutoSize = false;
                    b6.Enabled = true;
                    break;
                case 7:
                    b7.Image = null;
                    b7.Text = "7";
                    b7.AutoSize = false;
                    b7.Enabled = true;
                    break;
                case 8:
                    b8.Image = null;
                    b8.Text = "8";
                    b8.AutoSize = false;
                    b8.Enabled = true;
                    break;
                case 9:
                    b9.Image = null;
                    b9.Text = "9";
                    b9.AutoSize = false;
                    b9.Enabled = true;
                    break;
                case 10:
                    b10.Image = null;
                    b10.Text = "10";
                    b10.AutoSize = false;
                    b10.Enabled = true;
                    break;
                case 11:
                    b11.Image = null;
                    b11.Text = "11";
                    b11.AutoSize = false;
                    b11.Enabled = true;
                    break;
                case 12:
                    b12.Image = null;
                    b12.Text = "12";
                    b12.AutoSize = false;
                    b12.Enabled = true;
                    break;
                case 13:
                    b13.Image = null;
                    b13.Text = "13";
                    b13.AutoSize = false;
                    b13.Enabled = true;
                    break;
                case 14:
                    b14.Image = null;
                    b14.Text = "14";
                    b14.AutoSize = false;
                    b14.Enabled = true;
                    break;
                case 15:
                    b15.Image = null;
                    b15.Text = "15";
                    b15.AutoSize = false;
                    b15.Enabled = true;
                    break;
                case 16:
                    b16.Image = null;
                    b16.Text = "16";
                    b16.AutoSize = false;
                    b16.Enabled = true;
                    break;
                case 17:
                    b17.Image = null;
                    b17.Text = "17";
                    b17.AutoSize = false;
                    b17.Enabled = true;
                    break;
                case 18:
                    b18.Image = null;
                    b18.Text = "18";
                    b18.AutoSize = false;
                    b18.Enabled = true;
                    break;
                case 19:
                    b19.Image = null;
                    b19.Text = "19";
                    b19.AutoSize = false;
                    b19.Enabled = true;
                    break;
                case 20:
                    b20.Image = null;
                    b20.Text = "15";
                    b20.AutoSize = false;
                    b20.Enabled = true;
                    break;
                default:
                    Console.WriteLine("Error critico");
                    break;
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            inicio.Show();
            this.Close();
        }

       

        private void recolor(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && !btn.Enabled)
            {
                // Dibujar la imagen manualmente
                if (btn.Image != null)
                {
                    // Centrar la imagen en el botón
                    int x = (btn.Width - btn.Image.Width) / 2;
                    int y = (btn.Height - btn.Image.Height) / 2;
                    e.Graphics.DrawImage(btn.Image, x, y, btn.Image.Width, btn.Image.Height);
                }

                // Dibujar el texto manualmente
                TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, btn.ClientRectangle, btn.ForeColor);
            }
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

            b1.Text = "1";
            b2.Text = "2";
            b3.Text = "3";
            b4.Text = "4";
            b5.Text = "5";
            b6.Text = "6";
            b7.Text = "7";
            b8.Text = "8";
            b9.Text = "9";
            b10.Text = "10";
            b11.Text = "11";
            b12.Text = "12";
            b13.Text = "13";
            b14.Text = "14";
            b15.Text = "15";
            b16.Text = "16";
            b17.Text = "17";
            b18.Text = "18";
            b19.Text = "19";
            b20.Text = "20";

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

            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;               
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;
            b10.Enabled = true;
            b11.Enabled = true;
            b12.Enabled = true;
            b13.Enabled = true;
            b14.Enabled = true;
            b15.Enabled = true;
            b16.Enabled = true;
            b17.Enabled = true;
            b18.Enabled = true;
            b19.Enabled = true;
            b20.Enabled = true;
        }

        private void Memorama_Load(object sender, EventArgs e)
        {
            horaInicio = DateTime.Now - tiempoTranscurrido;
            cronometro.Start();
            corriendo = true;
        }

        

        private void b10_Click(object sender, EventArgs e)
        {
            b10.Text = null;
            b10.Image = Properties.Resources.Sora;
            b10.AutoSize = true;
            b10.Enabled = false;
            b10.Paint += new PaintEventHandler(recolor);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            b9.Text = null;
            b9.Image = Properties.Resources.Sora;
            b9.AutoSize = true;
            b9.Enabled = false;
            b9.Paint += new PaintEventHandler(recolor);
        }

        private void b11_Click(object sender, EventArgs e)
        {
            b11.Text = null;
            b11.Image = Properties.Resources.Aki;
            b11.AutoSize = true;
            b11.Enabled = false;
            b11.Paint += new PaintEventHandler(recolor);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            b5.Text = null;
            b5.Image = Properties.Resources.Aki;
            b5.AutoSize = true;
            b5.Enabled = false;
            b5.Paint += new PaintEventHandler(recolor);
        }

        private void b13_Click(object sender, EventArgs e)
        {
            b13.Text = null;
            b13.Image = Properties.Resources.AZKi;
            b13.AutoSize = true;
            b13.Enabled = false;
            b13.Paint += new PaintEventHandler(recolor);
        }

        private void b12_Click(object sender, EventArgs e)
        {
            b12.Text = null;
            b12.Image = Properties.Resources.AZKi;
            b12.AutoSize = true;
            b12.Enabled = false;
            b12.Paint += new PaintEventHandler(recolor);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            b2.Text = null;
            b2.Image = Properties.Resources.Bae;
            b2.AutoSize = true;
            b2.Enabled = false;
            b2.Paint += new PaintEventHandler(recolor);
        }
        private void b15_Click(object sender, EventArgs e)
        {
            b15.Text = null;
            b15.Image = Properties.Resources.Bae;
            b15.AutoSize = true;
            b15.Enabled = false;
            b15.Paint += new PaintEventHandler(recolor);
        }
        private void b4_Click(object sender, EventArgs e)
        {
            b4.Text = null;
            b4.Image = Properties.Resources.Calli;
            b4.AutoSize = true;
            b4.Enabled = false;
            b4.Paint += new PaintEventHandler(recolor);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            b6.Text = null;
            b6.Image = Properties.Resources.Calli;
            b6.AutoSize = true;
            b6.Enabled = false;
            b6.Paint += new PaintEventHandler(recolor);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            b8.Text = null;
            b8.Image = Properties.Resources.IRyS;
            b8.AutoSize = true;
            b8.Enabled = false;
            b8.Paint += new PaintEventHandler(recolor);
        }

        private void b16_Click(object sender, EventArgs e)
        {
            b16.Text = null;
            b16.Image = Properties.Resources.IRyS;
            b16.AutoSize = true;
            b16.Enabled = false;
            b16.Paint += new PaintEventHandler(recolor);
        }

        private void b19_Click(object sender, EventArgs e)
        {
            b19.Text = null;
            b19.Image = Properties.Resources.Kiara;
            b19.AutoSize = true;
            b19.Enabled = false;
            b19.Paint += new PaintEventHandler(recolor);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            b7.Text = null;
            b7.Image = Properties.Resources.Kiara;
            b7.AutoSize = true;
            b7.Enabled = false;
            b7.Paint += new PaintEventHandler(recolor);
        }

        private void b18_Click(object sender, EventArgs e)
        {
            b18.Text = null;
            b18.Image = Properties.Resources.Korone;
            b18.AutoSize = true;
            b18.Enabled = false;
            b18.Paint += new PaintEventHandler(recolor);
        }

        private void b17_Click(object sender, EventArgs e)
        {
            b17.Text = null;
            b17.Image = Properties.Resources.Korone;
            b17.AutoSize = true;
            b17.Enabled = false;
            b17.Paint += new PaintEventHandler(recolor);
        }

        private void b14_Click(object sender, EventArgs e)
        {
            b14.Text = null;
            b14.Image = Properties.Resources.Ollie;
            b14.AutoSize = true;
            b14.Enabled = false;
            b14.Paint += new PaintEventHandler(recolor);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            b3.Text = null;
            b3.Image = Properties.Resources.Ollie;
            b3.AutoSize = true;
            b3.Enabled = false;
            b3.Paint += new PaintEventHandler(recolor);
        }

        private void b20_Click(object sender, EventArgs e)
        {
            b20.Text = null;
            b20.Image = Properties.Resources.Risu;
            b20.AutoSize = true;
            b20.Enabled = false;
            b20.Paint += new PaintEventHandler(recolor);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            b1.Text = null;
            b1.Image = Properties.Resources.Risu;
            b1.TextImageRelation = TextImageRelation.ImageAboveText;
            b1.AutoSize = true;
            b1.Enabled = false;
            b1.Paint += new PaintEventHandler(recolor);
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
