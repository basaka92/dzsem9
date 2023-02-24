// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// -------------------- Код задачи 25 --------------------

// int Input(string msg)
// {
//   Console.Write(msg);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int NaturalPow(int num, int pow)
// {
//   if (pow < 0)
//   {
//     Console.Write("Введены некорректные данные!");
//     Environment.Exit(0);
//   }
//   int result = 1;
//   for (int i = 0; i < pow; i++)
//   {
//     result = result * num;
//   }
//   return result;
// }

// try
// {
//   int number = Input("Введите целое число: ");
//   int power = Input("Введите степень (целое число): ");
//   int result = NaturalPow(number, power);
//   Console.WriteLine($"{number} в степени {power} = {result}");
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ----------------------------------------

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// -------------------- Код задачи 27 --------------------

// int Input(string msg)
// {
//   Console.Write(msg);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int SumNumbers(int num)
// {
//   int sum = 0;
//   while (num != 0)
//   {
//     sum += num % 10;
//     num = num / 10;
//   }
//   if (sum < 0)
//     sum = -sum;
//   return sum;
// }

// try
// {
//   int number = Input("Введите целое число: ");
//   int sumN = SumNumbers(number);
//   Console.WriteLine($"Сумма цифр числа = {sumN}");
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ----------------------------------------

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// -------------------- Код задачи 29 --------------------

// int Input(string msg)
// {
//   Console.Write(msg);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int[] NewArray(int leng, int min, int max)
// {
//   int[] arr = new int[leng];
//   for (int i = 0; i < arr.Length; i++)
//   {
//     Random rnd = new Random();
//     arr[i] = rnd.Next(min, max+1);
//   }
//   return arr;
// }

// void PromtArray(int[] arr)
// {
//   string s = "";
//   for (int i = 0; i < arr.Length; i++)
//   {
//     s += Convert.ToString(arr[i]) + " ";
//   }
//   Console.WriteLine(s);
// }

// try
// {
//   int arrLenght = Input("Введите размер массива (целое положительное число): ");
//   int arrMin = Input("Введите минимально возможный элемент массива (целое число): ");
//   int arrMax = Input("Введите максимально возможный элемент массива (целое число): ");
//   int[] array = NewArray(arrLenght, arrMin, arrMax);
//   PromtArray(array);
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ----------------------------------------
