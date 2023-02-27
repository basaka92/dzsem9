// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// -------------------- Код задачи 34 --------------------

// int Input(string msg)
// {
//   Console.Write(msg);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// void FillArray(int[] arr)
// {
//   for (int i = 0; i < arr.Length; i++)
//     arr[i] = new Random().Next(100, 1000);
// }

// void PrintArray(int[] arr)
// {
//   foreach (var el in arr)
//     Console.Write($"{el} ");
// }

// int EvenNumbers(int[] arr)
// {
//   int count = 0;
//   for (int i = 0; i < arr.Length; i++)
//     if (arr[i] % 2 == 0)
//       count++;
//   return count;
// }

// try
// {
//   int arrSize = Input("Введите размерность массива: ");
//   int[] array = new int[arrSize];
//   FillArray(array);
//   int countEven = EvenNumbers(array);
//   PrintArray(array);
//   Console.Write($"---> {countEven} (количество чётных чисел в массиве)");
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ----------------------------------------

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// -------------------- Код задачи 36 --------------------

// int Input(string msg)
// {
//   Console.Write(msg);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// void FillArray(int[] arr)
// {
//   for (int i = 0; i < arr.Length; i++)
//     arr[i] = new Random().Next(0,100);
// }

// void PrintArray(int[] arr)
// {
//   foreach (var el in arr)
//     Console.Write($"{el} ");
// }

// int SumOddPos(int[] arr)
// {
//   int sum = 0;
//   for (int i = 1; i < arr.Length; i += 2)
//     sum += arr[i];
//   return sum;
// }

// try
// {
//   int arrSize = Input("Введите размерность массива: ");
//   int[] array = new int[arrSize];
//   FillArray(array);
//   int sumOdd = SumOddPos(array);
//   PrintArray(array);
//   Console.Write($"---> {sumOdd} (сумма элементов, стоящих на нечётных позициях)");
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ----------------------------------------

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// -------------------- Код задачи 38 --------------------

// int Input(string msg)
// {
//   Console.Write(msg);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// void FillArray(double[] arr)
// {
//   for (int i = 0; i < arr.Length; i++)
//     arr[i] = Math.Round(new Random().NextDouble() * 100, 2);
// }

// void DiffMaxMin(double[] arr)
// {
//   double max = arr[0], min = arr[0];
//   for (int i = 1; i < arr.Length; i++)
//     if (arr[i] > max)
//       max = arr[i];
//     else if (arr[i] < min)
//       min = arr[i];
//   Console.Write($"---> {Math.Round(max - min, 2)} (разница между максимальным и минимальным элементом массива)");
// }

// void PrintArray(double[] arr)
// {
//   foreach (var el in arr)
//     Console.Write($"{el} ");
// }

// try
// {
//   int arrSize = Input("Введите размерность массива: ");
//   double[] array = new double[arrSize];
//   FillArray(array);
//   PrintArray(array);
//   DiffMaxMin(array);
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ----------------------------------------

// Задача 30. - HARD необязательная Напишите программу, которая на вход получает размерность массива. 
// Далее заполняет его случайными уникальными числами и выводит на экран. 
// Далее производим сортировку массива от большего к меньшему и выводим на экран. 
// Далее придумываем алгоритм перемешивания списка на основе случайности , применяем этот алгоритм и выводим на экран результат. 
// Встроенные методы работы с массивами использовать нельзя.

// -------------------- Код задачи 30 --------------------

// int Input(string msg)
// {
//   Console.Write(msg);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// void FillArray(int[] arr, int size)
// {
//   arr[0] = new Random().Next(1, size + 1);
//   for (int i = 1; i < size; i++)
//   {
//     arr[i] = new Random().Next(1, size + 1);
//     for (int j = 0; j < i; j++)
//     {
//       if (arr[i] == arr[j])
//       {
//         i--;
//         break;
//       }
//     }
//   }
// }

// void SortMaxMinArray(int[] arr, int size)
// {
//   int count = 0;
//   for (int i = 1; i < size; i++)
//     if (arr[i] > arr[i - 1])
//     {
//       int buf = arr[i];
//       arr[i] = arr[i - 1];
//       arr[i - 1] = buf;
//     }
//     else
//       count++;
//   if (count != size - 1)
//     SortMaxMinArray(arr, size);
// }

// void ShuffleArray(int[] arr, int size)
// {
//   for (int i = 0; i < size; i++)
//   {
//     int j = new Random().Next(0,size);
//     (arr[i], arr[j]) = (arr[j], arr[i]);
//   }
// }

// void PrintArray(string msg, int[] arr)
// {
//   Console.Write(msg);
//   foreach (var el in arr)
//     Console.Write($"{el} ");
//   Console.WriteLine();
// }

// try
// {
//   int arrSize = Input("Введите размерность массива: ");
//   int[] array = new int[arrSize];
//   FillArray(array, arrSize);
//   PrintArray("Изначальный массив с уникальными значениями: ", array);
//   SortMaxMinArray(array, arrSize);
//   PrintArray("Отсортированный массив от большего к меньшему: ", array);
//   ShuffleArray(array, arrSize);
//   PrintArray("Случайно перемешанный массив: ", array);
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ----------------------------------------