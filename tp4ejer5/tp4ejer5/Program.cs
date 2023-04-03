using System;
//Escriba un programa que pida 3 notas y valide si esas notas están entre 1 y 10. Si están entre esos
//parámetros se debe poner en verdadero una variable de tipo lógico y si no ponerla en falso. Al final el
//programa debe decir si las 3 notas son correctas usando la variable de tipo lógico.

namespace tp4ejer5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3;
            bool validas;
            Console.WriteLine("ingrese 3 notas: ");
            nota1 = int.Parse(Console.ReadLine());
            nota2 = int.Parse(Console.ReadLine());
            nota3 = int.Parse(Console.ReadLine());
            validas = (nota1 >= 1 && nota1 <= 10) && (nota2 >= 1 && nota2 <= 10) && (nota3 >= 1 && nota3 <= 10);
            if (validas = (nota1 >= 1 && nota1 <= 10) && (nota2 >= 1 && nota2 <= 10) && (nota3 >= 1 && nota3 <= 10))
                {
                validas = true;

            }
            else
            {
                validas &= false;
            }
            if (validas==true)
            {
                Console.WriteLine("Las notas son validas");
            }
            else
            {

                Console.WriteLine("ERROR!");
            }
            Console.ReadKey();
        }
    }
}
