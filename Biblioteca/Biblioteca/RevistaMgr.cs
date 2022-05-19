using Entitati;
using System;

namespace Biblioteca {
    public class RevistaMgr {
        public Revista AddRevista() {
            Console.WriteLine("Titlu: ");
            string titlu = Console.ReadLine();
            Console.WriteLine("Numar: ");
            int nr = int.Parse(Console.ReadLine());
            Console.WriteLine("Nr Exemplare: ");
            int nrEx = int.Parse(Console.ReadLine());
            Console.WriteLine("Data: ");
            Console.WriteLine("Zi: ");
            int zi = int.Parse(Console.ReadLine());
            Console.WriteLine("Luna: ");
            int luna = int.Parse(Console.ReadLine());
            Console.WriteLine("An: ");
            int an = int.Parse(Console.ReadLine());
            return new Revista(titlu, nr, nrEx, new Data(zi, luna, an));
        }
    }
}
