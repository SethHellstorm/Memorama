namespace Memorama
{
    partial class Bienvenida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            anuncioBienvenida = new Label();
            bIniciar = new Button();
            SuspendLayout();
            // 
            // anuncioBienvenida
            // 
            anuncioBienvenida.AutoSize = true;
            anuncioBienvenida.Location = new Point(310, 98);
            anuncioBienvenida.Name = "anuncioBienvenida";
            anuncioBienvenida.Size = new Size(143, 15);
            anuncioBienvenida.TabIndex = 0;
            anuncioBienvenida.Text = "Bienvenido al memorama";
            // 
            // bIniciar
            // 
            bIniciar.Location = new Point(334, 186);
            bIniciar.Name = "bIniciar";
            bIniciar.Size = new Size(75, 23);
            bIniciar.TabIndex = 1;
            bIniciar.Text = "Iniciar";
            bIniciar.UseVisualStyleBackColor = true;
            bIniciar.Click += bIniciar_Click;
            // 
            // Bienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bIniciar);
            Controls.Add(anuncioBienvenida);
            Name = "Bienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label anuncioBienvenida;
        private Button bIniciar;
    }
}