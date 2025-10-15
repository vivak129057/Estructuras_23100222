using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2_corchetes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa una operación aritmética:");
            string expresion = Console.ReadLine();

            if (ValidarBalance(expresion))
                Console.WriteLine("La expresión está bien escrita.");
            else
                Console.WriteLine("La expresión NO está bien escrita.");

            Console.ReadKey();
        }

        static bool ValidarBalance(string expresion)
        {
            Stack<char> pila = new Stack<char>();

            foreach (char C in expresion)
            {

                if (C == '(' || C == '[' || C == '{')
                {
                    pila.Push(C);
                }
                else if (C == ')' || C == ']' || C == '}')
                {
                    if (pila.Count == 0)
                        return false;

                    char tope = pila.Pop();

                    if (!Coinciden(tope, C))
                        return false;
                }
            }
            return pila.Count == 0;
        }

        static bool Coinciden(char apertura, char cierre)
        {
            return (apertura == '(' && cierre == ')') ||
                    (apertura == '[' && cierre == ']') ||
                    (apertura == '{' && cierre == '}');
        }
    }
}
