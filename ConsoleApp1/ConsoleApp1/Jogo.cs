using System;

namespace PedraPapelTesoura
{
    public class Jogo
    {
        private Jogador jogador1;
        private Jogador jogador2;

        public Jogo()
        {
            jogador1 = new Jogador { Nome = "Jogador 1" };
            jogador2 = new Jogador { Nome = "Jogador 2" };
        }

        public void Iniciar()
        {
            jogador1.FazerEscolha();
            jogador2.FazerEscolha();

            string vencedor = DeterminarVencedor(jogador1.Escolha, jogador2.Escolha);
            ExibirResultado(vencedor);
        }

        private string DeterminarVencedor(string escolha1, string escolha2)
        {
            string[] escolhasValidas = { "pedra", "papel", "tesoura" };
            if (!escolhasValidas.Contains(escolha1) || !escolhasValidas.Contains(escolha2))
            {
                Console.WriteLine("Escolha inválida!");
                return "Empate";
            }
            if (escolha1 == escolha2)

                return "Empate";

            if ((escolha1 == "pedra" && escolha2 == "tesoura") ||
                (escolha1 == "papel" && escolha2 == "pedra") ||
                (escolha1 == "tesoura" && escolha2 == "papel"))
            {
                return jogador1.Nome;
            }
            else
            {
                return jogador2.Nome;
            }
        }

        private void ExibirResultado(string vencedor)
        {
            if (vencedor == "Empate")
            {
                Console.WriteLine("O jogo empatou!");
            }
            else
            {
                Console.WriteLine($"O vencedor é: {vencedor}");
            }
        }
    }
}
