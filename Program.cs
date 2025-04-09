// Screen Sound
using System;

string welcomeMSG = "\nWelcome!";

void ShowWelcomeMSG()
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
            Console.WriteLine("Registering a band...");
            break;
        case 2:
            Console.WriteLine("Showing all bands...");
            break;
        case 3:
            Console.WriteLine("Rating a band...");
            break;
        case 4:
            Console.WriteLine("Showing average rating...");
            break;
        case 5:
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.WriteLine("Invalid option. Try again.");
            break;
    }
}

ShowWelcomeMSG();
ShowOptionsMenu();
