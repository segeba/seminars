// void NumbSquare(int numb) //простой метод "void", без возврата значения
// {
//     System.Console.WriteLine($"1. The square of the number {numb} is: {numb * numb}"); //(Write() - вывод в одну строку)
// }

// int NumbSquareInt(int numb) //метод с возвратом значения
// {
//     return(numb * numb); //обязательный оператор в методе с возвратом значения
// }
// System.Console.WriteLine("Input number: "); //вывод строки "Input number: " (WriteLine() - построчный вывод)
// int a = Convert.ToInt32(Console.ReadLine()); //присваивание переменной a введенного значения (Console.ReadLine())

// NumbSquare(a); //вызов метода NumbSquare()

// int result = NumbSquareInt(a); //вызов метода NumbSquareInt() и присвоение переменной result возвращаемого значения
// System.Console.WriteLine($"2. The square of the number {a} is: {result}");
// System.Console.WriteLine($"3. The square of the number {a} is: {NumbSquareInt(a)}");

// // Программа 1
// // принимает на вход трехзначное число и удаляет вторую цифру этого числа
// // например:
// // 256 => 26
// // 891 => 81

// int DeleteSecondDigit(int num)
// {
//     if (num >= 100 && num <= 999) // проверка числа на трехзначность
//     {
//         int ed = num % 10;
//         int sot = num / 100;
//         return sot * 10 + ed;
//     }
//     else
//     {
//         System.Console.WriteLine("Your input not three-digit number!");
//         return 0;
//     }
// }

// Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(DeleteSecondDigit(num));

// // Програма 2
// // принимает на вход трехзначное число и возводит вторую цифру в степень, равную третьей цифре
// // например:
// // 487 => 8^7 = 2 097 152
// // 254 => 5^4 = 625
// // 617 => 1^7 = 1

// int Exponentiation(int num)
// {
//     if (num >= 100 && num <= 999) // проверка числа на трехзначность
//     {
//         int ed = num % 10;
//         int dec = num / 10 % 10;
//         int result = 1;
//         for (int i = 0; i < ed; i++) // цикл возведения второй цифры в степень третьей цифры
//         {
//             result = result * dec;
//         }
//         return result;
//     }
//     else
//     {
//         System.Console.WriteLine("Your input not three-digit number!");
//         return 0;
//     }
// }

// Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(Exponentiation(num));

// Програма 3
// принимает на вход два числа и проверяет, кратно ли первое число второму.
// если первое число не кратно второму, то программа выводит остаток от деления первого числа на второе
// например:
// 14, 5 -> no, 4
// 16, 8 -> yes
// 4, 3 -> no, 1

void MultiplicityCheck(int num1, int num2)
{
    if (num1 % num2 == 0) // проверка деления числа num1  на число num2 без остатка
    {
        System.Console.WriteLine($"{num1}, {num2} -> yes");
    }
    else
    {
        System.Console.WriteLine($"{num1}, {num2} -> no, {num1 % num2}");
    }
}

Console.WriteLine("Input Number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

MultiplicityCheck(num1, num2);