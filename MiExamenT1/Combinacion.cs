using System;
using System.Collections.Generic;
using System.Text;

namespace MiExamenT1
{
    public enum Combinacion
    {
        Ninguno,
        Par,
        Dos_pares,
        Tres_de_un_tipo,
        Derecho,
        Escalera,
        Casa_llena,
        Cuatro_de_un_tipo,
        Escalera_de_color,
        Escalera_Real,
    }
    public enum Palo
    {
        Espadas,
        Corazones,
        Trebol,
        Diamantes
    }
    public enum Number : int
    {
        Ace = 1,
        Dos = 2,
        Tres = 3,
        Cuatro = 4,
        Cinco = 5,
        Seis = 6,
        Siete = 7,
        Ocho = 8,
        Nueve = 9,
        Diez = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }
}
