using System;
using System.Windows.Forms;

namespace NutriAve
{
    public partial class Form1 : Form
    {
        public object lblStatus { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirPortaA_Click(object sender, EventArgs e)
        {
            label1.Text = "Porta A abrindo para alimentar as galinhas...";
            var timer = new Timer { Interval = 10000 }; // 10 segundos
            timer.Tick += (s, args) =>
            {
                label1.Text = "Porta A fechada.";
                timer.Stop();
            };
            timer.Start();
        }

        private void btnAbrirPortaB_Click(object sender, EventArgs e)
        {
            label1.Text = "Porta B abrindo para alimentar as galinhas...";
            var timer = new Timer { Interval = 10000 }; // 10 segundos
            timer.Tick += (s, args) =>
            {
                label1.Text = "Porta B fechada.";
                timer.Stop();
            };
            timer.Start();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
