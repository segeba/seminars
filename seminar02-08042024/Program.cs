void NumbSquare(int numb) //Простой метод "void", без возврата информации
{
    System.Console.WriteLine(numb * numb);
}

System.Console.WriteLine("Input number: "); //вывод строки "Input number: " (WriteLine() - построчный вывод)
int a = Convert.ToInt32(Console.ReadLine()); //присваивание переменной a введенного значения (Console.ReadLine())

System.Console.Write($"The square of the number {a} is: "); //(Write() - вывод в одну строку)
NumbSquare(a); //вызов метода NumbSquare()
