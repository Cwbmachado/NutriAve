using System;
using System.Windows.Forms;

namespace NutriAve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Definindo o tamanho do formulário
            this.Width = 1024; 
            this.Height = 768; 
        }


        private void btnAbrirPortaA_Click(object sender, EventArgs e)
        {
            AbrirPortaA();
        }

        private void btnAbrirPortaB_Click(object sender, EventArgs e)
        {
            AbrirPortaB();
        }

        private void btnAbrirAmbasPortas_Click(object sender, EventArgs e)
        {
            int contador = 10; // Inicia o contador em 10 segundos

            // Define o texto do label para mostrar que ambas as portas estão abrindo
            label1.Text = $"Portas A e B abrindo para alimentar as galinhas... {contador} segundos restantes.";

            // Configura um timer para contar de 1 em 1 segundo
            var timerAmbas = new Timer { Interval = 1000 }; // 1 segundo

            timerAmbas.Tick += (s, args) =>
            {
                contador--; // Decrementa o contador a cada tick
                if (contador > 0)
                {
                    // Atualiza o texto do label para mostrar os segundos restantes
                    label1.Text = $"Portas A e B abrindo para alimentar as galinhas... {contador} segundos restantes.";
                }
                else
                {
                    // Atualiza o texto do label após 10 segundos para indicar que ambas as portas estão fechadas
                    label1.Text = "Portas A e B fechadas.";

                    // Para e descarta o timer
                    timerAmbas.Stop();
                    timerAmbas.Dispose();
                }
            };

            // Inicia o timer
            timerAmbas.Start();
        }


        private void AbrirPortaA()
        {
            int contadorA = 10; // Inicia o contador em 10 segundos para a Porta A
            label1.Text = $"Porta A abrindo para alimentar as galinhas... {contadorA} segundos restantes.";

            var timerA = new Timer { Interval = 1000 }; // 1 segundo
            timerA.Tick += (s, args) =>
            {
                contadorA--; // Decrementa o contador a cada tick
                if (contadorA > 0)
                {
                    label1.Text = $"Porta A abrindo para alimentar as galinhas... {contadorA} segundos restantes.";
                }
                else
                {
                    label1.Text = "Porta A fechada.";
                    timerA.Stop();
                    timerA.Dispose();
                }
            };
            timerA.Start();
        }

        private void AbrirPortaB()
        {
            int contadorB = 10; // Inicia o contador em 10 segundos para a Porta B
            label1.Text = $"Porta B abrindo para alimentar as galinhas... {contadorB} segundos restantes.";

            var timerB = new Timer { Interval = 1000 }; // 1 segundo
            timerB.Tick += (s, args) =>
            {
                contadorB--; // Decrementa o contador a cada tick
                if (contadorB > 0)
                {
                    label1.Text = $"Porta B abrindo para alimentar as galinhas... {contadorB} segundos restantes.";
                }
                else
                {
                    label1.Text = "Porta B fechada.";
                    timerB.Stop();
                    timerB.Dispose();
                }
            };
            timerB.Start();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
