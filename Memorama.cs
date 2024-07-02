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
        private Tablero_de_lideres tabLid;
        private System.Windows.Forms.Timer cronometro;
        private TimeSpan tiempoTranscurrido;
        private DateTime horaInicio;
        private bool corriendo;
        private string[] info;
        private string[,] memo;
        private int[] par = new int[2];
        private static int conteoSeleccionado = 0, parResuleto = 0,contMovimiento = 0;
        private static int[] Aki = new int[2],AZKi = new int[2], Bae = new int[2], Calli = new int[2],IRyS = new int[2],Kiara = new int[2],Korone = new int[2],Ollie = new int[2],Risu = new int[2],Sora = new int[2];
        private static bool press1, press2, press3, press4,press5, press6, press7, press8, press9, press10, press11, press12, press13, press14, press15, press16, press17, press18, press19, press20;
        private static int[,] lugaresFiguras;
        private string[] info2 = new string[2];
        Registro inicio;

        private Image darImagen(int a)
        {
            if(a == Aki[0] ||  a == Aki[1])
            {
                return Properties.Resources.Aki;
            }
            if (a == AZKi[0] || a == AZKi[1])
            {
                return Properties.Resources.AZKi;
            }
            if (a == Bae[0] || a == Bae[1])
            {
                return Properties.Resources.Bae;
            }
            if (a == Calli[0] || a == Calli[1])
            {
                return Properties.Resources.Calli;
            }
            if (a == IRyS[0] || a == IRyS[1])
            {
                return Properties.Resources.IRyS;
            }
            if (a == Kiara[0] || a == Kiara[1])
            {
                return Properties.Resources.Kiara;
            }
            if (a == Korone[0] || a == Korone[1])
            {
                return Properties.Resources.Korone;
            }
            if (a == Ollie[0] || a == Ollie[1])
            {
                return Properties.Resources.Ollie;
            }
            if (a == Risu[0] || a == Risu[1])
            {
                return Properties.Resources.Risu;
            }
            if (a == Sora[0] || a == Sora[1])
            {
                return Properties.Resources.Sora;
            }
            return null;
        }
        private void generarLugares()
        {
            int[] numeros = new int[20];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i + 1;
            }

            // Barajar el array
            Random rng = new Random();
            int n = numeros.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = numeros[k];
                numeros[k] = numeros[n];
                numeros[n] = value;
            }

            // Crear un array bidimensional de 2x10
            int[,] arregloPosiciones = new int[10, 2];
            for (int i = 0; i < 20; i++)
            {
                arregloPosiciones[ i % 10, i / 10] = numeros[i];
            }

            Aki[0] = arregloPosiciones[0,0];
            Aki[1] = arregloPosiciones[0,1];

            AZKi[0] = arregloPosiciones[1,0];
            AZKi[1] = arregloPosiciones[1,1];

            Bae[0] = arregloPosiciones[2,0];
            Bae[1] = arregloPosiciones [2,1];

            Calli[0] = arregloPosiciones[3,0];
            Calli[1] = arregloPosiciones[3,1];

            IRyS[0] = arregloPosiciones[4,0];
            IRyS[1] = arregloPosiciones[4, 1];

            Kiara[0] = arregloPosiciones[5, 0];
            Kiara[1] = arregloPosiciones[5, 1];

            Korone[0] = arregloPosiciones[6, 0];
            Korone[1] = arregloPosiciones[6, 1];

            Ollie[0] = arregloPosiciones[7, 0];
            Ollie[1] = arregloPosiciones[7, 1];

            Risu[0] = arregloPosiciones[8, 0];
            Risu[1] = arregloPosiciones[8, 1];

            Sora[0] = arregloPosiciones[9, 0];
            Sora[1] = arregloPosiciones[9, 1];

        }
    

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
        public Memorama(Registro ini, string[,] memoria,string[] inf)
        {
            InitializeComponent();
            InicializarCronometro();
            info = inf;
            inicio = ini;
            memo = memoria;
        }

        public void revPar(int a)
        {
            par[conteoSeleccionado] = a;
            conteoSeleccionado++;
            conteoMovimiento.Text = Convert.ToString(contMovimiento/2);
            if (conteoSeleccionado == 2)
            {
                parConteo(par);
                conteoSeleccionado = 0;
            }

        }

        public void parConteo(int[] a)
        {
            int p1 = a[0], p2 = a[1];

            if (p1 == Aki[0] && p2 == Aki[1])
            {
                parResuleto++;
                
            }
            else if (p1 == Aki[1] && p2 == Aki[0])
            {
                parResuleto++;
                
            }
            else if (p1 == AZKi[0] && p2 == AZKi[1])
            {
                parResuleto++;
                
            }
            else if (p1 == AZKi[1] && p2 == AZKi[0])
            {
                parResuleto++;
                
            } else if (p1 == Bae[0] && p2 == Bae[1])
            {
                parResuleto++;
                
            } else if (p1 == Bae[1] && p2 == Bae[0])
            {
                parResuleto++;
                
            } else if (p1 == Calli[0] && p2 == Calli[1])
            {
                parResuleto++;
                
            } else if (p1 == Calli[1] && p2 == Calli[0])
            {
                parResuleto++;
                
            } else if (p1 == IRyS[0] && p2 == IRyS[1])
            {
                parResuleto++;
               
            } else if (p1 == IRyS[1] && p2 == IRyS[0])
            {
                parResuleto++;
                
            } else if (p1 == Kiara[0] && p2 == Kiara[1])
            {
                parResuleto++;
                
            } else if (p1 == Kiara[1] && p2 == Kiara[0])
            {
                parResuleto++;
                
            } else if (p1 == Korone[0] && p2 == Korone[1])
            {
                parResuleto++;
                
            } else if (p1 == Korone[1] && p2 == Korone[0])
            {
                parResuleto++;
                
            } else if (p1 == Ollie[0] && p2 == Ollie[1])
            {
                parResuleto++;
               
            } else if (p1 == Ollie[1] && p2 == Ollie[0])
            {
                parResuleto++;
              
            } else if (p1 == Risu[0] && p2 == Risu[1])
            {
                parResuleto++;
             
            } else if (p1 == Risu[1] && p2 == Risu[0])
            {
                parResuleto++;
               
            } else if (p1 == Sora[0] && p2 == Sora[1])
            {
                parResuleto++;
                
            } else if (p1 == Sora[1] && p2 == Sora[0])
            {
                parResuleto++;
                
            }
            else {
                MessageBox.Show("No son par");
                reinicioBotones(p1);
                reinicioBotones(p2);
            }
                
            
            ganar(parResuleto);
        }

        private void ganar(int a)
        {
            if (a == 10)
            {
                
                cronometro.Stop();
                info2[0] = Convert.ToString(contMovimiento/2);
                info2[1] = Convert.ToString(contadorTiempo.Text);
                string aux = info2[1];
                string[] res = aux.Split(":");
                MessageBox.Show("Ganaste con: " + res[1] + " minutos y " + res[2] + " segundos y " + info2[0] + " movimientos");
                tabLid = new Tablero_de_lideres(memo, info,info2);
                tabLid.Show();
                this.Hide();
            }
        }
        private void reinicioBotones(int a)
        {
            switch (a)
            {
                case 1:
                    b1.Image = Properties.Resources.logo;
                    b1.AutoSize = false;
                    b1.Enabled = true;
                    press1 = false;
                    break;
                case 2:
                    b2.Image = Properties.Resources.logo;
                    b2.AutoSize = false;
                    b2.Enabled = true;
                    press2 = false;
                    break;
                case 3:
                    b3.Image = Properties.Resources.logo;
                    b3.AutoSize = false;
                    b3.Enabled = true;
                    press3 = false;
                    break;
                case 4:
                    b4.Image = Properties.Resources.logo;
                    b4.AutoSize = false;
                    b4.Enabled = true;
                    press4 = false;
                    break;
                case 5:
                    b5.Image = Properties.Resources.logo;
                    b5.AutoSize = false;
                    b5.Enabled = true;
                    press5 = false;
                    break;
                case 6:
                    b6.Image = Properties.Resources.logo;
                    b6.AutoSize = false;
                    b6.Enabled = true;
                    press6 = false;
                    break;
                case 7:
                    b7.Image = Properties.Resources.logo;
                    b7.AutoSize = false;
                    b7.Enabled = true;
                    press7 = false;
                    break;
                case 8:
                    b8.Image = Properties.Resources.logo;
                    b8.AutoSize = false;
                    b8.Enabled = true;
                    press8 = false;
                    break;
                case 9:
                    b9.Image = Properties.Resources.logo;
                    b9.AutoSize = false;
                    b9.Enabled = true;
                    press9 = false;
                    break;
                case 10:
                    b10.Image = Properties.Resources.logo;
                    b10.AutoSize = false;
                    b10.Enabled = true;
                    press10 = false;
                    break;
                case 11:
                    b11.Image = Properties.Resources.logo;
                    b11.AutoSize = false;
                    b11.Enabled = true;
                    press11 = false;
                    break;
                case 12:
                    b12.Image = Properties.Resources.logo;
                    b12.AutoSize = false;
                    b12.Enabled = true;
                    press12 = false;
                    break;
                case 13:
                    b13.Image = Properties.Resources.logo;
                    b13.AutoSize = false;
                    b13.Enabled = true;
                    press13 = false;
                    break;
                case 14:
                    b14.Image = Properties.Resources.logo;
                    b14.AutoSize = false;
                    b14.Enabled = true;
                    press14 = false;
                    break;
                case 15:
                    b15.Image = Properties.Resources.logo;
                    b15.AutoSize = false;
                    b15.Enabled = true;
                    press15 = false;
                    break;
                case 16:
                    b16.Image = Properties.Resources.logo;
                    b16.AutoSize = false;
                    b16.Enabled = true;
                    press16 = false;
                    break;
                case 17:
                    b17.Image = Properties.Resources.logo;
                    b17.AutoSize = false;
                    b17.Enabled = true;
                    press17 = false;
                    break;
                case 18:
                    b18.Image = Properties.Resources.logo;
                    b18.AutoSize = false;
                    b18.Enabled = true;
                    press18 = false;
                    break;
                case 19:
                    b19.Image = Properties.Resources.logo;
                    b19.AutoSize = false;
                    b19.Enabled = true;
                    press19 = false;
                    break;
                case 20:
                    b20.Image = Properties.Resources.logo;
                    b20.AutoSize = false;
                    b20.Enabled = true;
                    press20 = false;
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

        private void reset_Click(object sender, EventArgs e)
        {
            b1.Image = Properties.Resources.logo;
            b2.Image = Properties.Resources.logo;
            b3.Image = Properties.Resources.logo;
            b4.Image = Properties.Resources.logo;
            b5.Image = Properties.Resources.logo;
            b6.Image = Properties.Resources.logo;
            b7.Image = Properties.Resources.logo;
            b8.Image = Properties.Resources.logo;
            b9.Image = Properties.Resources.logo;
            b10.Image = Properties.Resources.logo;
            b11.Image = Properties.Resources.logo;
            b12.Image = Properties.Resources.logo;
            b13.Image = Properties.Resources.logo;
            b14.Image = Properties.Resources.logo;
            b15.Image = Properties.Resources.logo;
            b16.Image = Properties.Resources.logo;
            b17.Image = Properties.Resources.logo;
            b18.Image = Properties.Resources.logo;
            b19.Image = Properties.Resources.logo;
            b20.Image = Properties.Resources.logo;


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
            
            press1 = false;
            press2 = false;
            press3 = false;
            press4 = false;
            press5 = false;
            press6 = false;
            press7 = false;
            press8 = false;
            press9 = false;
            press10 = false;
            press11 = false;
            press12 = false;
            press13 = false;
            press14 = false;
            press15 = false;
            press16 = false;
            press17 = false;
            press18 = false;
            press19 = false;
            press20 = false;

            conteoSeleccionado = 0;

            parResuleto = 0;
            contMovimiento = 0;

            generarLugares();

            cronometro.Stop();
            corriendo = false;
            tiempoTranscurrido = TimeSpan.Zero;
            contadorTiempo.Text = "00:00:00";
            horaInicio = DateTime.Now - tiempoTranscurrido;
            cronometro.Start();
        }

        private void Memorama_Load(object sender, EventArgs e)
        {
            horaInicio = DateTime.Now - tiempoTranscurrido;
            cronometro.Start();
            corriendo = true;
            Nickname.Text = info[1];
            conteoSeleccionado = 0;
            parResuleto = 0;
            contMovimiento = 0;

            b1.Paint += new PaintEventHandler(recolor);
            b2.Paint += new PaintEventHandler(recolor);
            b3.Paint += new PaintEventHandler(recolor);
            b4.Paint += new PaintEventHandler(recolor);
            b5.Paint += new PaintEventHandler(recolor);
            b6.Paint += new PaintEventHandler(recolor);
            b7.Paint += new PaintEventHandler(recolor);
            b8.Paint += new PaintEventHandler(recolor);
            b9.Paint += new PaintEventHandler(recolor);
            b10.Paint += new PaintEventHandler(recolor);
            b11.Paint += new PaintEventHandler(recolor);
            b12.Paint += new PaintEventHandler(recolor);
            b13.Paint += new PaintEventHandler(recolor);
            b14.Paint += new PaintEventHandler(recolor);
            b15.Paint += new PaintEventHandler(recolor);
            b16.Paint += new PaintEventHandler(recolor);
            b17.Paint += new PaintEventHandler(recolor);
            b18.Paint += new PaintEventHandler(recolor);
            b19.Paint += new PaintEventHandler(recolor);
            b20.Paint += new PaintEventHandler(recolor);


            generarLugares();
        }



        private void b10_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b10.Text = null;
            b10.Image = darImagen(10);
            b10.AutoSize = true;
            b10.Enabled = false;
            b10.Paint += new PaintEventHandler(recolor);
            press10 = true;
            revPar(10);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b9.Text = null;
            b9.Image = darImagen(9);
            b9.AutoSize = true;
            b9.Enabled = false;
            b9.Paint += new PaintEventHandler(recolor);
            press9 = true;
            revPar(9);
        }

        private void b11_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b11.Text = null;
            b11.Image = darImagen(11);
            b11.AutoSize = true;
            b11.Enabled = false;
            b11.Paint += new PaintEventHandler(recolor);
            press11 = true;
            revPar(11);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b5.Text = null;
            b5.Image = darImagen(5);
            b5.AutoSize = true;
            b5.Enabled = false;
            b5.Paint += new PaintEventHandler(recolor);
            press5 = true;
            revPar(5);
        }

        private void b13_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b13.Text = null;
            b13.Image = darImagen(13);
            b13.AutoSize = true;
            b13.Enabled = false;
            b13.Paint += new PaintEventHandler(recolor);
            press13 = true;
            revPar(13);
        }

        private void b12_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b12.Text = null;
            b12.Image = darImagen(12);
            b12.AutoSize = true;
            b12.Enabled = false;
            b12.Paint += new PaintEventHandler(recolor);
            press12 = true;
            revPar(12);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b2.Text = null;
            b2.Image = darImagen(2);
            b2.AutoSize = true;
            b2.Enabled = false;
            b2.Paint += new PaintEventHandler(recolor);
            press2 = true;
            revPar(2);
        }
        private void b15_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b15.Text = null;
            b15.Image = darImagen(15);
            b15.AutoSize = true;
            b15.Enabled = false;
            b15.Paint += new PaintEventHandler(recolor);
            press15 = true;
            revPar(15);
        }
        private void b4_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b4.Text = null;
            b4.Image = darImagen(4);
            b4.AutoSize = true;
            b4.Enabled = false;
            b4.Paint += new PaintEventHandler(recolor);
            press4 = true;
            revPar(4);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b6.Text = null;
            b6.Image = darImagen(6);
            b6.AutoSize = true;
            b6.Enabled = false;
            b6.Paint += new PaintEventHandler(recolor);
            press6 = true;
            revPar(6);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b8.Text = null;
            b8.Image = darImagen(8);
            b8.AutoSize = true;
            b8.Enabled = false;
            b8.Paint += new PaintEventHandler(recolor);
            press8 = true;
            revPar(8);
        }

        private void b16_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b16.Text = null;
            b16.Image = darImagen(16);
            b16.AutoSize = true;
            b16.Enabled = false;
            b16.Paint += new PaintEventHandler(recolor);
            press16 = true;
            revPar(16);
        }

        private void b19_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b19.Text = null;
            b19.Image = darImagen(19);
            b19.AutoSize = true;
            b19.Enabled = false;
            b19.Paint += new PaintEventHandler(recolor);
            press19 = true;
            revPar(19);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b7.Text = null;
            b7.Image = darImagen(7);
            b7.AutoSize = true;
            b7.Enabled = false;
            b7.Paint += new PaintEventHandler(recolor);
            press7 = true;
            revPar(7);
        }

        private void b18_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b18.Text = null;
            b18.Image = darImagen(18);
            b18.AutoSize = true;
            b18.Enabled = false;
            b18.Paint += new PaintEventHandler(recolor);
            press18 = true;
            revPar(18);
        }

        private void b17_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b17.Text = null;
            b17.Image = darImagen(17);
            b17.AutoSize = true;
            b17.Enabled = false;
            b17.Paint += new PaintEventHandler(recolor);
            press17 = true;
            revPar(17);
        }

        private void b14_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b14.Text = null;
            b14.Image = darImagen(14);
            b14.AutoSize = true;
            b14.Enabled = false;
            b14.Paint += new PaintEventHandler(recolor);
            press14 = true;
            revPar(14);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b3.Text = null;
            b3.Image = darImagen(3);
            b3.AutoSize = true;
            b3.Enabled = false;
            b3.Paint += new PaintEventHandler(recolor);
            press3 = true;
            revPar(3);
        }

        private void b20_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b20.Text = null;
            b20.Image = darImagen(20);
            b20.AutoSize = true;
            b20.Enabled = false;
            b20.Paint += new PaintEventHandler(recolor);
            press20 = true;
            revPar(20);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            contMovimiento++;
            b1.Text = null;
            b1.Image = darImagen(1);
            b1.TextImageRelation = TextImageRelation.ImageAboveText;
            b1.AutoSize = true;
            b1.Enabled = false;
            b1.Paint += new PaintEventHandler(recolor);
            press1 = true;
            revPar(1);
        }

        private void botonPausar_Click(object sender, EventArgs e)
        {
            if (!corriendo)
            {
                horaInicio = DateTime.Now - tiempoTranscurrido;
                cronometro.Start();
                corriendo = true;
                pausarBotones(0);
            }
            else if (corriendo)
            {
                cronometro.Stop();
                corriendo = false;
                pausarBotones(1);
            }
        }
        private void pausarBotones(int num)
        {
            switch (num)
            {
                case 0:
                    if (!press1)
                        b1.Enabled = true;
                    if (!press2)
                        b2.Enabled = true;
                    if (!press3)
                        b3.Enabled = true;
                    if (!press4)
                        b4.Enabled = true;
                    if (!press5)
                        b5.Enabled = true;
                    if (!press6)
                        b6.Enabled = true;
                    if (!press7)
                        b7.Enabled = true;
                    if (!press8)
                        b8.Enabled = true;
                    if (!press9)
                        b9.Enabled = true;
                    if (!press10)
                        b10.Enabled = true;
                    if (!press11)
                        b11.Enabled = true;
                    if (!press12)
                        b12.Enabled = true;
                    if (!press13)
                        b13.Enabled = true;
                    if (!press14)
                        b14.Enabled = true;
                    if (!press15)
                        b15.Enabled = true;
                    if (!press16)
                        b16.Enabled = true;
                    if (!press17)
                        b17.Enabled = true;
                    if (!press18)
                        b18.Enabled = true;
                    if (!press19)
                        b19.Enabled = true;
                    if (!press20)
                        b20.Enabled = true;

                    break;
                case 1:
                    b1.Enabled = false;
                    b2.Enabled = false;
                    b3.Enabled = false;
                    b4.Enabled = false;
                    b5.Enabled = false;
                    b6.Enabled = false;
                    b7.Enabled = false;
                    b8.Enabled = false;
                    b9.Enabled = false;
                    b10.Enabled = false;
                    b11.Enabled = false;
                    b12.Enabled = false;
                    b13.Enabled = false;
                    b14.Enabled = false;
                    b15.Enabled = false;
                    b16.Enabled = false;
                    b17.Enabled = false;
                    b18.Enabled = false;
                    b19.Enabled = false;
                    b20.Enabled = false;
                    break;
            }
        }
        private void contadorTiempo_Click(object sender, EventArgs e)
        {

        }
    }
}
