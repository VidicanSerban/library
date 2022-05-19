using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitati {
    public class Carte : Element {
        public string Autor { get; set; }

        public Carte(string titlu, string autor, int nrElem)
            :base(titlu, nrElem) {
            Autor = autor;
        }

        public override string Descriere() {
            return $"{Titlu}: {Autor} Numar exemplare {NrElemente}";
        }
    }
}
