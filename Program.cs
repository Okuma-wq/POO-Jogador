using System;
using POO_Jogador.Classes;

namespace POO_Jogador
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador jog = new Jogador();
            
            Console.WriteLine("Digite as informações do jogador");
            Console.Write("Nome: ");
            jog.Nome = Console.ReadLine();
            Console.Write("Posição: ");
            jog.Posicao = Console.ReadLine().ToLower();
            Console.Write("Ano de nascimento: ");
            jog.Nascimento = int.Parse(Console.ReadLine());
            Console.Write("Nacionalidade: ");
            jog.Nacionalidade = Console.ReadLine();
            Console.Write("Altura em metros: ");
            jog.Altura = double.Parse(Console.ReadLine());
            Console.Write("Peso em Kg: ");
            jog.Peso = double.Parse(Console.ReadLine());
            Console.Write("Digite o ano atual: ");
            jog.agora = int.Parse(Console.ReadLine());
            
            Console.Clear();

            Console.WriteLine(jog.InformacaoDoJogador());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"O jogador tem {jog.Idade()} anos");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(jog.Aposentar(jog.Idade()));
            Console.WriteLine("---------------------------------------");
        }
    }
}
