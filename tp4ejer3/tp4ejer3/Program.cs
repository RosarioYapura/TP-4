using System;
using System.IO;
//Realizar un programa que pida introducir solo frases o palabras de 6 caracteres. Si el usuario ingresa una
//frase o palabra de 6 caracteres se deberá de imprimir un mensaje por pantalla que diga “CORRECTO”, en
//caso contrario, se deberá imprimir “INCORRECTO”.

namespace tp4ejer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;
            Console.WriteLine("ingresa una frase o caracter de 6 caracteres: ");
            frase = Console.ReadLine();
            if ((frase.Length) == 6)
            {
                Console.WriteLine("CORRECTO");
            }
            else
            {
                Console.WriteLine("INCORRECTO");
            }
            Console.ReadKey();
        }
    }
}
