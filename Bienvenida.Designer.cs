using Memorama.Properties;

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
            gif3 = new PictureBox();
            gif1 = new PictureBox();
            gif2 = new PictureBox();
            gif4 = new PictureBox();
            gif5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gif3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gif1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gif2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gif4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gif5).BeginInit();
            SuspendLayout();
            // 
            // anuncioBienvenida
            // 
            anuncioBienvenida.AutoSize = true;
            anuncioBienvenida.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            anuncioBienvenida.Location = new Point(238, 78);
            anuncioBienvenida.Name = "anuncioBienvenida";
            anuncioBienvenida.Size = new Size(276, 30);
            anuncioBienvenida.TabIndex = 0;
            anuncioBienvenida.Text = "Bienvenido al memorama";
            // 
            // bIniciar
            // 
            bIniciar.Location = new Point(309, 212);
            bIniciar.Name = "bIniciar";
            bIniciar.Size = new Size(143, 50);
            bIniciar.TabIndex = 1;
            bIniciar.Text = "Iniciar";
            bIniciar.UseVisualStyleBackColor = true;
            bIniciar.Click += bIniciar_Click;
            // 
            // gif3
            // 
            gif3.BackgroundImageLayout = ImageLayout.Center;
            gif3.BorderStyle = BorderStyle.FixedSingle;
            gif3.Image = Resources.AZKi_IdleAnim;
            gif3.Location = new Point(78, 329);
            gif3.Name = "gif3";
            gif3.Size = new Size(50, 60);
            gif3.SizeMode = PictureBoxSizeMode.AutoSize;
            gif3.TabIndex = 2;
            gif3.TabStop = false;
            // 
            // gif1
            // 
            gif1.BackgroundImageLayout = ImageLayout.Center;
            gif1.BorderStyle = BorderStyle.FixedSingle;
            gif1.Image = Resources.Aki_Rosenthal_IdleAnim;
            gif1.Location = new Point(60, 66);
            gif1.Name = "gif1";
            gif1.Size = new Size(68, 68);
            gif1.SizeMode = PictureBoxSizeMode.AutoSize;
            gif1.TabIndex = 3;
            gif1.TabStop = false;
            // 
            // gif2
            // 
            gif2.BackgroundImageLayout = ImageLayout.Center;
            gif2.BorderStyle = BorderStyle.FixedSingle;
            gif2.Image = Resources.Ayunda_Risu_IdleAnim;
            gif2.Location = new Point(634, 78);
            gif2.Name = "gif2";
            gif2.Size = new Size(64, 68);
            gif2.SizeMode = PictureBoxSizeMode.AutoSize;
            gif2.TabIndex = 4;
            gif2.TabStop = false;
            // 
            // gif4
            // 
            gif4.BackgroundImageLayout = ImageLayout.Center;
            gif4.BorderStyle = BorderStyle.FixedSingle;
            gif4.Image = Resources.Calliope_Mori_IdleAnim;
            gif4.Location = new Point(623, 291);
            gif4.Name = "gif4";
            gif4.Size = new Size(88, 98);
            gif4.SizeMode = PictureBoxSizeMode.AutoSize;
            gif4.TabIndex = 5;
            gif4.TabStop = false;
            // 
            // gif5
            // 
            gif5.BackgroundImageLayout = ImageLayout.Center;
            gif5.BorderStyle = BorderStyle.FixedSingle;
            gif5.Image = Resources.IRyS_IdleAnim;
            gif5.Location = new Point(341, 329);
            gif5.Name = "gif5";
            gif5.Size = new Size(64, 66);
            gif5.SizeMode = PictureBoxSizeMode.AutoSize;
            gif5.TabIndex = 6;
            gif5.TabStop = false;
            // 
            // Bienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(gif5);
            Controls.Add(gif4);
            Controls.Add(gif2);
            Controls.Add(gif1);
            Controls.Add(gif3);
            Controls.Add(bIniciar);
            Controls.Add(anuncioBienvenida);
            Name = "Bienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenida";
            Load += Bienvenida_Load;
            ((System.ComponentModel.ISupportInitialize)gif3).EndInit();
            ((System.ComponentModel.ISupportInitialize)gif1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gif2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gif4).EndInit();
            ((System.ComponentModel.ISupportInitialize)gif5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label anuncioBienvenida;
        private Button bIniciar;
        private PictureBox gif3;
        private PictureBox gif1;
        private PictureBox gif2;
        private PictureBox gif4;
        private PictureBox gif5;
    }
}