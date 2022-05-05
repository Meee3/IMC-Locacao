using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAula29_63.Telas;
using WFAula29_63.Telas.Adm;
using WFAula29_63.Telas.User;

namespace WFAula29_63
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alocar alocar = new Alocar();
            alocar.Show();
            listBox1User = cadastrarLivro[0];

        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            Devolver devolver = new Devolver();
            devolver.Show();
        }

        private void btnConsultarUser_Click(object sender, EventArgs e)
        {
            UserConsultar userConsultar = new UserConsultar();
            userConsultar.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarLivro cadastrarLivro = new CadastrarLivro();
            cadastrarLivro.Show();
        }
    }
}
