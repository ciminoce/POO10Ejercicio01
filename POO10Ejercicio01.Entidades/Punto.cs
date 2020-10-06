using System;

namespace POO10Ejercicio01.Entidades
{
    public class Punto:ICloneable
    {
        public int CoordenadaX { get; set; }
        public int CoordenadaY { get; set; }

        public override string ToString()
        {
            return $"({CoordenadaX},{CoordenadaY})";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override bool Equals(object obj)
        {
            if (obj==null || !(obj is Punto))
            {
                return false;
            }

            return this.CoordenadaX == ((Punto) obj).CoordenadaX &&
                   this.CoordenadaY == ((Punto) obj).CoordenadaY;
        }

        public override int GetHashCode()
        {
            return this.CoordenadaX.GetHashCode()
                   +this.CoordenadaY.GetHashCode();
        }
    }

    
}
