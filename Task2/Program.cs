// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30
Console.Clear();

int ReadConsole(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int PrintSumNaturalNumbers(int m, int n)  // Finde summ numbers of M to N
{
    if (m == n)
        return n;
    else return m + PrintSumNaturalNumbers(m + 1, n);
}

int inputM = ReadConsole("Input number M: ");
int inputN = ReadConsole("Input number N: ");
int result = PrintSumNaturalNumbers(inputM, inputN);
System.Console.WriteLine($"\nSumm numbers of M to N : {result} \n");