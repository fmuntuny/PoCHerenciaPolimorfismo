using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC_Herencia_Polimorfismo.Clases
{
    internal class Perro : Animal
    {
        private List<string> Onomatopeyas { get; set; }
        public Perro()
        {
            Onomatopeyas = new List<string>
            {
                "Guau!",
                "Wof",
                "aro, aro, aro, aro!",
                "auuuuuuuuuuuuuuu",
                "grrrrrr"
            };
        }
        public override string EmitirOnomatopeya()
        {
            return Onomatopeyas[new Random().Next(0, Onomatopeyas.Count())];
        }

        public string EmitirOnomatopeya(string onomatopeya)
        {
            return "Perritus dice: " + onomatopeya;
        }
    }
}
