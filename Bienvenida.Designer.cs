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
            SuspendLayout();
            // 
            // anuncioRegistro
            // 
            anuncioRegistro.AutoSize = true;
            anuncioRegistro.Location = new Point(341, 65);
            anuncioRegistro.Margin = new Padding(4, 0, 4, 0);
            anuncioRegistro.Name = "anuncioRegistro";
            anuncioRegistro.Size = new Size(77, 25);
            anuncioRegistro.TabIndex = 0;
            anuncioRegistro.Text = "Registro";
            // 
            // anuncioNombre
            // 
            anuncioNombre.AutoSize = true;
            anuncioNombre.Location = new Point(247, 147);
            anuncioNombre.Margin = new Padding(4, 0, 4, 0);
            anuncioNombre.Name = "anuncioNombre";
            anuncioNombre.Size = new Size(78, 25);
            anuncioNombre.TabIndex = 1;
            anuncioNombre.Text = "Nombre";
            // 
            // anuncioNickname
            // 
            anuncioNickname.AutoSize = true;
            anuncioNickname.Location = new Point(247, 237);
            anuncioNickname.Margin = new Padding(4, 0, 4, 0);
            anuncioNickname.Name = "anuncioNickname";
            anuncioNickname.Size = new Size(90, 25);
            anuncioNickname.TabIndex = 2;
            anuncioNickname.Text = "Nickname";
            // 
            // anuncioEdad
            // 
            anuncioEdad.AutoSize = true;
            anuncioEdad.Location = new Point(247, 310);
            anuncioEdad.Margin = new Padding(4, 0, 4, 0);
            anuncioEdad.Name = "anuncioEdad";
            anuncioEdad.Size = new Size(52, 25);
            anuncioEdad.TabIndex = 3;
            anuncioEdad.Text = "Edad";
            // 
            // botonSalir
            // 
            botonSalir.Location = new Point(167, 375);
            botonSalir.Margin = new Padding(4, 5, 4, 5);
            botonSalir.Name = "botonSalir";
            botonSalir.Size = new Size(167, 38);
            botonSalir.TabIndex = 4;
            botonSalir.Text = "Salir de programa";
            botonSalir.UseVisualStyleBackColor = true;
            botonSalir.Click += button1_Click;
            // 
            // botonIniciar
            // 
            botonIniciar.Location = new Point(471, 375);
            botonIniciar.Margin = new Padding(4, 5, 4, 5);
            botonIniciar.Name = "botonIniciar";
            botonIniciar.Size = new Size(139, 38);
            botonIniciar.TabIndex = 5;
            botonIniciar.Text = "Iniciar Partida";
            botonIniciar.UseVisualStyleBackColor = true;
            botonIniciar.Click += botonIniciar_Click;
            // 
            // textoNombre
            // 
            textoNombre.Location = new Point(354, 142);
            textoNombre.Margin = new Padding(4, 5, 4, 5);
            textoNombre.Name = "textoNombre";
            textoNombre.Size = new Size(141, 31);
            textoNombre.TabIndex = 6;
            // 
            // textoNickname
            // 
            textoNickname.Location = new Point(354, 232);
            textoNickname.Margin = new Padding(4, 5, 4, 5);
            textoNickname.Name = "textoNickname";
            textoNickname.Size = new Size(141, 31);
            textoNickname.TabIndex = 7;
            // 
            // textoEdad
            // 
            textoEdad.Location = new Point(354, 305);
            textoEdad.Margin = new Padding(4, 5, 4, 5);
            textoEdad.Name = "textoEdad";
            textoEdad.Size = new Size(141, 31);
            textoEdad.TabIndex = 8;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textoEdad);
            Controls.Add(textoNickname);
            Controls.Add(textoNombre);
            Controls.Add(botonIniciar);
            Controls.Add(botonSalir);
            Controls.Add(anuncioEdad);
            Controls.Add(anuncioNickname);
            Controls.Add(anuncioNombre);
            Controls.Add(anuncioRegistro);
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenida";
            Load += Registro_Load;
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
    }
}
