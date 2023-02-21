// Задача 19 - HARD
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом.

// -------------------- Код задачи 19 --------------------

// int Promt(string mess)
// {
//   Console.WriteLine(mess);
//   int num = Convert.ToInt32(Console.ReadLine());
//   return num;
// }

// int Reverse(int num)
// {
//   int ost = 0; int numR = 0;
//   while (num > 0)
//   {
//     ost = num % 10;
//     numR = numR * 10 + ost;
//     num = num / 10;
//   }
//   return numR;
// }

// void Palindrome(int num, int numR)
// {
//   if (num == numR)
//     Console.WriteLine("Число является палиндромом");
//   else
//     Console.WriteLine("Число не является палиндромом");
// }

// try
// {
//   int number = Promt("Введите целое число:");
//   Palindrome(number, Reverse(number));
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные");
// }

// ----------------------------------------

// Задача 21 - HARD
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

// -------------------- Код задачи 21 --------------------

// int Promt(string mess)
// {
//   Console.WriteLine(mess);
//   int num = Convert.ToInt32(Console.ReadLine());
//   return num;
// }

// double Distance(int razm, int[] array1, int[] array2)
// {
//   double res = 0;
//   for (int i = 0; i < razm; i++)
//     res += Math.Pow((array2[i] - array1[i]), 2);
//   res = Math.Sqrt(res);
//   return res;
// }

// int[] ReadArray(int razm)
// {
//   Console.Write("Координаты одной из точек: ");
//   int[] arr = new int[razm];
//   arr = Console.ReadLine().Split(',').Select(s => int.Parse(s)).ToArray();
//   if (arr.Length != razm)
//   {
//     Console.Write("Введены некорректные данные!");
//     Environment.Exit(0);
//   }
//   return arr;
// }

// try
// {
//   int N = Promt("Введите размерность пространства (одномерное, двумерное или трёхмерное):");
//   if (N < 1 | N > 3)
//   {
//     Console.Write("Введены некорректные данные!");
//     Environment.Exit(0);
//   }
//   Console.WriteLine("Введите координаты точек (целые числа через запятую без пробелов) для заданной размерности пространства!");
//   int[] coord1 = ReadArray(N);
//   int[] coord2 = ReadArray(N);
//   double dist = Distance(N, coord1, coord2);
//   Console.Write($"Расстояние между точками равно: {dist}");
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ----------------------------------------

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// -------------------- Код задачи 23 --------------------

// int Promt (string mess)
// {
//   Console.WriteLine(mess);
//   int num = Convert.ToInt32(Console.ReadLine());
//   return num;
// }

// string Cube(string tab, int num)
// {
//   for (int i = 1; i <= num; i++)
//   {
//     tab += Convert.ToString(Math.Pow(i, 3)) + "; ";
//   }
//   return tab;
// }

// try
// {
//   int N = Promt("Введите целое число N (больше единицы):");
//   string table = "Таблица кубов: ";
//   if (N <= 0)
//   {
//     Console.Write("Введены некорректные данные!");
//     Environment.Exit(0);
//   }
//   Console.Write(Cube(table,N));
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ----------------------------------------