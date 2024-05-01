// // // Задача 1: Задайте значения M и N. 
// // // Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// // // Использовать рекурсию, не использовать циклы.

// // void FromMtoN(int m, int n)
// // {
// //     if (m > n)
// //     {
// //         FromMtoN(m - 1, n);
// //         System.Console.Write(m + " ");
// //     }
// //     else if (n > m)
// //     {
// //         FromMtoN(m, n - 1);
// //         System.Console.Write(n + " ");
// //     }
// //     else System.Console.Write(m + " ");
// // }

// // System.Console.WriteLine($"Natural numbers from {m} to {n}:");
// // FromMtoN(m, n);

// // Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// // Даны два неотрицательных числа M и N.

// int Akkerman(int m, int n)
// {
//     // if (m < 0 || n < 0) return 0; // Символы || - или
//     if (m == 0) return n + 1;
//     else
//     {
//         if (n == 0) return Akkerman(m - 1, 1);
//         else return Akkerman(m - 1, Akkerman(m, n - 1));
//     }
// }

// System.Console.WriteLine("Input number M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (m < 0 || n < 0)
// {
//     System.Console.WriteLine("You entered a negative number!");
//     Environment.Exit(0); // Завершение программы
// }

// System.Console.WriteLine($"A ({m},{n}) = {Akkerman(m, n)}");

// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

// Вывод массива в обратном порядке рекурсивным методом
void convArray(int[] array, int i = 0)
{
    if(i != array.Length) // != - i не равно длинне массива
    {
        convArray(array, i + 1);
        Console.Write($"{array[i]} ");
    }
}


System.Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input minimal value of array element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input maximal value of array element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size, min, max);
System.Console.WriteLine($"New array: ");
PrintArray(array);
System.Console.WriteLine();

System.Console.WriteLine($"Converted array: ");
convArray(array);