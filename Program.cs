// Screen Sound
using System;
using System.Collections.Generic;
using System.Threading;

string welcomeMSG = "\nWelcome!";
List<string> bandList = new List<string>();

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
            Console.WriteLine("Rating a band...");
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
    bandList.Add(bandName);

    Console.WriteLine($"The band {bandName} was successfully registered!");

    Thread.Sleep(1000);
    Console.Clear();

    ShowLogo();
    ShowOptionsMenu();
}

void ShowBands()
{
    Console.Clear();

    Console.WriteLine("--- All band's registrated ---");
    Console.WriteLine("");

    for (int i = 0; i < bandList.Count; i++)
    {
        Console.WriteLine($"Band: {bandList[i]}");
    }

    Console.WriteLine("\nPress any key to exit");

    Console.ReadKey();
    Console.Clear();

    ShowLogo();
    ShowOptionsMenu();
}

void ExitAplication()
{
    Console.Clear();
    Environment.Exit(0);
}

ShowLogo();
ShowOptionsMenu();
