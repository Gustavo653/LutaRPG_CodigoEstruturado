using System;

namespace LutaRPG_CodigoEstruturado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao jogo Luta RPG");
            Console.WriteLine("-------------------------------");//30 hífens
            Console.WriteLine();

            Console.Write("Insira o nome de seu herói: ");
            string nomeHeroi = Console.ReadLine();
            Console.WriteLine("Os pontos de vida de seu herói são: 50 PV");
            Console.WriteLine("-------------------------------");//30 hífens
            Console.WriteLine();

            Console.WriteLine("Sua arma corpo a corpo inicial é: Espada Enferrujada");
            Console.WriteLine("Seus atributos são: ");
            Console.WriteLine("• Dano: 7 a 23");
            Console.WriteLine("-------------------------------");//30 hífens
            Console.WriteLine();

            Console.WriteLine("Seu oponente é o: Troll");
            Console.WriteLine("Os pontos de vida de seu oponente é de: 30 PV");
            Console.WriteLine("-------------------------------");//30 hífens
            Console.WriteLine();

            Console.WriteLine("A arma corpo a corpo de seu oponente é: Machado Corrompido");
            Console.WriteLine("Os atributos são:");
            Console.WriteLine("• Dano: 15 a 40");
            Console.WriteLine("-------------------------------");//30 hífens
            Console.WriteLine();

            Console.WriteLine("Você deseja lutar contra este oponente? (S / N)");
            char inicioLuta = char.Parse(Console.ReadLine());


        }
    }
}
