using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        String mot = "focalise";
        int score = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == mot)
            {
                score++;
                textBox1.Text = "";
                label1.Text = "Score: " + score;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            Console.WriteLine("Durée:" + timer1);
            progressBar1.Value += 1;

            if(progressBar1.Value >= 100)
            {
                timer1.Stop();
                textBox1.Hide();
                MessageBox.Show("Challenge terminé avec un score de " + score);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = 0;
            label1.Text = "Score: " + score;
            progressBar1.Value = 0;
            timer1.Start();
            textBox1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logiciel créé par Mathieu-Rossetto.com");
        }
    }
}
