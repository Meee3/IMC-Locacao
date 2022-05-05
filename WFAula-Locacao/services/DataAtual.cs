using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAula29_63.services
{
    public  class DataAtual
    {
         DateTime dataTime;

        public  string MinhaHoraAtual( )
        {
           return $"Data: {DateTime.Now}";
        }
    }
}
