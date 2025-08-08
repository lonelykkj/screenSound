using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using screenSound.Models;

namespace screenSound.Menus
{
    internal class MenuAvaliarAlbum : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);

            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Avaliar album");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.Write("Digite o nome do álbum que deseja avaliar: ");
                string nomeDoAlbum = Console.ReadLine()!;

                if (banda.Albuns.Any(a => a.Nome.Equals(nomeDoAlbum)))
                {
                    Album album = banda.Albuns.First(a => a.Nome.Equals(nomeDoAlbum));
                    Console.Write($"Qual a nota que o álbum {nomeDoAlbum} merece: ");
                    Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                    album.AdicionarNota(nota);
                    Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso paral a album {nomeDoAlbum}");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"\nO álbum {nomeDoAlbum} não foi encontrada!");
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}