// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
//_______________Решение 1____________________________________________________________

// int[] arr = new int[8];
// Random rand = new Random();

// for(int i = 0; i < arr.Length; i++)
// {
//      arr[i] = rand.Next(0, 50);
//      //System.Console.Write(arr[i] + " ");
// }
// foreach(var i in arr)
// {
//     Console.Write($"{i} ");
// }

//_______Решение 2 через Метод_____________________________________________________________________

string[] ArrayMetod(int lengthArr, int j)
{

              string[] arr = new string[lengthArr];
              Random rand = new Random();
              int i = 0;
              while (i < lengthArr)
              {

                            int num = rand.Next(0, j);
                            arr[i] = Convert.ToString(Convert.ToInt32(num));
                            i++;
              }

              return arr;
}

string[] arrA = ArrayMetod(8, 50);
System.Console.WriteLine("[" + string.Join(",", arrA) + "]");

