// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//____________Решение _____________________________________________________________________

double Exponentiation(int numA, int numB) // метод Math.Pow
{
    double exponentA = Math.Pow(numA, numB);
    return exponentA;
}
double ExponentiationArr(int numA, int numB) // Метод с циклом While
{
    int i = 1;
    int exponA = 1;
    while (i <= numB)
    {
        exponA = exponA * numA;
        i++;
    }
    return exponA;
}

int InputNumber(string message)
{
    int number;
    while (true)
    {
        System.Console.Write(message);
        if (!(int.TryParse(Console.ReadLine(), out number)))
        {
            System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
        }
        else
        {
            break;
        }
    }
    return number;
}


int A = InputNumber("Введите число А: ");
int B = InputNumber("Введите число В: ");
double sumexponentA = Exponentiation(A, B);            // метод Math.Pow
System.Console.WriteLine($"{A},{B} -> {sumexponentA}");// метод Math.Pow

double sumexponA = ExponentiationArr(A, B);           // Метод с циклом While
System.Console.WriteLine($"{A},{B} -> {sumexponA}");  // Метод с циклом While