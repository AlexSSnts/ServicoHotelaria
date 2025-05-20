using System;
using System.Runtime.CompilerServices;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //10 por padrão msm
            Quarto[] quartos = new Quarto[10];


            Console.Write("Escolha quantos quarto deseja reservar: ");
            int qntd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qntd; i++)
            {
                Console.Write("qual quarto vc deseja?(0-9): ");
                int quarto = int.Parse(Console.ReadLine());

                Console.WriteLine($"Dados do quarto #{quarto}");
                Console.Write("Digite seu nome: ");
                string Nome = Console.ReadLine();

                Console.Write("Digite seu email: ");
                string Email = Console.ReadLine();

                quartos[quarto] = new Quarto { nome = Nome, email = Email };
            }

            Console.WriteLine(" --Dados dos quartos-- ");

            for (int S = 0; S < 10; S++)
            {
                if (quartos[S] == null)
                {
                    //caso não queira imprimir os quartos vazios, basta remover
                    Console.WriteLine($"Quarto #{S}: [vago]");
                }
                else
                {
                    Console.WriteLine($"Quarto #{S}, Nome: {quartos[S].nome}, E-mail:{quartos[S].email}");
                }

            }
        }
    }
}