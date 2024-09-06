using PoC_Herencia_Polimorfismo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC_Herencia_Polimorfismo.Clases
{
    internal class PerroPorInterfaz : IAnimal
    {
        private List<string> Onomatopeyas { get; set; }
        public PerroPorInterfaz()
        {
            Onomatopeyas = new List<string>
            {
                "Guau! por interfaz",
                "Wof por interfaz",
                "aro, aro, aro, aro! por interfaz",
                "auuuuuuuuuuuuuuu por interfaz",
                "grrrrrr por interfaz"
            };

        }
        public string EmitirOnomatopeya()
        {
            return Onomatopeyas[new Random().Next(0, Onomatopeyas.Count())];
        }
    }
}
