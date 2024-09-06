using PoC_Herencia_Polimorfismo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC_Herencia_Polimorfismo.Clases
{
    internal class GatoPorInterfaz : IAnimal
    {
        private List<string> Onomatopeyas { get; set; }
        public GatoPorInterfaz()
        {
            Onomatopeyas = new List<string>
            {
                "Miau! por interfaz",
                "jjjjjjjjjj por interfaz",
                "raul por interfaz",
                "raquel por interfaz",
                "mau por interfaz"
            };

        }
        public string EmitirOnomatopeya()
        {
            return Onomatopeyas[new Random().Next(0, Onomatopeyas.Count())];
        }
    }
}
