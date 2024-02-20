using System;

namespace NutriAve
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAbrirPortaA = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbrirPortaA
            // 
            this.btnAbrirPortaA.Location = new System.Drawing.Point(53, 177);
            this.btnAbrirPortaA.Name = "btnAbrirPortaA";
            this.btnAbrirPortaA.Size = new System.Drawing.Size(137, 23);
            this.btnAbrirPortaA.TabIndex = 0;
            this.btnAbrirPortaA.Text = "AbrirPortaA";
            this.btnAbrirPortaA.UseVisualStyleBackColor = true;
            this.btnAbrirPortaA.Click += new System.EventHandler(this.btnAbrirPortaA_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(635, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "AbrirPortaB";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAbrirPortaB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "lblStatus";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAbrirPortaA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirPortaA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private EventHandler button1_Click;
        private EventHandler button2_Click;
        private EventHandler btnAbrirPortaA_Click_1;
    }
}

