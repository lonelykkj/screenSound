using System;
using System.Collections.Generic;
using System.Linq;
using screenSound.Models;

internal class Album : IAvaliavel
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public List<Musica> Musicas => musicas;
    private List<Avaliacao> notas = new List<Avaliacao>();
    
    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
    
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            return notas.Average(n => n.Nota);
        }
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }
}