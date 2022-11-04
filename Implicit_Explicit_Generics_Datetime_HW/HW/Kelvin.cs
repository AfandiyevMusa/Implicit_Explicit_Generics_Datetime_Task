using System;
namespace Implicit_Explicit_Generics_Datetime_HW.HW
{
    public class Kelvin
    {
        public double Degree { get; set; }

        public Kelvin(double degree)
        {
            Degree = degree;
        }

        public static implicit operator Celsius(Kelvin deg)
        {
            return new Celsius(deg.Degree - 273);
        }
    }
}

