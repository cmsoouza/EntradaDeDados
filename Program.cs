// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
namespace ExEntradaDeDados
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Entre com o seu nome completo: ");
            string fullName = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int bedroons = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto: ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu útimo nome, idade e altura");
            /* Escrevendo as informações em uma linha */
            string[] vect = Console.ReadLine().Split(' ');
            string lastName = vect[0];
            int age = int.Parse(vect[1]);
            double height = double.Parse(vect[2], CultureInfo.InvariantCulture);


            /* Chamando as variaveis */
            Console.WriteLine(fullName);
            Console.WriteLine(bedroons);
            Console.WriteLine(price);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2"), CultureInfo.InvariantCulture);
        }

    }

}