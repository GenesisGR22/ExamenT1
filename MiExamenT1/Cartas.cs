using System;
using System.Collections.Generic;
using System.Text;

namespace MiExamenT1
{
    public class Cartas
    {
        public Palo palo;
        public Number number;
        public Cartas(Palo s, Number n)
        {
            palo = s;
            number = n;
        }
    }
}
