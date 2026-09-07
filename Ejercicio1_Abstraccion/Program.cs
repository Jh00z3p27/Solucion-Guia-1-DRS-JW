// ==============================================================================
// GUÍA 1 - POO | EJERCICIO 1: ABSTRACCIÓN DE DATOS
// Autores: José Cerritos & Wilian Salinas (JW)
// ==============================================================================
// CONCEPTO TEÓRICO DE ABSTRACCIÓN:
// Consiste en ocultar la complejidad interna del objeto y exponer únicamente
// las operaciones esenciales al usuario a través de una interfaz pública.
// ==============================================================================

using System;

namespace Guia1_POO_JW.Ejercicio1
{
    public class CuentaBancariaJW
    {
        // Atributo privado que oculta el estado interno del saldo
        private decimal saldoJW;

        public CuentaBancariaJW(decimal saldoInicialJW = 0)
        {
            saldoJW = saldoInicialJW >= 0 ? saldoInicialJW : 0;
        }

        public void DepositarJW(decimal montoJW)
        {
            if (montoJW > 0)
            {
                saldoJW += montoJW;
                Console.WriteLine($"[JW-BANK] Depósito exitoso: ${montoJW:F2}");
            }
            else
            {
                Console.WriteLine("[JW-BANK Error] El monto a depositar debe ser mayor que cero.");
            }
        }

        public void RetirarJW(decimal montoJW)
        {
            if (montoJW <= 0)
            {
                Console.WriteLine("[JW-BANK Error] El monto a retirar debe ser mayor que cero.");
            }
            else if (montoJW > saldoJW)
            {
                Console.WriteLine($"[JW-BANK Error] Fondos insuficientes. Saldo disponible: ${saldoJW:F2}");
            }
            else
            {
                saldoJW -= montoJW;
                Console.WriteLine($"[JW-BANK] Retiro exitoso: ${montoJW:F2}");
            }
        }

        public decimal ObtenerSaldoJW()
        {
            return saldoJW;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJERCICIO 1: ABSTRACCIÓN (CUENTA BANCARIA) ===");

            CuentaBancariaJW cuentaJW = new CuentaBancariaJW(100.0m);
            Console.WriteLine($"Saldo inicial en cuenta: ${cuentaJW.ObtenerSaldoJW():F2}\n");

            cuentaJW.DepositarJW(50.0m);
            cuentaJW.RetirarJW(30.0m);
            cuentaJW.RetirarJW(500.0m); // Intento con saldo insuficiente

            Console.WriteLine($"\nSaldo final en cuenta: ${cuentaJW.ObtenerSaldoJW():F2}");
        }
    }
}