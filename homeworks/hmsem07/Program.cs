// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void FromMtoN(int m, int n)
{
    if (m > n)
    {
        FromMtoN(m - 1, n);
        System.Console.Write(m + " ");
    }
    else if (n > m)
    {
        FromMtoN(m, n - 1);
        System.Console.Write(n + " ");
    }
    else System.Console.Write(m + " ");
}

System.Console.WriteLine($"Natural numbers from {m} to {n}:");
FromMtoN(m, n);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа M и N.





System.Console.WriteLine("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());