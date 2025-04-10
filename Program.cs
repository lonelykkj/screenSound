// Screen Sound
//.NET version 5.0.414

using System;
using System.Collections.Generic;
using System.Threading;

string welcomeMSG = "\nWelcome!";
// List<string> bandList = new List<string>{"Pink Floyd", "RadioHead", "Black Sabbath"};

Dictionary<string, List<int>> bandsRegistred = new Dictionary<string, List<int>>();
bandsRegistred.Add("Pink Floyd", new List<int> { 10, 8, 9 });
bandsRegistred.Add("The Beatles", new List<int>());

void ShowLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(welcomeMSG);
}

void ShowOptionsMenu()
{
    Console.WriteLine("\n1 - Register a band");
    Console.WriteLine("2 - Show all bands");
    Console.WriteLine("3 - Rate a band");
    Console.WriteLine("4 - Show band's average rating");
    Console.WriteLine("5 - Exit");

    Console.Write("\nSelect an option: ");
    string input = Console.ReadLine()!;
    int option = int.Parse(input);

    switch (option)
    {
        case 1:
            RegisterBands();
            break;
        case 2:
            ShowBands();
            break;
        case 3:
            RateBand();
            break;
        case 4:
            Console.WriteLine("Showing average rating...");
            break;
        case 5:
            ExitAplication();
            break;
        default:
            Console.WriteLine("Invalid option. Try again.");
            break;
    }
}

void RegisterBands()
{
    Console.Clear();

    Console.WriteLine("--- Band registration ---");
    Console.Write("\nEnter the name of the band you want to register: ");

    string bandName = Console.ReadLine()!;
    bandsRegistred.Add(bandName, new List<int>());

    Console.WriteLine($"The band {bandName} was successfully registered!");

    Thread.Sleep(2000);
    Console.Clear();

    ShowLogo();
    ShowOptionsMenu();
}

void ShowBands()
{
    Console.Clear();

    Console.WriteLine("--- All band's registrated ---\n");

    // for (int i = 0; i < bandList.Count; i++)
    // {
    //     Console.WriteLine($"Band: {bandList[i]}");
    // }

    foreach (string band in bandsRegistred.Keys)
    {
        Console.WriteLine($"Band: {band}");
    }

    Console.WriteLine("\nPress any key to exit");

    Console.ReadKey();
    Console.Clear();

    ShowLogo();
    ShowOptionsMenu();
}

void RateBand()
{
    Console.Clear();

    Console.WriteLine("--- Rate Band's ---\n");
    Console.Write("Write the name of the band you want to review: ");
    string bandName = Console.ReadLine();

    if (bandsRegistred.ContainsKey(bandName))
    {
        Console.Write($"Rate the band {bandName}: ");
        int rated = int.Parse(Console.ReadLine()!);

        bandsRegistred[bandName].Add(rated);
        Console.WriteLine($"\nNote {rated} was successfully registered for the band {bandName}");

        Thread.Sleep(2000);
        Console.Clear();
        ShowLogo();
        ShowOptionsMenu();
    }
    else
    {
        Console.Write($"The {bandName} band was not found\n");
        Console.WriteLine("\nPress any key to exit");

        Console.ReadKey();
        Console.Clear();
        ShowLogo();
        ShowOptionsMenu();
    }
}

void ExitAplication()
{
    Console.Clear();
    Environment.Exit(0);
}

ShowLogo();
ShowOptionsMenu();
