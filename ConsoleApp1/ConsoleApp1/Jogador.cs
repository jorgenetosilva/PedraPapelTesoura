using System;

namespace PedraPapelTesoura
{
    public class Jogador
    {
        public string Nome { get; set; }
        public string Escolha { get; private set; }

        public void FazerEscolha()
        {
            Console.WriteLine($"{Nome}, escolha Pedra, Papel ou Tesoura:");
            Escolha = Console.ReadLine().ToLower();
        }
    }
}
