using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAula30_65
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Imc imc = new Imc();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
          

            
   
          
        }

        private void txtBoxPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorPeso = double.Parse(txtBoxPeso.Text);
            double valorAltura = double.Parse(txtBoxAltura.Text);

           

            lblResultado.Text = $"Resultado: {imc.mensagemStatus(imc.calcularIMC(valorPeso, valorAltura))}";
            //lblResultado.Text = imc.calcularIMC(valorPeso, valorAltura).ToString("F2");    
        }
    }
}
