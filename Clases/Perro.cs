using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC_Herencia_Polimorfismo.Clases
{
    internal class Perro : Animal
    {
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
            quidSum = "Perritus";
        }

        public string EmitirOnomatopeya(string onomatopeya)
        {
            return quidSum + " dice que vos escribiste: " + onomatopeya;
        }
    }
}
