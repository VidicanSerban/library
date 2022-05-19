using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitati
{
    public abstract class Element
    {
        public string Titlu { get; set; }
        public int NrElemente { get; set; }

        public Element(string titlu, int nrElemente) {
            Titlu = titlu;
            NrElemente = nrElemente;
        }


        public abstract string Descriere();
    }
}
