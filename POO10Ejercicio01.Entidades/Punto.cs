using System;
using POO10Ejercicio01.Entidades.Enums;

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

        public Cuadrante GetCuadrante()
        {
            if (this.CoordenadaX>=0 && this.CoordenadaY>=0)
            {
                return Cuadrante.PrimerCuadrante;
            }else if (this.CoordenadaX<=0 && this.CoordenadaY>=0)
            {
                return Cuadrante.SegundoCuadrante;
            }else if (this.CoordenadaX<=0 && this.CoordenadaY<=0)
            {
                return Cuadrante.TercerCuadrante;
            }
            else
            {
                return Cuadrante.CuartoCuadrante;
            }
        }

        public double GetDistanciaAlOrigen()
        {
            return Math.Sqrt(Math.Pow(this.CoordenadaX, 2)
                             + Math.Pow(this.CoordenadaY, 2));
        }
    }

    
}
