using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAula29_63.model;
using WFAula29_63.services;

namespace WFAula29_63.Telas.Adm
{
    public partial class CadastrarLivro : Form
    {
    

        public CadastrarLivro()
        {
            InitializeComponent();
        }

        List<Livro> cadastrarLivro = new List<Livro>();

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e )
        {
            
            
            cadastrarLivro.Add(new Livro(txtTitulo.Text, txtAutor.Text, txtEditora.Text, txtISBN.Text));

            foreach (object a in cadastrarLivro)
            {
                ListBox1.Items.Add(a);
            }

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDataAtualAdm_Click(object sender, EventArgs e)
        {
            DataAtual data = new DataAtual();
            lblDataAtualAdm.Text = data.MinhaHoraAtual();




        }

        private void CadastrarLivro_Load(object sender, EventArgs e)
        {
            _ = lblDataAtualAdm.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
