using Entitati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca {
    public class CarteMgr {
        public Carte AddCarte() {
            Console.WriteLine("Titlu: ");
            string titlu = Console.ReadLine();
            Console.WriteLine("Autor: ");
            string autor = Console.ReadLine();
            Console.WriteLine("Nr Exemplare: ");
            int nrElem = int.Parse(Console.ReadLine());
            return new Carte(titlu, autor, nrElem);
        }
    }
}
