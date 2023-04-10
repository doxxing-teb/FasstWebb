using System;

public class Registered
{
    public static void RunProgram()
    {
        Console.WriteLine("Hello, insert Your E-Mail And Get Started");
        string email = Console.ReadLine();

        Console.WriteLine("\n");

        Console.WriteLine("Insert Your Password");
        string passwd = Console.ReadLine();

        Console.WriteLine("\n");

        Console.WriteLine("Insert Your Name");
        string name = Console.ReadLine();

        Console.WriteLine("\n");

        switch (email)
        {
            case "":
                Console.WriteLine("the email does not correspond to any account, check the email placed, thanks");
                Console.WriteLine("Press Key <ENTER> To Exit");
                var keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Environment.Exit(0);
                }
                break;

            default:
                Console.WriteLine("Thanks, You As Acces In My Application.");
                break;
        }

        Console.WriteLine("\n");

        Console.WriteLine("You Email Is Correct? " + "< " + email + " >" + " Yes Is Correct, Press <ENTER>");
        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        Console.WriteLine("\n");

        Console.WriteLine("You PassWord Is Correct? " + "< " + passwd + " >" + " Yes Is Correct Press <ENTER>");
        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        Console.WriteLine("\n");

        Console.WriteLine("Ok, yes all data is correct, continue with the application. Press Key <ENTER>");
        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        Console.WriteLine("\n");

        Console.WriteLine("Welcome " + name + ", This is FasttWebb, One Application Of < Computers And Programming In C# >");
        Console.WriteLine("\n");

        ViewMenu();
        string option = Console.ReadLine();
        ProcesarOpcion(option);
    }

    public static void ViewMenu()
    {
        Console.WriteLine("Choose one option of FasttWeb:");
        Console.WriteLine("1. Computers");
        Console.WriteLine("2. Programming");
        Console.WriteLine("3. C#");
        Console.WriteLine("4. Exit");
    }

    public static void ProcesarOpcion(string option)
    {
        switch (option)
        {
            case "1":
                Console.WriteLine("\n");
                Console.WriteLine("Hello, Computer, computer or computer​​​ is a programmable digital electronic machine that executes a series of commands to process the input data, conveniently obtaining information that is later sent to the output units.");
                Console.WriteLine("\n");
                Console.WriteLine("Author: Ibarra Agustin Gabriel");
                Console.WriteLine("LICENSE: GNU General Public License v3.0");
                break;
            case "2":
                Console.WriteLine("\n");
                Console.WriteLine("Hello, Programming is the process of creating a set of instructions that tells a computer how to perform some type of task. But not just the action of writing code for the computer or software to run.");
                Console.WriteLine("\n");
                Console.WriteLine("Author: Ibarra Agustin Gabriel");
                Console.WriteLine("LICENSE: GNU General Public License v3.0");
                break;
            case "3":
                Console.WriteLine("\n");
                Console.WriteLine("Hello, C# is a multi-paradigm programming language developed and standardized by the Microsoft company as part of its .NET platform, which was later approved as a standard by ECMA and ISO. C# is one of the programming languages ​​designed for the common language infrastructure.");
                Console.WriteLine("\n");
                Console.WriteLine("Author: Ibarra Agustin Gabriel");
                Console.WriteLine("LICENSE: GNU General Public License v3.0");
                break;
            case "4":
                Console.WriteLine("\n");
                Console.WriteLine("Thanks for using FasttWebb, goodbye!");
                Console.WriteLine("\n");
                Console.WriteLine("Author: Ibarra Agustin Gabriel");
                Console.WriteLine("LICENSE: GNU General Public License v3.0");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("\n");
                Console.WriteLine("Invalid Option, Choose One Option One, Two, Three And Four.");
                break;
        }
    }

    public static void Main()
    {
        RunProgram();
    }
}
