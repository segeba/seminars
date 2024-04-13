// // Задача 1
// // программа принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// void MultiplicityCheck(int num)
// {
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//         System.Console.WriteLine($"Число {num} кратно одновременно 7 и 23!");
//     }
//     else
//     {
//          System.Console.WriteLine($"Число {num} НЕ кратно одновременно 7 и 23!");
//     }
// }

// Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// MultiplicityCheck(num);


// Задача 2
// программа принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

int CoordQuarter(int num1, int num2)
{
    if(num1 > 0)
    {
        if(num2 > 0)
        {
            return 1;
        }
        else
        {
            return 4;
        }
    }
    else
    {
        if(num2 > 0)
        {
            return 2;
        }
        else
        {
            return 3;
        }
    }
}

Console.WriteLine("Введите координату X, не равную 0: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y, не равную 0: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == 0 || num2 == 0)
{
    System.Console.WriteLine("Введите координаты X и Y НЕ равные 0");
}
else
{
    System.Console.WriteLine($"Точка с координатами X:Y - [{num1}:{num2}] принадлежит {CoordQuarter(num1, num2)} четверти.");
}