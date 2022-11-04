using System;
namespace Implicit_Explicit_Generics_Datetime_HW.Models
{
    public class Manat
    {
        public double Azn { get; set; }

        public Manat(double azn)
        {
            Azn = azn;
        }

        public static implicit operator Dollar(Manat manat)
        {
            return new Dollar(manat.Azn / 1.7);
        }
    }
}

