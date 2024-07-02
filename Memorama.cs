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
        private Tablero_de_lideres tabLid; //Instancia la siguiente ventana
        private System.Windows.Forms.Timer cronometro; //Creo una variable timer llamada cronometro
        private TimeSpan tiempoTranscurrido; // Variable en la cual guardaremos el tiempo de juego del participante
        private DateTime horaInicio; //Variable en la cual guardaremos la hora en la cual se inicio la partida
        private bool corriendo; //Variable para saber si el cronómetro esta corriendo o pausado
        private string[] info; //Arreglo donde guardaremos la información de la ventan anterior
        private string[,] memo; //Arreglo multidimensional donde guardaremos la informacion de memoria
        private int[] par = new int[2]; //Arreglo donde guardaremos el número de boton que fue presionado
        private static int conteoSeleccionado = 0, parResuleto = 0, contMovimiento = 0; //Variables donde guardaremos la cantidad seleccionada hasta ahora, los pares que han sido resueltos, y la cantidad de movimientos
        private static int[] Aki = new int[2],AZKi = new int[2], Bae = new int[2], Calli = new int[2],IRyS = new int[2],Kiara = new int[2],Korone = new int[2],Ollie = new int[2],Risu = new int[2],Sora = new int[2]; //Variables de cada figura, en las cuales guardaremos que numero de boton es de cada figura
        private static bool press1, press2, press3, press4,press5, press6, press7, press8, press9, press10, press11, press12, press13, press14, press15, press16, press17, press18, press19, press20; //Variable para saber si el boton esta presionado, usado para la pausa
        private string[] info2 = new string[2]; //Arreglo donde guardaremos la cantidad de movimientos y el tiempo una vez finalice la partida
        Registro inicio; //Variable donde guardaremos la instancia de la memoria anterior 

        private Image darImagen(int a)
        {//Función la cual al coincidir el número del botón con el número asignado a las imágenes, regresan una imágen, recibimos como argumento un int
            if (a == Aki[0] ||  a == Aki[1]) //Comparamos si el int es uno de los que fue asignado a la figura
            {
                return Properties.Resources.Aki; //Regresa la imagen de la figura
            }
            if (a == AZKi[0] || a == AZKi[1]) //Comparamos si el int es uno de los que fue asignado a la figura
            {
                return Properties.Resources.AZKi; //Regresa la imagen de la figura
            }
            if (a == Bae[0] || a == Bae[1]) //Comparamos si el int es uno de los que fue asignado a la figura
            {
                return Properties.Resources.Bae; //Regresa la imagen de la figura
            }
            if (a == Calli[0] || a == Calli[1]) //Comparamos si el int es uno de los que fue asignado a la figura
            {
                return Properties.Resources.Calli; //Regresa la imagen de la figura
            }
            if (a == IRyS[0] || a == IRyS[1]) //Comparamos si el int es uno de los que fue asignado a la figura
            {
                return Properties.Resources.IRyS; //Regresa la imagen de la figura
            }
            if (a == Kiara[0] || a == Kiara[1]) //Comparamos si el int es uno de los que fue asignado a la figura
            {
                return Properties.Resources.Kiara; //Regresa la imagen de la figura
            }
            if (a == Korone[0] || a == Korone[1]) //Comparamos si el int es uno de los que fue asignado a la figura
            {
                return Properties.Resources.Korone; //Regresa la imagen de la figura
            }
            if (a == Ollie[0] || a == Ollie[1]) //Comparamos si el int es uno de los que fue asignado a la figura
            {
                return Properties.Resources.Ollie; //Regresa la imagen de la figura
            }
            if (a == Risu[0] || a == Risu[1]) //Comparamos si el int es uno de los que fue asignado a la figura
            {
                return Properties.Resources.Risu; //Regresa la imagen de la figura
            }
            if (a == Sora[0] || a == Sora[1]) //Comparamos si el int es uno de los que fue asignado a la figura
            {
                return Properties.Resources.Sora; //Regresa la imagen de la figura
            }
            return null; //Retorno para que la función trabaje sin errores
        }
        private void generarLugares()
        { // Función para generar los lugares que le tocan a cada figura
            int[] numeros = new int[20]; //Generamos el arreglo de 20 números
            for (int i = 0; i < numeros.Length; i++) //Rellenamos el arreglo
            {
                numeros[i] = i + 1; //Daremos desde el 1 hasta el 20
            }

            Random rng = new Random(); //Declaramos le variable con la cual organizaremos el arreglo
            int n = numeros.Length; //Variable para el while
            while (n > 1)
            { //Mientras n sea mayor a 1
                n--; //Disminuimos n en uno
                int k = rng.Next(n + 1); //Creamos una variable para asignar posición al azar
                int value = numeros[k]; //Lo que este en la posición k del arreglo lo pasamos a value
                numeros[k] = numeros[n]; // Lo que esta en posicion n lo pasamos a posición k
                numeros[n] = value; //Lo que esta en posicion n lo pasamos a value
            }

            int[,] arregloPosiciones = new int[10, 2]; // Creamos un arreglo multidimensional
            for (int i = 0; i < 20; i++)
            { //Vaciaremos los 20 numeros
                arregloPosiciones[i % 10, i / 10] = numeros[i]; //Vaciamos lo del arreglo de 20 números al arreglo multidimensional
            }

            Aki[0] = arregloPosiciones[0, 0]; // Guardamos en el arreglo de la figura los números que le tocó
            Aki[1] = arregloPosiciones[0,1]; // Guardamos en el arreglo de la figura los números que le tocó

            AZKi[0] = arregloPosiciones[1,0]; // Guardamos en el arreglo de la figura los números que le tocó
            AZKi[1] = arregloPosiciones[1,1]; // Guardamos en el arreglo de la figura los números que le tocó

            Bae[0] = arregloPosiciones[2,0]; // Guardamos en el arreglo de la figura los números que le tocó
            Bae[1] = arregloPosiciones [2,1]; // Guardamos en el arreglo de la figura los números que le tocó

            Calli[0] = arregloPosiciones[3,0]; // Guardamos en el arreglo de la figura los números que le tocó
            Calli[1] = arregloPosiciones[3,1]; // Guardamos en el arreglo de la figura los números que le tocó

            IRyS[0] = arregloPosiciones[4,0]; // Guardamos en el arreglo de la figura los números que le tocó
            IRyS[1] = arregloPosiciones[4, 1]; // Guardamos en el arreglo de la figura los números que le tocó

            Kiara[0] = arregloPosiciones[5, 0]; // Guardamos en el arreglo de la figura los números que le tocó
            Kiara[1] = arregloPosiciones[5, 1]; // Guardamos en el arreglo de la figura los números que le tocó

            Korone[0] = arregloPosiciones[6, 0]; // Guardamos en el arreglo de la figura los números que le tocó
            Korone[1] = arregloPosiciones[6, 1]; // Guardamos en el arreglo de la figura los números que le tocó

            Ollie[0] = arregloPosiciones[7, 0]; // Guardamos en el arreglo de la figura los números que le tocó
            Ollie[1] = arregloPosiciones[7, 1]; // Guardamos en el arreglo de la figura los números que le tocó

            Risu[0] = arregloPosiciones[8, 0]; // Guardamos en el arreglo de la figura los números que le tocó
            Risu[1] = arregloPosiciones[8, 1]; // Guardamos en el arreglo de la figura los números que le tocó

            Sora[0] = arregloPosiciones[9, 0]; // Guardamos en el arreglo de la figura los números que le tocó
            Sora[1] = arregloPosiciones[9, 1]; // Guardamos en el arreglo de la figura los números que le tocó

        }
        private void InicializarCronometro()
        {// Funcion para inicializar el cronómetro
            tiempoTranscurrido = TimeSpan.Zero; //Iniciamos la variable con 0
            cronometro = new System.Windows.Forms.Timer(); //Inicializamos la variable
            cronometro.Interval = 1000; // Intervalo de 1 segundo
            cronometro.Tick += Cronometro_Tick; //Llamamos a la función tick para que constantemente se este actualizando
        }
        private void Cronometro_Tick(object sender, EventArgs e)
        {//Función para actualizar el tiempo y el texto
            tiempoTranscurrido = DateTime.Now - horaInicio; //Actualizamos el tiempo transcurrido
            contadorTiempo.Text = tiempoTranscurrido.ToString(@"hh\:mm\:ss");//Mandamos lo que tenemos de tiempo transcurrido al label
        }
        public Memorama(Registro ini, string[,] memoria, string[] inf)
        {//Funcion de inicializacion de la ventana, toma como argumento la instancia de la ventan anterior, la memoria, y la información registrada
            InitializeComponent(); //Inicializamos los componentes de la ventana
            InicializarCronometro(); //Llamamos a la funcion para inicializar el cronómetro
            info = inf; //Pasamos el argumento a la variable local
            inicio = ini; //Pasamos la instancia a la variable local
            memo = memoria; //Pasamos el arreglo a una variable local
        }
        public void revPar(int a)
        {//Función para checar el número de botones presionados y guardar cuales son los botones presionados
            par[conteoSeleccionado] = a; //Se pone en el arreglo el botón que se presionó
            conteoSeleccionado++; //Se sume uno al conteo
            conteoMovimiento.Text = Convert.ToString(contMovimiento / 2); //La cantidad de movimientos al label
            if (conteoSeleccionado == 2)
            {//Si ya se presionaronn dos se manda a checar si los botones son pares
                parConteo(par); //Se llama a la función y enviamos loa guardado en el arreglo
                conteoSeleccionado = 0; //Reiniciamos la variable a cero
            }
        }
        public void parConteo(int[] a)
        {//Función para checar si los botones presionados son par
            int p1 = a[0], p2 = a[1]; //Pasamos el arreglo a variables locales

            if (p1 == Aki[0] && p2 == Aki[1]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            }
            else if (p1 == Aki[1] && p2 == Aki[0]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            }
            else if (p1 == AZKi[0] && p2 == AZKi[1]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            }
            else if (p1 == AZKi[1] && p2 == AZKi[0]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            } else if (p1 == Bae[0] && p2 == Bae[1]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            } else if (p1 == Bae[1] && p2 == Bae[0]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            } else if (p1 == Calli[0] && p2 == Calli[1]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            } else if (p1 == Calli[1] && p2 == Calli[0]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            } else if (p1 == IRyS[0] && p2 == IRyS[1]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            } else if (p1 == IRyS[1] && p2 == IRyS[0]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            } else if (p1 == Kiara[0] && p2 == Kiara[1]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            } else if (p1 == Kiara[1] && p2 == Kiara[0]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            } else if (p1 == Korone[0] && p2 == Korone[1]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            } else if (p1 == Korone[1] && p2 == Korone[0]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            } else if (p1 == Ollie[0] && p2 == Ollie[1]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            } else if (p1 == Ollie[1] && p2 == Ollie[0]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            } else if (p1 == Risu[0] && p2 == Risu[1]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            } else if (p1 == Risu[1] && p2 == Risu[0]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            } else if (p1 == Sora[0] && p2 == Sora[1]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            } else if (p1 == Sora[1] && p2 == Sora[0]) //Revisamos si los botones coinciden con los asignados a la figura
            {
                parResuleto++; //Sumamos uno a los pares resueltos

            }
            else
            {// Si no coinciden con ninguna figura
                MessageBox.Show("No son par"); //Llama el texto y da un mensaje de que no son par.
                reinicioBotones(p1); //Reiniciamos el primer botón
                reinicioBotones(p2); // Reiniciamos el segundo botón
            }
            ganar(parResuleto); //Llamamos a la función de ganar y revisamos si con el número de pares ganadas hasta ahora se gana la partida
        }

        private void ganar(int a)
        {//Función para revisar que se ha llegado al número, toma como argumento la cantidad de pares resueltos
            if (a == 10)
            { // Revisamos si se llegó a 10
                cronometro.Stop(); //Detener el cronometro
                info2[0] = Convert.ToString(contMovimiento / 2); //Guardamos la cantidad de movimientos
                info2[1] = Convert.ToString(contadorTiempo.Text); //Guardamos el tiempo
                string aux = info2[1]; //Ponemos el tiempo en una variable
                string[] res = aux.Split(":"); //Dividimos usando el : como divisor y lo guardamos en un arreglo
                MessageBox.Show("Ganaste con: " + res[1] + " minutos y " + res[2] + " segundos y " + info2[0] + " movimientos"); //Mensaje de felicitación y donde daremos que tiempo se hizo
                tabLid = new Tablero_de_lideres(memo, info, info2); //Inicializamos la siguiente ventana y enviamos memoria junto con ambor arreglos con la información
                tabLid.Show(); //Mostramos la siguiente ventana
                this.Hide(); //Ocultamos esta ventana
            }
        }
        private void reinicioBotones(int a)
        {//Función para reiniciar los botones si estos no hacen par, toma como argumento el número de botón
            switch (a)
            { //Switch con el cual compara el número de botón
                case 1: //Caso para el botón 1
                    b1.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b1.AutoSize = false; //Deshabilitar el autosize
                    b1.Enabled = true; //Habilitamos el botón
                    press1 = false; //Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                case 2: //Caso para el botón 2
                    b2.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b2.AutoSize = false; //Deshabilitar el autosize
                    b2.Enabled = true;//Habilitamos el botón
                    press2 = false;//Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                case 3: //Caso para el botón 3
                    b3.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b3.AutoSize = false; //Deshabilitar el autosize
                    b3.Enabled = true;//Habilitamos el botón
                    press3 = false; //Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                case 4: //Caso para el botón 4
                    b4.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b4.AutoSize = false; //Deshabilitar el autosize
                    b4.Enabled = true;//Habilitamos el botón
                    press4 = false; //Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                case 5: //Caso para el botón 5
                    b5.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b5.AutoSize = false; //Deshabilitar el autosize
                    b5.Enabled = true;//Habilitamos el botón
                    press5 = false; //Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                case 6: //Caso para el botón 6
                    b6.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b6.AutoSize = false; //Deshabilitar el autosize
                    b6.Enabled = true;//Habilitamos el botón
                    press6 = false; //Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                case 7: //Caso para el botón 7
                    b7.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b7.AutoSize = false; //Deshabilitar el autosize
                    b7.Enabled = true;//Habilitamos el botón
                    press7 = false; //Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                case 8: //Caso para el botón 8
                    b8.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b8.AutoSize = false; //Deshabilitar el autosize
                    b8.Enabled = true;//Habilitamos el botón
                    press8 = false; //Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                case 9: //Caso para el botón 9
                    b9.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b9.AutoSize = false; //Deshabilitar el autosize
                    b9.Enabled = true;//Habilitamos el botón
                    press9 = false; //Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                case 10: //Caso para el botón 10
                    b10.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b10.AutoSize = false; //Deshabilitar el autosize
                    b10.Enabled = true;//Habilitamos el botón
                    press10 = false; //Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                case 11: //Caso para el botón 11
                    b11.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b11.AutoSize = false; //Deshabilitar el autosize
                    b11.Enabled = true;//Habilitamos el botón
                    press11 = false; //Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                case 12: //Caso para el botón 12
                    b12.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b12.AutoSize = false; //Deshabilitar el autosize
                    b12.Enabled = true;//Habilitamos el botón
                    press12 = false; //Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                case 13: //Caso para el botón 13
                    b13.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b13.AutoSize = false; //Deshabilitar el autosize
                    b13.Enabled = true;//Habilitamos el botón
                    press13 = false; //Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                case 14: //Caso para el botón 14
                    b14.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b14.AutoSize = false; //Deshabilitar el autosize
                    b14.Enabled = true;//Habilitamos el botón
                    press14 = false; //Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                case 15: //Caso para el botón 15
                    b15.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b15.AutoSize = false; //Deshabilitar el autosize
                    b15.Enabled = true;//Habilitamos el botón
                    press15 = false; //Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                case 16: //Caso para el botón 16
                    b16.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b16.AutoSize = false; //Deshabilitar el autosize
                    b16.Enabled = true;//Habilitamos el botón
                    press16 = false; //Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                case 17: //Caso para el botón 17
                    b17.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b17.AutoSize = false; //Deshabilitar el autosize
                    b17.Enabled = true;//Habilitamos el botón
                    press17 = false; //Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                case 18: //Caso para el botón 18
                    b18.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b18.AutoSize = false; //Deshabilitar el autosize
                    b18.Enabled = true;//Habilitamos el botón
                    press18 = false; //Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                case 19: //Caso para el botón 19
                    b19.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b19.AutoSize = false; //Deshabilitar el autosize
                    b19.Enabled = true;//Habilitamos el botón
                    press19 = false; //Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                case 20: //Caso para el botón 20
                    b20.Image = Properties.Resources.logo; //Reiniciamos la imagen al logo
                    b20.AutoSize = false; //Deshabilitar el autosize
                    b20.Enabled = true;//Habilitamos el botón
                    press20 = false; //Reiniciamos la variable de botón presionado
                    break; //Terminamos el caso
                default: //Caso si se de una variable rara
                    Console.WriteLine("Error critico"); //Mensaje de error
                    break; //Terminamos el caso
            }
        }
        private void botonCancelar_Click(object sender, EventArgs e)
        {//Evento click del boton cancelar
            inicio.Show(); //Muestra la instancia de la ventana anterior
            this.Close(); //Cierra esta ventana
        }
        private void recolor(object sender, PaintEventArgs e)
        { //Función para recolorear los botones y evitar que estos se ven grises
            Button btn = sender as Button; //Tomamos el botón y lo ponemos en una variable
            if (btn != null && !btn.Enabled)
            {//Si el botón no es null y no está habilitado

                if (btn.Image != null)
                { //Si la imagen del botón no es nulo

                    int x = (btn.Width - btn.Image.Width) / 2; //Centramos las coordenadas en x
                    int y = (btn.Height - btn.Image.Height) / 2; //Centramos las coordenadas en y
                    e.Graphics.DrawImage(btn.Image, x, y, btn.Image.Width, btn.Image.Height); //Coloreamos las imágenes
                }

                TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, btn.ClientRectangle, btn.ForeColor); //Coloreamos el resto de elementos del botón
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {// Evento click del boton de reinicio
            b1.Image = Properties.Resources.logo; //Damos de imagen el logo
            b2.Image = Properties.Resources.logo; //Damos de imagen el logo
            b3.Image = Properties.Resources.logo; //Damos de imagen el logo
            b4.Image = Properties.Resources.logo; //Damos de imagen el logo
            b5.Image = Properties.Resources.logo; //Damos de imagen el logo
            b6.Image = Properties.Resources.logo; //Damos de imagen el logo
            b7.Image = Properties.Resources.logo; //Damos de imagen el logo
            b8.Image = Properties.Resources.logo; //Damos de imagen el logo
            b9.Image = Properties.Resources.logo; //Damos de imagen el logo
            b10.Image = Properties.Resources.logo; //Damos de imagen el logo
            b11.Image = Properties.Resources.logo; //Damos de imagen el logo
            b12.Image = Properties.Resources.logo; //Damos de imagen el logo
            b13.Image = Properties.Resources.logo; //Damos de imagen el logo
            b14.Image = Properties.Resources.logo; //Damos de imagen el logo
            b15.Image = Properties.Resources.logo; //Damos de imagen el logo
            b16.Image = Properties.Resources.logo; //Damos de imagen el logo
            b17.Image = Properties.Resources.logo; //Damos de imagen el logo
            b18.Image = Properties.Resources.logo; //Damos de imagen el logo
            b19.Image = Properties.Resources.logo; //Damos de imagen el logo
            b20.Image = Properties.Resources.logo; //Damos de imagen el logo


            b1.AutoSize = false; //Deshabilitar autosize
            b2.AutoSize = false; //Deshabilitar autosize
            b3.AutoSize = false; //Deshabilitar autosize
            b4.AutoSize = false; //Deshabilitar autosize
            b5.AutoSize = false; //Deshabilitar autosize
            b6.AutoSize = false; //Deshabilitar autosize
            b7.AutoSize = false; //Deshabilitar autosize
            b8.AutoSize = false; //Deshabilitar autosize
            b9.AutoSize = false; //Deshabilitar autosize
            b10.AutoSize = false; //Deshabilitar autosize
            b11.AutoSize = false; //Deshabilitar autosize
            b12.AutoSize = false; //Deshabilitar autosize
            b13.AutoSize = false; //Deshabilitar autosize
            b14.AutoSize = false; //Deshabilitar autosize
            b15.AutoSize = false; //Deshabilitar autosize
            b16.AutoSize = false; //Deshabilitar autosize
            b17.AutoSize = false; //Deshabilitar autosize
            b18.AutoSize = false; //Deshabilitar autosize
            b19.AutoSize = false; //Deshabilitar autosize
            b20.AutoSize = false; //Deshabilitar autosize

            b1.Enabled = true; //Habilitar el botón
            b2.Enabled = true; //Habilitar el botón
            b3.Enabled = true; //Habilitar el botón
            b4.Enabled = true; //Habilitar el botón
            b5.Enabled = true; //Habilitar el botón
            b6.Enabled = true; //Habilitar el botón
            b7.Enabled = true; //Habilitar el botón
            b8.Enabled = true; //Habilitar el botón
            b9.Enabled = true; //Habilitar el botón
            b10.Enabled = true; //Habilitar el botón
            b11.Enabled = true; //Habilitar el botón
            b12.Enabled = true; //Habilitar el botón
            b13.Enabled = true; //Habilitar el botón
            b14.Enabled = true; //Habilitar el botón
            b15.Enabled = true; //Habilitar el botón
            b16.Enabled = true; //Habilitar el botón
            b17.Enabled = true; //Habilitar el botón
            b18.Enabled = true; //Habilitar el botón
            b19.Enabled = true; //Habilitar el botón
            b20.Enabled = true; //Habilitar el botón

            press1 = false; //Reiniciar press a false
            press2 = false; //Reiniciar press a false
            press3 = false; //Reiniciar press a false
            press4 = false; //Reiniciar press a false
            press5 = false; //Reiniciar press a false
            press6 = false; //Reiniciar press a false
            press7 = false; //Reiniciar press a false
            press8 = false; //Reiniciar press a false
            press9 = false; //Reiniciar press a false
            press10 = false; //Reiniciar press a false
            press11 = false; //Reiniciar press a false
            press12 = false; //Reiniciar press a false
            press13 = false; //Reiniciar press a false
            press14 = false; //Reiniciar press a false
            press15 = false; //Reiniciar press a false
            press16 = false; //Reiniciar press a false
            press17 = false; //Reiniciar press a false
            press18 = false; //Reiniciar press a false
            press19 = false; //Reiniciar press a false
            press20 = false; //Reiniciar press a false

            conteoSeleccionado = 0; //Reiniciamos el conteo seleccionado a cero
            parResuleto = 0; // Reiniciamos los apres resueltos a cero
            contMovimiento = 0; //Reiniciamos el conteo de movimientos a cero

            generarLugares(); //Llamamos a la función para asignar lugares a las figuras

            cronometro.Stop(); //Detenemos el cronómetro
            corriendo = false; //Ponemos corriendo como falso
            tiempoTranscurrido = TimeSpan.Zero; //Volvemos tiempo transcurrido cero
            contadorTiempo.Text = "00:00:00"; //
            horaInicio = DateTime.Now - tiempoTranscurrido; //Reiniciamos la hora de inicio
            cronometro.Start(); // Iniciamos el cronometro
        }

        private void Memorama_Load(object sender, EventArgs e)
        { //Función para la carga de la ventana
            horaInicio = DateTime.Now - tiempoTranscurrido; //Asignamos la hora de inicio
            cronometro.Start(); //Iniciamos el cronometro
            corriendo = true; //Pasamos corriendo a true
            Nickname.Text = info[1]; //Pasamos el nickname dado al label

            b1.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos
            b2.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos
            b3.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos
            b4.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos
            b5.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos
            b6.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos
            b7.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos
            b8.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos
            b9.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos
            b10.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos
            b11.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos
            b12.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos
            b13.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos
            b14.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos
            b15.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos
            b16.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos
            b17.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos
            b18.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos
            b19.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos
            b20.Paint += new PaintEventHandler(recolor); //Llamamos a la función para repintar los iconos

            generarLugares(); //Llamamos a la función para asignar lugares a las figuras
        }

        private void b10_Click(object sender, EventArgs e)
        { //Evento de click para el botón 10
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b10.Image = darImagen(10); //Llamamos a la función dar imagen para asignarle imagen al botón
            b10.AutoSize = true; //Ponemos autosize en true
            b10.Enabled = false; //Deshabilitamos el botón
            press10 = true; //Damoa true a la variable press
            revPar(10); //Llamamos a la función para revisar par
        }
        private void b9_Click(object sender, EventArgs e)
        {//Evento de click para el botón 9
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b9.Image = darImagen(9); //Llamamos a la función dar imagen para asignarle imagen al botón
            b9.AutoSize = true; //Ponemos autosize en true
            b9.Enabled = false; //Deshabilitamos el botón
            press9 = true; //Damoa true a la variable press
            revPar(9); //Llamamos a la función para revisar par
        }

        private void b11_Click(object sender, EventArgs e)
        {//Evento de click para el botón 11
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b11.Image = darImagen(11); //Llamamos a la función dar imagen para asignarle imagen al botón
            b11.AutoSize = true; //Ponemos autosize en true
            b11.Enabled = false; //Deshabilitamos el botón
            press11 = true; //Damoa true a la variable press
            revPar(11); //Llamamos a la función para revisar par
        }

        private void b5_Click(object sender, EventArgs e)
        {//Evento de click para el botón 5
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b5.Image = darImagen(5); //Llamamos a la función dar imagen para asignarle imagen al botón
            b5.AutoSize = true; //Ponemos autosize en true
            b5.Enabled = false; //Deshabilitamos el botón
            press5 = true; //Damoa true a la variable press
            revPar(5); //Llamamos a la función para revisar par
        }

        private void b13_Click(object sender, EventArgs e)
        {//Evento de click para el botón 13
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b13.Image = darImagen(13); //Llamamos a la función dar imagen para asignarle imagen al botón
            b13.AutoSize = true; //Ponemos autosize en true
            b13.Enabled = false; //Deshabilitamos el botón
            press13 = true; //Damoa true a la variable press
            revPar(13); //Llamamos a la función para revisar par
        }

        private void b12_Click(object sender, EventArgs e)
        {//Evento de click para el botón 12
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b12.Image = darImagen(12); //Llamamos a la función dar imagen para asignarle imagen al botón
            b12.AutoSize = true; //Ponemos autosize en true
            b12.Enabled = false; //Deshabilitamos el botón
            press12 = true; //Damoa true a la variable press
            revPar(12); //Llamamos a la función para revisar par
        }

        private void b2_Click(object sender, EventArgs e)
        {//Evento de click para el botón 2
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b2.Image = darImagen(2); //Llamamos a la función dar imagen para asignarle imagen al botón
            b2.AutoSize = true; //Ponemos autosize en true
            b2.Enabled = false; //Deshabilitamos el botón
            press2 = true; //Damoa true a la variable press
            revPar(2); //Llamamos a la función para revisar par
        }
        private void b15_Click(object sender, EventArgs e)
        {//Evento de click para el botón 15
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b15.Image = darImagen(15); //Llamamos a la función dar imagen para asignarle imagen al botón
            b15.AutoSize = true; //Ponemos autosize en true
            b15.Enabled = false; //Deshabilitamos el botón
            press15 = true; //Damoa true a la variable press
            revPar(15); //Llamamos a la función para revisar par
        }
        private void b4_Click(object sender, EventArgs e)
        {//Evento de click para el botón 4
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b4.Image = darImagen(4); //Llamamos a la función dar imagen para asignarle imagen al botón
            b4.AutoSize = true; //Ponemos autosize en true
            b4.Enabled = false; //Deshabilitamos el botón
            press4 = true; //Damoa true a la variable press
            revPar(4); //Llamamos a la función para revisar par
        }

        private void b6_Click(object sender, EventArgs e)
        {//Evento de click para el botón 6
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b6.Image = darImagen(6); //Llamamos a la función dar imagen para asignarle imagen al botón
            b6.AutoSize = true; //Ponemos autosize en true
            b6.Enabled = false; //Deshabilitamos el botón
            press6 = true; //Damoa true a la variable press
            revPar(6); //Llamamos a la función para revisar par
        }

        private void b8_Click(object sender, EventArgs e)
        {//Evento de click para el botón 8
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b8.Image = darImagen(8); //Llamamos a la función dar imagen para asignarle imagen al botón
            b8.AutoSize = true; //Ponemos autosize en true
            b8.Enabled = false; //Deshabilitamos el botón
            press8 = true; //Damoa true a la variable press
            revPar(8); //Llamamos a la función para revisar par
        }

        private void b16_Click(object sender, EventArgs e)
        {//Evento de click para el botón 16
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b16.Image = darImagen(16); //Llamamos a la función dar imagen para asignarle imagen al botón
            b16.AutoSize = true; //Ponemos autosize en true
            b16.Enabled = false; //Deshabilitamos el botón
            press16 = true; //Damoa true a la variable press
            revPar(16); //Llamamos a la función para revisar par
        }

        private void b19_Click(object sender, EventArgs e)
        {//Evento de click para el botón 19
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b19.Image = darImagen(19); //Llamamos a la función dar imagen para asignarle imagen al botón
            b19.AutoSize = true; //Ponemos autosize en true
            b19.Enabled = false; //Deshabilitamos el botón
            press19 = true; //Damoa true a la variable press
            revPar(19); //Llamamos a la función para revisar par
        }

        private void b7_Click(object sender, EventArgs e)
        {//Evento de click para el botón 7
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b7.Image = darImagen(7); //Llamamos a la función dar imagen para asignarle imagen al botón
            b7.AutoSize = true; //Ponemos autosize en true
            b7.Enabled = false; //Deshabilitamos el botón
            press7 = true; //Damoa true a la variable press
            revPar(7); //Llamamos a la función para revisar par
        }

        private void b18_Click(object sender, EventArgs e)
        {//Evento de click para el botón 18
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b18.Image = darImagen(18); //Llamamos a la función dar imagen para asignarle imagen al botón
            b18.AutoSize = true; //Ponemos autosize en true
            b18.Enabled = false; //Deshabilitamos el botón
            press18 = true; //Damoa true a la variable press
            revPar(18); //Llamamos a la función para revisar par
        }

        private void b17_Click(object sender, EventArgs e)
        {//Evento de click para el botón 17
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b17.Image = darImagen(17); //Llamamos a la función dar imagen para asignarle imagen al botón
            b17.AutoSize = true; //Ponemos autosize en true
            b17.Enabled = false; //Deshabilitamos el botón
            press17 = true; //Damoa true a la variable press
            revPar(17); //Llamamos a la función para revisar par
        }

        private void b14_Click(object sender, EventArgs e)
        {//Evento de click para el botón 14
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b14.Image = darImagen(14); //Llamamos a la función dar imagen para asignarle imagen al botón
            b14.AutoSize = true; //Ponemos autosize en true
            b14.Enabled = false; //Deshabilitamos el botón
            press14 = true; //Damoa true a la variable press
            revPar(14); //Llamamos a la función para revisar par
        }

        private void b3_Click(object sender, EventArgs e)
        {//Evento de click para el botón 3
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b3.Image = darImagen(3); //Llamamos a la función dar imagen para asignarle imagen al botón
            b3.AutoSize = true; //Ponemos autosize en true
            b3.Enabled = false; //Deshabilitamos el botón
            press3 = true; //Damoa true a la variable press
            revPar(3); //Llamamos a la función para revisar par
        }

        private void b20_Click(object sender, EventArgs e)
        {//Evento de click para el botón 20
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b20.Image = darImagen(20); //Llamamos a la función dar imagen para asignarle imagen al botón
            b20.AutoSize = true; //Ponemos autosize en true
            b20.Enabled = false; //Deshabilitamos el botón
            press20 = true; //Damoa true a la variable press
            revPar(20); //Llamamos a la función para revisar par
        }

        private void b1_Click(object sender, EventArgs e)
        {//Evento de click para el botón 1
            contMovimiento++; //Sumamos uno al conteo de movimiento
            b1.Image = darImagen(1); //Llamamos a la función dar imagen para asignarle imagen al botón
            b1.AutoSize = true; //Ponemos autosize en true
            b1.Enabled = false; //Deshabilitamos el botón
            press1 = true; //Damoa true a la variable press
            revPar(1); //Llamamos a la función para revisar par
        }

        private void botonPausar_Click(object sender, EventArgs e)
        { //Evento para el botón de pausar
            if (!corriendo)
            { //Si la variable corriendo es falsa
                horaInicio = DateTime.Now - tiempoTranscurrido; // Damos hora de inicio
                cronometro.Start(); //Iniciamos cronometro
                corriendo = true; //Cambiamos corriendo a true
                pausarBotones(0); //Llamó a la funciones pausar botones
            }
            else if (corriendo)
            { // Si la variable es true
                cronometro.Stop(); //Detener el cronometro
                corriendo = false; //Cambiamos corriendo a false
                pausarBotones(1); // Llamamos a la función pausar botones
            }
        }
        private void pausarBotones(int num)
        { // Función para la pausa de botones, toma como argumento un int
            switch (num)
            { // revisamos con la variable num
                case 0: //Caso cero
                    if (!press1) //Revisamos si el botón ha sido presionado
                        b1.Enabled = true; //Si no estaba presionado se da enable
                    if (!press2) //Revisamos si el botón ha sido presionado
                        b2.Enabled = true; //Si no estaba presionado se da enable
                    if (!press3) //Revisamos si el botón ha sido presionado
                        b3.Enabled = true; //Si no estaba presionado se da enable
                    if (!press4) //Revisamos si el botón ha sido presionado
                        b4.Enabled = true; //Si no estaba presionado se da enable
                    if (!press5) //Revisamos si el botón ha sido presionado
                        b5.Enabled = true; //Si no estaba presionado se da enable
                    if (!press6) //Revisamos si el botón ha sido presionado
                        b6.Enabled = true; //Si no estaba presionado se da enable
                    if (!press7) //Revisamos si el botón ha sido presionado
                        b7.Enabled = true; //Si no estaba presionado se da enable
                    if (!press8) //Revisamos si el botón ha sido presionado
                        b8.Enabled = true; //Si no estaba presionado se da enable
                    if (!press9) //Revisamos si el botón ha sido presionado
                        b9.Enabled = true; //Si no estaba presionado se da enable
                    if (!press10) //Revisamos si el botón ha sido presionado
                        b10.Enabled = true; //Si no estaba presionado se da enable
                    if (!press11) //Revisamos si el botón ha sido presionado
                        b11.Enabled = true; //Si no estaba presionado se da enable
                    if (!press12) //Revisamos si el botón ha sido presionado
                        b12.Enabled = true; //Si no estaba presionado se da enable
                    if (!press13) //Revisamos si el botón ha sido presionado
                        b13.Enabled = true; //Si no estaba presionado se da enable
                    if (!press14) //Revisamos si el botón ha sido presionado
                        b14.Enabled = true; //Si no estaba presionado se da enable
                    if (!press15) //Revisamos si el botón ha sido presionado
                        b15.Enabled = true; //Si no estaba presionado se da enable
                    if (!press16) //Revisamos si el botón ha sido presionado
                        b16.Enabled = true; //Si no estaba presionado se da enable
                    if (!press17) //Revisamos si el botón ha sido presionado
                        b17.Enabled = true; //Si no estaba presionado se da enable
                    if (!press18) //Revisamos si el botón ha sido presionado
                        b18.Enabled = true; //Si no estaba presionado se da enable
                    if (!press19) //Revisamos si el botón ha sido presionado
                        b19.Enabled = true; //Si no estaba presionado se da enable
                    if (!press20) //Revisamos si el botón ha sido presionado
                        b20.Enabled = true; //Si no estaba presionado se da enable
                    break; //Terminamos el caso
                case 1: //Caso uno
                    b1.Enabled = false; //Deshabilitamos el botones
                    b2.Enabled = false; //Deshabilitamos el botones
                    b3.Enabled = false; //Deshabilitamos el botones
                    b4.Enabled = false; //Deshabilitamos el botones
                    b5.Enabled = false; //Deshabilitamos el botones
                    b6.Enabled = false; //Deshabilitamos el botones
                    b7.Enabled = false; //Deshabilitamos el botones
                    b8.Enabled = false; //Deshabilitamos el botones
                    b9.Enabled = false; //Deshabilitamos el botones
                    b10.Enabled = false; //Deshabilitamos el botones
                    b11.Enabled = false; //Deshabilitamos el botones
                    b12.Enabled = false; //Deshabilitamos el botones
                    b13.Enabled = false; //Deshabilitamos el botones
                    b14.Enabled = false; //Deshabilitamos el botones
                    b15.Enabled = false; //Deshabilitamos el botones
                    b16.Enabled = false; //Deshabilitamos el botones
                    b17.Enabled = false; //Deshabilitamos el botones
                    b18.Enabled = false; //Deshabilitamos el botones
                    b19.Enabled = false; //Deshabilitamos el botones
                    b20.Enabled = false; //Deshabilitamos el botones
                    break; //Terminamos el caso
            }
        }
        private void contadorTiempo_Click(object sender, EventArgs e)
        {

        }
    }
}
