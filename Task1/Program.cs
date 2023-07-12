// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

Console.Clear();
int ReadConsole(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintEvenNaturalNumbers(int m, int n)
{
    if (m > n)
        return;
    if (m % 2 == 0)
    {
        Console.Write($"{m} ");
    }
    PrintEvenNaturalNumbers(m + 1, n);
}

int inputM = ReadConsole("Input number M: ");
int inputN = ReadConsole("Input number N: ");
PrintEvenNaturalNumbers(inputM, inputN);