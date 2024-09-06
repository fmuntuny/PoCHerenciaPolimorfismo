using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC_Herencia_Polimorfismo.Clases
{
    internal class Gato : Animal
    {
        private List<string> Onomatopeyas { get; set; }
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
        }
        public override string EmitirOnomatopeya()
        {
            return Onomatopeyas[new Random().Next(0, Onomatopeyas.Count())];
        }
        public string EmitirOnomatopeya(string onomatopeya)
        {
            return "Michigan dice: " + onomatopeya;
        }
    }
}
