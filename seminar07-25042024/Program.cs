// // Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// // N = 5 -> "1, 2, 3, 4, 5"
// // N = 6 -> "1, 2, 3, 4, 5, 6"

// void OneToN(int n)
// {
//     if (n > 0)
//     {
//         OneToN(n - 1);
//         System.Console.Write(n + " ");
//     }
// }

// System.Console.WriteLine("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// OneToN(n);

// // Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// // 453 -> 12
// // 45 -> 9

// int SumDigits(int n)
// {
//     if (n > 0)
//     {
//         return SumDigits(n / 10) + n % 10;
//     }
//     return 0;
// }

// System.Console.WriteLine(SumDigits(n));

// // Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// // M = 1; N = 5. -> "1, 2, 3, 4, 5"
// // M = 4; N = 8. -> "4, 5, 6, 7, 8"

// void FromMtoN(int m, int n)
// {
//     if (m > n)
//     {
//         FromMtoN(m - 1, n);
//         System.Console.Write(m + " ");
//     }
//     else if (n > m)
//     {
//         FromMtoN(m, n - 1);
//         System.Console.Write(n + " ");
//     }
//     else System.Console.Write(m + " ");
// }

// FromMtoN(5, 1);

// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Mult(int a, int b)
{
    if (b != 0)
    {
        return a * Mult(a, b - 1);
    }

    return 1;
}

System.Console.WriteLine(Mult(3, 3));