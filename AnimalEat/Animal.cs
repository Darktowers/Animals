using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalEat
{
    public class Animal
    {
        public class comer
        {

        }
        static void Main(string[] args)
        {

            var pez1 = new Pez();
            var mamifero1 = new Mamifero();
            var gato1 = new Gato();
            mamifero1.comer();
            gato1.comer();
            Console.ReadKey();
        }
    }
}
