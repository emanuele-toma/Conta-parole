﻿using System;

namespace Conta_parole
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroParole = default, caratteri = default;
            string paragrafo = default;
            string messaggio = default;
            ConsoleKeyInfo tasto = default;
            bool esci = default;

            Console.Title = "Conta parole";
            Console.WriteLine("Inserisci il testo qui sotto, quando hai finito clicca F1");
            do
            {
                tasto = Console.ReadKey();
                if (tasto.Key == ConsoleKey.F1 && paragrafo != null)
                {
                    esci = true;
                }
                else if (tasto.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    paragrafo += " \n";
                }
                else if (tasto.Key == ConsoleKey.Backspace && paragrafo != null && paragrafo.Length > 0)
                {
                    paragrafo = paragrafo.Remove(paragrafo.Length - 1);
                    Console.Write(" \b");

                }
                else
                {
                    paragrafo += tasto.KeyChar.ToString();
                }
            } while (esci == false);

            caratteri = paragrafo.ToCharArray().Length;
            numeroParole = paragrafo.Split(" ").Length;
            if (paragrafo.Split(" ")[numeroParole - 1] == "\n")
            {
                caratteri--;
                numeroParole--;
            }
            if (numeroParole == 1) messaggio = $"C'è {numeroParole} parola e {caratteri} caratteri";
            if (numeroParole > 1) messaggio = $"Ci sono {numeroParole} parole e {caratteri} caratteri";
            Console.WriteLine("\n\n" + messaggio);
            Console.Write("Premi un tasto per continuare...");
            Console.ReadKey();
        }
    }
}
