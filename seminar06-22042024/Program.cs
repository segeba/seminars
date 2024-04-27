// // Задайте массив символов (тип char []). Создайте строку из символов этого массива.
// // Указание: Конструктор строки вида string(char []) не использовать.
// // Пример:
// // [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// string CharArrayToString(char[] charArray)
// {
//     string result = string.Empty; // string.Empty - пустая строка
//     for (int i = 0; i < charArray.Length; i++)
//     {
//         result = result + charArray[i];
//     }
//     return result;
// }

// // char[] chars = {'a', 'b', 'c', 'd', 'e', 'f', 'g'};
// // string str = new string(chars);
// // string[] strings = {"a", "b", "c", "d"};

// char[] InputChars()
// {
//     System.Console.WriteLine("Input CharArray size: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     char[] array = new char[size];
//     for(int i= 0; i < array.Length; i++)
//     {
//         array[i] = Convert.ToChar(Console.ReadLine());   
//     } 
//     return array;
// }

// System.Console.WriteLine(CharArrayToString(InputChars()));

// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

char[] StringToCharArray(string str)
{
    char[] chars = new char[str.Length];
    for (int i = 0; i < chars.Length; i++)
    {
        chars[i] = str[i];
    }
    return chars;
}

void PrintArray(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

PrintArray(StringToCharArray("Hello!"));