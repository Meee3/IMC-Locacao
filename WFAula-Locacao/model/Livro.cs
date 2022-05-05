using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAula29_63.model
{
    internal class Livro
    {
        public string Titulo { get; set; }  
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string Isbn { get; set; }
        public int quantidadeLivro { get; set; }
        
        public Livro( string titulo, string autor, string editora, string isbn)
        {

            this.Titulo = titulo;
            this.Autor = autor;
            this.Editora = editora;
            this.Isbn = isbn;

        }

        public void cadastrarLivro()
        {

        }
        public void RemoverLivro()
        {

        }

        public override string ToString()
        {
            return $"Título: {Titulo}, Autor: {Autor}";
        }

    }
}
