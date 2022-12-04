using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Name} e tenho {Age} anos.");
            Console.ReadKey();
        }
    }
}
