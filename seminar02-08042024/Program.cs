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

// Программа 1
// принимает на вход трехзначное число и удаляет вторую цифру этого числа
// например:
// 256 => 26
// 891 => 81

int DeleteSecondDigit(int num)
{
    if (num >= 100 && num <= 999) // проверка числа на трехзначность
    {
        int ed = num % 10;
        int sot = num / 100;
        return sot * 10 + ed;
    }
    else
    {
        System.Console.WriteLine("Your input not three-digit number!");
        return 0;
    }
}

Console.Write("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(DeleteSecondDigit(num));

// Програма 2
// принимает на вход трехзначное число и возводит вторую цифру в степень, равную третьей цифре
// например:
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1^7 = 1