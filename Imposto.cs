using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Imposto
    {
        public virtual void ValeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto padrao do vale alimentação €"+ (salario*0.1));
        }
        public void ValeTransporte(double salario)
        {
            Console.WriteLine("Desconto padrão do vale transporte € "+ (salario*0.06));
        }

    }
}
