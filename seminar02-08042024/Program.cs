void NumbSquare(int numb) //простой метод "void", без возврата значения
{
    System.Console.WriteLine($"1. The square of the number {numb} is: {numb * numb}"); //(Write() - вывод в одну строку)
}

int NumbSquareInt(int numb) //метод с возвратом значения
{
    return(numb * numb); //обязательный оператор в методе с возвратом значения
}
System.Console.WriteLine("Input number: "); //вывод строки "Input number: " (WriteLine() - построчный вывод)
int a = Convert.ToInt32(Console.ReadLine()); //присваивание переменной a введенного значения (Console.ReadLine())

NumbSquare(a); //вызов метода NumbSquare()

int result = NumbSquareInt(a);
System.Console.WriteLine($"2. The square of the number {a} is: {result}");