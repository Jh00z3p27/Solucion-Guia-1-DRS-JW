// ==============================================================================
// GUÍA 1 - POO | EJERCICIO 4: POLIMORFISMO
// Autores: José Cerritos & Wilian Salinas (JW)
// ==============================================================================
// CONCEPTO TEÓRICO DE POLIMORFISMO:
// Permite que objetos de distintas clases derivadas respondan al mismo método
// definido en la clase base de forma personalizada (`virtual` / `override`).
// ==============================================================================

using System;
using System.Collections.Generic;

namespace Guia1_POO_JW.Ejercicio4
{
    public class AnimalJW
    {
        public virtual string HacerSonidoJW()
        {
            return "Sonido genérico de animal.";
        }
    }

    public class PerroJW : AnimalJW
    {
        public override string HacerSonidoJW()
        {
            return "¡Guau! ¡Guau!";
        }
    }

    public class GatoJW : AnimalJW
    {
        public override string HacerSonidoJW()
        {
            return "¡Miau! ¡Miau!";
        }
    }

    class Program
    {
        static void EmitirSonidoPolimorficoJW(AnimalJW animalJW)
        {
            Console.WriteLine($"[JW ZOO] Sonido: {animalJW.HacerSonidoJW()}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== EJERCICIO 4: POLIMORFISMO ===");

            List<AnimalJW> animalesJW = new List<AnimalJW>
            {
                new PerroJW(),
                new GatoJW()
            };

            foreach (var animalJW in animalesJW)
            {
                EmitirSonidoPolimorficoJW(animalJW);
            }
        }
    }
}