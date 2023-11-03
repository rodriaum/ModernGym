using System;

namespace ModernGym
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu nome: ");
            string name = Console.ReadLine();

            Console.WriteLine("Olá " + name + ", quantos minutos você passou no ginásio? ");
            double minutes = Convert.ToDouble(Console.ReadLine());

            double total = minutes * 0.05;

            Console.WriteLine(name  + ", pague no balcão " + total + " euros.");
        }
    }
}
