using System;

namespace LutaRPG_CodigoEstruturado
{
    class Program
    {
        static void Main(string[] args)
        {
            int pvHeroi = 50; //Vida dos personagens
            int pvTroll = 30;

            Random danoAleatorio = new Random(); //Classe que será usada para gerar o dano das armas
            
            int danoMinimoEspadaEnferrujada = 7, danoMaximoEspadaEnferrujada = 23;
            int danoEspadaEnferrujada = danoAleatorio.Next(danoMinimoEspadaEnferrujada, danoMaximoEspadaEnferrujada);
            int danoMinimoMachadoCorrompido = 15, danoMaximoMachadoCorrompido = 40;
            int danoMachadoCorrompido = danoAleatorio.Next(danoMinimoMachadoCorrompido, danoMaximoMachadoCorrompido);

            Console.WriteLine("Bem vindo ao jogo Luta RPG");
            Console.WriteLine("-------------------------------");//30 hífens
            Console.WriteLine();

            Console.Write("Insira o nome de seu herói: ");
            string nomeHeroi = Console.ReadLine();
            Console.WriteLine("Os pontos de vida de seu herói são: " + pvHeroi +" PV");
            Console.WriteLine("-------------------------------");//30 hífens
            Console.WriteLine();

            Console.WriteLine("Sua arma corpo a corpo inicial é: Espada Enferrujada");
            Console.WriteLine("Seus atributos são: ");
            Console.WriteLine("• Dano: " + danoMinimoEspadaEnferrujada + " a " + danoMaximoEspadaEnferrujada);
            Console.WriteLine("-------------------------------");//30 hífens
            Console.WriteLine();

            Console.WriteLine("Seu oponente é o: Troll");
            Console.WriteLine("Os pontos de vida de seu oponente é de: " + pvTroll + " PV");
            Console.WriteLine("-------------------------------");//30 hífens
            Console.WriteLine();

            Console.WriteLine("A arma corpo a corpo de seu oponente é: Machado Corrompido");
            Console.WriteLine("Os atributos são:");
            Console.WriteLine("• Dano: " + danoMinimoMachadoCorrompido + " a " + danoMaximoMachadoCorrompido);
            Console.WriteLine("-------------------------------");//30 hífens
            Console.WriteLine();

            Console.WriteLine("Você deseja lutar contra este oponente? (S / N)");
            char inicioLuta = char.Parse(Console.ReadLine());


        }
    }
}
