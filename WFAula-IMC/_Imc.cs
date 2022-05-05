using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAula30_65
{
    internal class _Imc
    {
        double imc = 0;
        public _Imc()
        {



        }

        public string calcularIMC(double Peso, double Altura)
        {


            imc = (Peso / (Altura * Altura));
            
           // string resultado = imc.ToString();

            string status = "";
            if(imc <= 18.5)
            {
                status = "Magreza";
            }else if(imc <= 24.9){
                status = "Normal";

            }else if(imc <= 29.9)
            {
                status = "Sobrepeso";

            }else if(imc <= 34.9)
            {
                status = "Obesidade grau I";

            }else if(imc <= 39.9)
            {
                status = "Obesidade grau II";

            }
            else
            {
                status = "Obesidade grau III";

            }

            return imc.ToString("") + " - " + status; 
        }
    

    


    }
}
