using System;

class Program
{
    static void Main()
    {
        // Solicitar el primer nombre al usuario
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Solicitar el apellido al usuario
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Mostrar el mensaje en el formato requerido
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}