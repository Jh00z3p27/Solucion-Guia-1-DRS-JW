// ==============================================================================
// GUÍA 1 - POO | EJERCICIO 2: ENCAPSULACIÓN
// Autores: José Cerritos & Wilian Salinas (JW)
// ==============================================================================
// CONCEPTO TEÓRICO DE ENCAPSULACIÓN:
// Protege el estado de un objeto impidiendo el acceso directo o la modificación no
// autorizada de sus variables, utilizando propiedades (getters/setters) para validar.
// ==============================================================================

using System;

namespace Guia1_POO_JW.Ejercicio2
{
    public class EmpleadoJW
    {
        private decimal salarioJW;

        public string NombreJW { get; set; }

        public EmpleadoJW(string nombreJW, decimal salarioInicialJW)
        {
            NombreJW = nombreJW;
            SalarioJW = salarioInicialJW; // Usa la propiedad para validar
        }

        public decimal SalarioJW
        {
            get { return salarioJW; }
            set
            {
                if (value >= 0)
                {
                    salarioJW = value;
                    Console.WriteLine($"[RH JW] Salario actualizado de {NombreJW}: ${salarioJW:F2}");
                }
                else
                {
                    Console.WriteLine($"[JW Error Encapsulación] Salario negativo no permitido: ${value:F2}");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJERCICIO 2: ENCAPSULACIÓN (EMPLEADO) ===");

            EmpleadoJW empleadoJW = new EmpleadoJW("José Cerritos", 1200.00m);
            Console.WriteLine($"Empleado: {empleadoJW.NombreJW} | Salario actual: ${empleadoJW.SalarioJW:F2}\n");

            Console.WriteLine("Probando asignación de salario negativo (-400.00)...");
            empleadoJW.SalarioJW = -400.00m;

            Console.WriteLine("\nProbando asignación de salario válido (1500.00)...");
            empleadoJW.SalarioJW = 1500.00m;

            Console.WriteLine($"\nEstado final -> Empleado: {empleadoJW.NombreJW} | Salario: ${empleadoJW.SalarioJW:F2}");
        }
    }
}