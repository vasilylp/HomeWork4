// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//____________Решение _____________________________________________________________________

double Exponentiation(int numA, int numB)
{
    double exponentA = Math.Pow(numA,numB);
    return exponentA;
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

double exponentA = Exponentiation(A,B);
System.Console.WriteLine($"{A},{B} -> {exponentA}");



