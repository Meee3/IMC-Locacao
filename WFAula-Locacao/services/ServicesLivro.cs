using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFAula29_63.model;

namespace WFAula29_63
{

    internal interface ServicesLivro
    {
        string Alocar();
        int quantidadeDias();
        int DevolverEmDias();
        int CalcularDias();
        double CalcularValores();

    }
}
