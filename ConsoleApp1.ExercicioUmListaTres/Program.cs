using System;

namespace ConsoleApp1.ExercicioUmListaTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] alturas = new double[15];

            double maiorAltura = double.MinValue;
            double menorAltura = double.MaxValue;

            for (int i = 0; i < alturas.Length; i++)
            {
                Console.Write("Qual a altura? ");
                string strAltura = Console.ReadLine();
                alturas[i] = Convert.ToDouble(strAltura);

                if (alturas[i] > maiorAltura)
                    maiorAltura = alturas[i];
                if (alturas[i] < menorAltura)
                    menorAltura = alturas[i];
            }

            Console.WriteLine("A maior altura é: " + maiorAltura);
            Console.WriteLine("A menor altura é: " + menorAltura);
        }
    }
}
