using Entitati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca {
    public class Biblioteca {
        private static List<Element> elemente = new List<Element>();

        public void AddElement(Element elem) {
            elemente.Add(elem);
        }

        public void AddElemente(params Element[] elem) {
            for(int i = 0; i < elem.Length; i++) {
                AddElement(elem[i]);
            }
        }

        public static void PrintLista() {
            foreach(var elem in elemente) {
                Console.WriteLine(elem.Descriere());
            }
        }

        public static void UseLinq(string titlu) {
            var element = elemente.Where(e => e.Titlu == titlu).FirstOrDefault();
            if (element != null)
            {
                if (element.NrElemente > 1) element.NrElemente--;
                else
                    elemente.Remove(element);
            }
            else
            {
                Console.WriteLine("Cartea cu titlul " + titlu + " nu exista!");
            }
        }
    }
}
