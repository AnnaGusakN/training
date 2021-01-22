using System;

namespace changeValue
{
    //Анна Гусак
    /* Написать программу обмена значениями двух переменных:
    a) с использованием третьей переменной */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter firsst number: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine($"Original x={x}, y={y}");

        int tmp = x;
        x = y;
        y = tmp;
        Console.WriteLine($"Exchanged x={x}, y={y}");
    }

}
}
