// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();

int CheckCorrectInputNumber(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) return number;
    else
    {
        Console.WriteLine("Please input positive number !");
        return CheckCorrectInputNumber(message);
    }
}

int AkkermanFunktion(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanFunktion(m - 1, 1);
    }
    else
    {
        return (AkkermanFunktion(m - 1, AkkermanFunktion(m, n - 1)));
    }
}

int inputM = CheckCorrectInputNumber("Input number M: ");
int inputN = CheckCorrectInputNumber("Input number N: ");
Console.Write($"\nResul Akkerman's funktion: {AkkermanFunktion(inputM, inputN)}\n\n");