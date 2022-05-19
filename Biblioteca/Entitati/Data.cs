using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitati {
    public class Data {
        public int Zi { get; set; }
        public int Luna { get; set; }
        public int An { get; set; }

        public Data(int zi, int luna, int an) {
            Zi = zi;
            Luna = luna;
            An = an;
        }
    }
}

