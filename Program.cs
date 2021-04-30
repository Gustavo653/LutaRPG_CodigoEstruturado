using System;
using System.Threading.Tasks;

namespace LutaRPG_CodigoEstruturado
{
    class Program
    {
        static async Task Main(string[] args)
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
            await Task.Delay(2000);

            Console.WriteLine("Seu oponente é o: Troll");
            Console.WriteLine("Os pontos de vida de seu oponente é de: " + pvTroll + " PV");
            Console.WriteLine("-------------------------------");//30 hífens
            Console.WriteLine();

            Console.WriteLine("A arma corpo a corpo de seu oponente é: Machado Corrompido");
            Console.WriteLine("Os atributos são:");
            Console.WriteLine("• Dano: " + danoMinimoMachadoCorrompido + " a " + danoMaximoMachadoCorrompido);
            Console.WriteLine("-------------------------------");//30 hífens
            Console.WriteLine();
            await Task.Delay(2000);

            Console.WriteLine("Você deseja lutar contra este oponente? (S / N)");
            char inicioLuta = char.Parse(Console.ReadLine());

            if (inicioLuta == 'N')
            {
                Console.WriteLine("Você decidiu recuar.");
                Console.WriteLine("Você perdeu!");
                Console.WriteLine("Encerrando o jogo.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Você decidiu encarar seu oponente.");
                Console.WriteLine("A luta começa em instantes");
                await Task.Delay(2000);

                while (pvHeroi > 0 || pvTroll > 0) //Luta
                {
                    pvTroll -= danoEspadaEnferrujada;
                    if (danoEspadaEnferrujada > pvTroll)
                    {
                        pvTroll = 0;
                        break;
                    }
                    pvHeroi -= danoMachadoCorrompido;
                    if (danoMachadoCorrompido > pvHeroi)
                    {
                        pvHeroi = 0;
                        break;
                    }
                    Console.WriteLine("Vida restante do Troll: " + pvTroll);
                    Console.WriteLine("Vida restante do " + nomeHeroi + ": " + pvHeroi);
                    await Task.Delay(2000);
                }
                Console.WriteLine();
                Console.WriteLine("Vida final do Troll: " + pvTroll);
                Console.WriteLine("Vida final do " + nomeHeroi + ": " + pvHeroi);
            }

        }
    }
}
