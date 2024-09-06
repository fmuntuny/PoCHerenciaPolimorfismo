using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC_Herencia_Polimorfismo.Clases
{
    internal class Animal
    {
        public virtual string EmitirOnomatopeya()
        {
            return "Onomatopeya caracteristica de su especie.";
        }
    }
}
