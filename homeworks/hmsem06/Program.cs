// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

string CharArrayToString(char[,] charArray)
{
    string result = string.Empty; // string.Empty - пустая строка
    for (int i = 0; i < charArray.GetLength(0); i++)
    {
        for (int j = 0; j < charArray.GetLength(1); j++)
        {
            result = result + charArray[i, j];
        }
    }
    return result;
}

char[,] chars = {{'1', 'b', 'c', 'd', 'e', 'f', 'g'},
                {'2', 'b', 'c', 'd', 'e', 'f', 'g'},
                {'3', 'b', 'c', 'd', 'e', 'f', 'g'},
                {'4', 'b', 'c', 'd', 'e', 'f', 'g'},
                {'5', 'b', 'c', 'd', 'e', 'f', 'g'},};

System.Console.WriteLine(CharArrayToString(chars));
