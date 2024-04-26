// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Mult(int a, int b)
{
    if (b != 0)
    {
        return a * Mult(a, b - 1);
    }

    return 1;
}

System.Console.WriteLine(Mult(2, 3));