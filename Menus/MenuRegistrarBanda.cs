﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace screenSound.Menus
{
    class MenuRegistrarBanda : Menu
    {
        public void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();
            ExibirTituloDaOpcao("Registro das bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            Banda banda = new Banda(nomeDaBanda);
            bandasRegistradas.Add(nomeDaBanda, banda);
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
