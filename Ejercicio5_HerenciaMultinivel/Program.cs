// ==============================================================================
// GUÍA 1 - POO | EJERCICIO 5: HERENCIA MULTINIVEL
// Autores: José Cerritos & Wilian Salinas (JW)
// ==============================================================================
// CONCEPTO TEÓRICO DE HERENCIA MULTINIVEL:
// Jerarquía donde una clase deriva de otra clase que ya es derivada.
// Estructura: AnimalBaseJW (Nivel 1) -> MamiferoJW (Nivel 2) -> PerroMultinivelJW (Nivel 3).
// ==============================================================================

using System;

namespace Guia1_POO_JW.Ejercicio5
{
    public class AnimalBaseJW
    {
        public void ComerJW()
        {
            Console.WriteLine("[NIVEL 1 - ANIMAL] Este ser vivo se está alimentando.");
        }
    }

    public class MamiferoJW : AnimalBaseJW
    {
        public void AmamantarJW()
        {
            Console.WriteLine("[NIVEL 2 - MAMÍFERO] Alimentando crías con leche.");
        }
    }

    public class PerroMultinivelJW : MamiferoJW
    {
        public void LadrarJW()
        {
            Console.WriteLine("[NIVEL 3 - PERRO] El perro está ladrando.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJERCICIO 5: HERENCIA MULTINIVEL ===");

            PerroMultinivelJW perroJW = new PerroMultinivelJW();

            perroJW.ComerJW();     // Método heredado del Nivel 1
            perroJW.AmamantarJW(); // Método heredado del Nivel 2
            perroJW.LadrarJW();    // Método del Nivel 3
        }
    }
}