using skrpcht;
using System.Diagnostics;
using System;
using System.Diagnostics;


namespace Miratorg
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введит ваше имя: ");
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();


            PGR name = new PGR();
            name.test = Console.ReadLine();
            Console.WriteLine(name.test);
            Console.Clear();

            List<string> text = new List<string>() { "Введит ваше имя" };
            var rand = new Random();
            int tex = rand.Next(0, 2);
            string textvv = text[tex];
            Console.WriteLine(textvv);

            int i = 0;
            Console.SetCursorPosition(0, 0);
            while (i < textvv.Length)
            {
                char c = Console.ReadKey(true).KeyChar;
                if (c == textvv[i])
                {
                    i++;
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write(c);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine($" \n \r Вы потратили: {ts.Minutes:00}:{ts.Seconds:00}");

        }
    }
}
