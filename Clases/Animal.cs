using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC_Herencia_Polimorfismo.Clases
{
    internal class Animal
    {
        protected string quidSum { get; set; }
        protected List<string> Onomatopeyas { get; set; }
        public virtual string EmitirOnomatopeya()
        {
            return Onomatopeyas[new Random().Next(0, Onomatopeyas.Count())];
        }
    }
}
