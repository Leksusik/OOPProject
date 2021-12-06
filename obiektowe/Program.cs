using System;
using System.Collections.Generic;

namespace obiektowe
{
    class Program
    {
        static void Nawiasy()
        {
            string napis = "( ( ) )()((";
            Stack<char> StosOtwarc = new Stack<char>();
            char buffer;
            /*int licznikOkraglych = 0,
                licznikKwadratowych;*/
            foreach (char znak in napis)
            {
                if (znak == '(')
                {
                    StosOtwarc.Push('o');
                }
                else if (znak == ')')
                {
                    if (StosOtwarc.TryPop(out buffer))
                    {

                    }
                    else {
                        Console.WriteLine("Niepoprawne domykanie");
                        break; }
                }
            }
            if (StosOtwarc.TryPeek(out buffer))
            {
                Console.WriteLine("Zostaly otwarte nawiasy");
            }
            else
            {
                Console.WriteLine("Git");
            }
        }
        static void TestStosu()
        {
            Stack<char> Stos = new Stack<char>();
            Stos.Push('z');

            char buffer;
            Console.WriteLine("Mozna cos zrzucic ze stosu? {0}\nZrzucona wartosc: {1}", Stos.TryPop(out buffer),buffer);
            Console.WriteLine("Mozna cos zrzucic ze stosu? {0}\nZrzucona wartosc: {1}", Stos.TryPop(out buffer), buffer);
        }
        static void Main(string[] args)
        {
            Nawiasy();
        }
    }
}
