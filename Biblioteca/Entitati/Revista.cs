using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitati {
    public class Revista : Element {
        public int Numar { get; set; }
        public Data Data { get; set; }

        public Revista(string titlu, int nr, int nrElem, Data data)
            :base(titlu, nrElem){
            Numar = nr;
            Data = data;
        }

        public override string Descriere() {
            return $"{Titlu}: {Numar} din data de {Data.Zi}-{Data.Luna}-{Data.An} Numar exemplare {NrElemente}";
        }
    }
}
