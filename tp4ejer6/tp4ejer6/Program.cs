using System;
using System.Security.Cryptography.X509Certificates;
//- Escriba un programa que pida una frase o palabra y valide si la primera letra de esa frase es una ‘A’. Si la
//primera letra es una ‘A’, se deberá de imprimir un mensaje por pantalla que diga “CORRECTO”, en caso
//contrario, se deberá imprimir “INCORRECTO”.

namespace tp4ejer6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;
            Console.WriteLine("Escribe una frase que comience por la letra A o a");
            frase= Console.ReadLine();
            if ((frase.Substring(0, 1).Equals("A"))||(frase.Substring(0, 1).Equals("a")))
            {
                Console.WriteLine(" CORRECTO: " + frase + " \n  tiene la letra A como 1er caracter  \n");
            }
            else
            {
                Console.WriteLine(" INCORRECTO: " + frase + " \n  -  NO tiene la latra A como 1er caracter  \n");
            }
            Console.ReadKey();
        }
    }
}
