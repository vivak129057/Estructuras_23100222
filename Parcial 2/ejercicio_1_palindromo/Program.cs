using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> pila = new Stack<char>();
            string strPalabra;
            string CadenaInv = "";

            Console.WriteLine("Digite la palabra");
            strPalabra = Console.ReadLine();

            strPalabra= strPalabra.ToUpper();

            for (int i = 0; i < strPalabra.Length; i++)
            {
                pila.Push(strPalabra[i]);
            }

            while (pila.Count > 0)
            {
                char elemento = pila.Pop();
                CadenaInv += elemento;
            }

            if (strPalabra == CadenaInv)
            {
                Console.WriteLine("Es palindromo");
            }
            else
            {
                Console.WriteLine($"No es palindromo: {CadenaInv} y {strPalabra}");
            }



        }
    }
}
