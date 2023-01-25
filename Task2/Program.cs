// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12
//__________Решение 1________________________________________________________________

// System.Console.Write("Введите число :");
// string? text = Console.ReadLine();
// int sumN = 0;
// int i = 0;
// while (i < text!.Length)
// {
//     sumN += Convert.ToInt32(Convert.ToString(text[i]));
//     i++;
// }
// System.Console.WriteLine($"{text} -> {sumN}");

//___________________Решение 2_____________________________

int SumNumber (int num)
{
string text = Convert.ToString(Convert.ToInt32(num));
int sumN = 0;
int i = 0;
while (i < text!.Length)
{
    sumN += Convert.ToInt32(Convert.ToString(text[i]));
    i++;
    
}
return sumN;
}

int InputNumber(string str)
{
    int number;
    string? text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }

        System.Console.WriteLine("Введено не корректное число, попробуйте ещё раз!");
    }
    return number;
}

int n = InputNumber("Введите число N: ");
int sumNum = SumNumber(n);
System.Console.WriteLine($"{n} -> {sumNum}");




