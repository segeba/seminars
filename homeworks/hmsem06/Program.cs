// // Задача 1: Задайте двумерный массив символов (тип char [,]). 
// // Создать строку из символов этого массива.

// string CharArrayToString(char[,] charArray)
// {
//     string result = string.Empty; // string.Empty - пустая строка
//     for (int i = 0; i < charArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < charArray.GetLength(1); j++)
//         {
//             result = result + charArray[i, j];
//         }
//     }
//     return result;
// }

// char[,] chars = {{'1', 'b', 'c', 'd', 'e', 'f', 'g'},
//                 {'2', 'b', 'c', 'd', 'e', 'f', 'g'},
//                 {'3', 'b', 'c', 'd', 'e', 'f', 'g'},
//                 {'4', 'b', 'c', 'd', 'e', 'f', 'g'},
//                 {'5', 'b', 'c', 'd', 'e', 'f', 'g'},};

// System.Console.WriteLine(CharArrayToString(chars));

// // Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// // Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// string ConvertString (string str)
// {
//     string convStr = string.Empty;
//     for (int i = 0; i < str.Length; i++)
//     {
//         convStr = convStr + char.ToLower(str[i]);
//     }
//     return convStr;
// }

// System.Console.WriteLine("Enter a string with uppercase and lowercase characters: ");
// string str = Convert.ToString(Console.ReadLine());

// System.Console.WriteLine("The entered string with characters converted to lowercase: ");
// System.Console.WriteLine(ConvertString(str));

// // Задача 3: Задайте произвольную строку. 
// // Выясните, является ли она палиндромом.

// bool CheckPolindrom(string str)
// {
//     int count = 0;  
//     for (int i = 0; i < str.Length / 2; i++)
//     {
//         if (str[i] == str[str.Length - i - 1])
//         {
//             count=count + 1;
//         }
//         else return false;
//     }
//     if (count == str.Length/2) return true;
//     return false;
// }

// System.Console.WriteLine("Enter a string: ");
// string str = Convert.ToString(Console.ReadLine());

// if (CheckPolindrom(str))
// {
//     System.Console.WriteLine("The entered string is polindrome");
// }
// else System.Console.WriteLine("The entered string is NOT polindrome");

// Задача 4*: Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

