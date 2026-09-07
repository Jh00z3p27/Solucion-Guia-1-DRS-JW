// ==============================================================================
// GUÍA 1 - POO | EJERCICIO 3: HERENCIA SIMPLE
// Autores: José Cerritos & Wilian Salinas (JW)
// ==============================================================================
// CONCEPTO TEÓRICO DE HERENCIA SIMPLE:
// Permite a una clase derivada (hija) heredar los miembros y métodos de una clase
// base (padre), promoviendo la reutilización de código.
// ==============================================================================

using System;

namespace Guia1_POO_JW.Ejercicio3
{
    public class VehiculoJW
    {
        public string MarcaJW { get; set; }
        public string ModeloJW { get; set; }

        public VehiculoJW(string marcaJW, string modeloJW)
        {
            MarcaJW = marcaJW;
            ModeloJW = modeloJW;
        }

        public void ArrancarJW()
        {
            Console.WriteLine($"[JW MOTORS] El vehículo {MarcaJW} {ModeloJW} ha encendido.");
        }
    }

    public class CocheJW : VehiculoJW
    {
        public int NumPuertasJW { get; set; }

        public CocheJW(string marcaJW, string modeloJW, int numPuertasJW)
            : base(marcaJW, modeloJW)
        {
            NumPuertasJW = numPuertasJW;
        }

        public void AbrirMaleteroJW()
        {
            Console.WriteLine($"[JW MOTORS] Abriendo el maletero del coche ({NumPuertasJW} puertas).");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJERCICIO 3: HERENCIA SIMPLE ===");

            CocheJW miCocheJW = new CocheJW("Toyota", "Corolla", 4);

            miCocheJW.ArrancarJW();      // Método heredado de VehiculoJW
            miCocheJW.AbrirMaleteroJW(); // Método propio de CocheJW
        }
    }
}