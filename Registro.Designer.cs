using Memorama.Properties;

namespace Memorama
{
    partial class Registro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            anuncioRegistro = new Label();
            anuncioNombre = new Label();
            anuncioNickname = new Label();
            anuncioEdad = new Label();
            botonSalir = new Button();
            botonIniciar = new Button();
            textoNombre = new TextBox();
            textoNickname = new TextBox();
            textoEdad = new TextBox();
            gif2 = new PictureBox();
            gif1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gif2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gif1).BeginInit();
            SuspendLayout();
            // 
            // anuncioRegistro
            // 
            anuncioRegistro.AutoSize = true;
            anuncioRegistro.Location = new Point(239, 39);
            anuncioRegistro.Name = "anuncioRegistro";
            anuncioRegistro.Size = new Size(50, 15);
            anuncioRegistro.TabIndex = 0;
            anuncioRegistro.Text = "Registro";
            // 
            // anuncioNombre
            // 
            anuncioNombre.AutoSize = true;
            anuncioNombre.Location = new Point(173, 88);
            anuncioNombre.Name = "anuncioNombre";
            anuncioNombre.Size = new Size(51, 15);
            anuncioNombre.TabIndex = 1;
            anuncioNombre.Text = "Nombre";
            // 
            // anuncioNickname
            // 
            anuncioNickname.AutoSize = true;
            anuncioNickname.Location = new Point(173, 142);
            anuncioNickname.Name = "anuncioNickname";
            anuncioNickname.Size = new Size(61, 15);
            anuncioNickname.TabIndex = 2;
            anuncioNickname.Text = "Nickname";
            // 
            // anuncioEdad
            // 
            anuncioEdad.AutoSize = true;
            anuncioEdad.Location = new Point(173, 186);
            anuncioEdad.Name = "anuncioEdad";
            anuncioEdad.Size = new Size(33, 15);
            anuncioEdad.TabIndex = 3;
            anuncioEdad.Text = "Edad";
            // 
            // botonSalir
            // 
            botonSalir.Location = new Point(117, 225);
            botonSalir.Name = "botonSalir";
            botonSalir.Size = new Size(117, 23);
            botonSalir.TabIndex = 4;
            botonSalir.Text = "Salir de programa";
            botonSalir.UseVisualStyleBackColor = true;
            botonSalir.Click += button1_Click;
            // 
            // botonIniciar
            // 
            botonIniciar.Location = new Point(330, 225);
            botonIniciar.Name = "botonIniciar";
            botonIniciar.Size = new Size(97, 23);
            botonIniciar.TabIndex = 5;
            botonIniciar.Text = "Iniciar Partida";
            botonIniciar.UseVisualStyleBackColor = true;
            botonIniciar.Click += botonIniciar_Click;
            // 
            // textoNombre
            // 
            textoNombre.Location = new Point(248, 85);
            textoNombre.Name = "textoNombre";
            textoNombre.Size = new Size(100, 23);
            textoNombre.TabIndex = 6;
            // 
            // textoNickname
            // 
            textoNickname.Location = new Point(248, 139);
            textoNickname.Name = "textoNickname";
            textoNickname.Size = new Size(100, 23);
            textoNickname.TabIndex = 7;
            // 
            // textoEdad
            // 
            textoEdad.Location = new Point(248, 183);
            textoEdad.Name = "textoEdad";
            textoEdad.Size = new Size(100, 23);
            textoEdad.TabIndex = 8;
            // 
            // gif2
            // 
            gif2.BackgroundImageLayout = ImageLayout.Center;
            gif2.BorderStyle = BorderStyle.FixedSingle;
            gif2.Image = Resources.Inugami_Korone_IdleAnim;
            gif2.Location = new Point(445, 130);
            gif2.Name = "gif2";
            gif2.Size = new Size(50, 60);
            gif2.SizeMode = PictureBoxSizeMode.AutoSize;
            gif2.TabIndex = 9;
            gif2.TabStop = false;
            // 
            // gif1
            // 
            gif1.BackgroundImageLayout = ImageLayout.Center;
            gif1.BorderStyle = BorderStyle.FixedSingle;
            gif1.Image = Resources.Hakos_Baelz_IdleAnim;
            gif1.Location = new Point(39, 120);
            gif1.Name = "gif1";
            gif1.Size = new Size(78, 70);
            gif1.SizeMode = PictureBoxSizeMode.AutoSize;
            gif1.TabIndex = 10;
            gif1.TabStop = false;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(560, 270);
            Controls.Add(gif1);
            Controls.Add(gif2);
            Controls.Add(textoEdad);
            Controls.Add(textoNickname);
            Controls.Add(textoNombre);
            Controls.Add(botonIniciar);
            Controls.Add(botonSalir);
            Controls.Add(anuncioEdad);
            Controls.Add(anuncioNickname);
            Controls.Add(anuncioNombre);
            Controls.Add(anuncioRegistro);
            Margin = new Padding(2);
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            Load += Registro_Load;
            ((System.ComponentModel.ISupportInitialize)gif2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gif1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label anuncioRegistro;
        private Label anuncioNombre;
        private Label anuncioNickname;
        private Label anuncioEdad;
        private Button botonSalir;
        private Button botonIniciar;
        private TextBox textoNombre;
        private TextBox textoNickname;
        private TextBox textoEdad;
        private PictureBox gif2;
        private PictureBox gif1;
    }
}
