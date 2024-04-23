// // Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// // Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// Console.WriteLine("Введите целое число или q (или число, сумма цифр которого чётная) чтоб програма завершила свою работу: ");
// string b = Console.ReadLine();
// do
// {
//     int a = int.Parse(b);
//     int s = 0;
//     while (a > 0)
//     {
//         s = s + a % 10;
//         a = a /10 ;
//     }
//     Console.WriteLine($"Сумма цифр числа {b} = {s}.");
//     if(s % 2 == 0) 
//     {
//         break;
//     }
//     else 
//     {
//         Console.WriteLine("Введите целое число или q (или число, сумма цифр которого чётная) чтоб програма завершила свою работу: ");
//         b = Console.ReadLine();
//     }
// }
// while (b != "q");
// Console.WriteLine("Exit");

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999);
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

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

System.Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);

PrintArray(array);
System.Console.WriteLine();

System.Console.WriteLine($"The quantity of even numbers in the array: {CountEvenNumbers(array)}");

// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] FlipArray(int[] array)
{
    int[] flipArray = new int[array.Length];
    for (int i = 0; i < flipArray.Length; i++)
    {
        flipArray[i] = array[array.Length - i - 1];
    }
    return flipArray;
}

System.Console.WriteLine("The fliped array: ");
PrintArray(FlipArray(array));