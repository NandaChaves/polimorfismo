using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
     class Atendente : Imposto
    {
        public override void ValeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto atendente do vale alimentação € " + (salario * 0.12));
        }
    }
}
