using System;
using System.Collections.Generic;
using System.IO;
using POO10Ejercicio01.Entidades;

namespace POO10Ejercicio01.Datos
{
    public class RepositorioDePuntos
    {
        public List<Punto> ListaPuntos { get; set; }=new List<Punto>();
        public bool EstaModificado { get; set; } = false;

        private readonly string _archivo = Environment.CurrentDirectory + "\\Puntos.csv";
        public RepositorioDePuntos()
        {
            LeerDatosDelArchivo();
        }

        private void LeerDatosDelArchivo()
        {
            StreamReader lector=new StreamReader(_archivo);
            while (!lector.EndOfStream)
            {
                string linea = lector.ReadLine();
                Punto punto = ConstruirPunto(linea);
                ListaPuntos.Add(punto);
            }
            lector.Close();
        }

        private Punto ConstruirPunto(string linea)
        {
            var campos = linea.Split(',');
            return new Punto
            {
                CoordenadaX = int.Parse(campos[0]),
                CoordenadaY = int.Parse(campos[1])
            };
        }

        public void GuardarDatosEnArchivo()
        {
            StreamWriter escritor=new StreamWriter(_archivo);
            foreach (var punto in ListaPuntos)
            {
                string linea = ConstruirLinea(punto);
                escritor.WriteLine(linea);
            }
            escritor.Close();
        }

        private string ConstruirLinea(Punto punto)
        {
            return $"{punto.CoordenadaX},{punto.CoordenadaY}";
        }

        public int GetCantidad()
        {
            return ListaPuntos.Count;
        }

        public List<Punto> GetLista()
        {
            return ListaPuntos;
        }

        public void Agregar(Punto punto)
        {
            ListaPuntos.Add(punto);
            EstaModificado = true;
        }

        public void Borrar(Punto punto)
        {
            ListaPuntos.Remove(punto);
            EstaModificado = true;
        }

        public bool ExistePunto(Punto punto)
        {
            return ListaPuntos.Contains(punto);
        }

        public void Modificar(Punto punto, Punto puntoAuxiliar)
        {
            var iIndex = ListaPuntos.IndexOf(punto);
            ListaPuntos[iIndex] = puntoAuxiliar;
        }
    }
}
