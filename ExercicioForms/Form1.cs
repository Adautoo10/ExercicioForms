using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Somar_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);

            int resultado = n1 + n2;

            lblResultado.Text = resultado.ToString();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = ""; 
            lblResultado.Text = "";

            lblResultado.Text = "0";

            N1.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

       
    }
}
