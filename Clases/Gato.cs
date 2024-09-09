using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC_Herencia_Polimorfismo.Clases
{
    internal class Gato : Animal
    {
        public Gato()
        {
            Onomatopeyas = new List<string>
            {
                "Miau!",
                "jjjjjjjjjj",
                "raul",
                "raquel",
                "mau"
            };
            quidSum = "Michigan";
        }
        public string EmitirOnomatopeya(string onomatopeya)
        {
            return quidSum + " piensa que decir '" + onomatopeya + "' es una gilada.";
        }
    }
}
