
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числам

// -------------------- Код задачи 47 ----------------------

// int InputInt32(string message)
// {
//   Console.WriteLine(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// void PrintArray(double[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       Console.Write($"{array[i, j],5} \t");
//     Console.WriteLine();
//   }
// }

// void FillArray(double[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       array[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
//   }
// }

// try
// {
//   int row = InputInt32("Введите количество строк массива: ");
//   int column = InputInt32("Введите количество столбцов массива: ");
//   double[,] array = new double[row, column];
//   FillArray(array);
//   Console.WriteLine("Полученный массив:");
//   PrintArray(array);
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ------------------------------------------

// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.


// -------------------- Код задачи 50 ----------------------

// int InputInt32(string message)
// {
//   Console.WriteLine(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// double InputDouble(string message)
// {
//   Console.WriteLine(message);
//   double result = Convert.ToDouble(Console.ReadLine());
//   return result;
// }

// void PrintArray(double[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       Console.Write($"{array[i, j],5} \t");
//     Console.WriteLine();
//   }
// }

// void FillArray(double[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       array[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
//   }
// }

// void SearchElementPos(double[,] array, double element)
// {
//   string result = String.Empty;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       if (array[i, j] == element)
//         result += $"[{i},{j}]; ";
//   }
//   if (result == string.Empty)
//     Console.WriteLine("Данного числа в массиве нет!");
//   else
//     Console.WriteLine("Данное число находится на позиции(ях): " + result);
// }

// try
// {
//   int row = InputInt32("Введите количество строк массива: ");
//   int column = InputInt32("Введите количество столбцов массива: ");
//   double[,] array = new double[row, column];
//   FillArray(array);
//   Console.WriteLine("Полученный массив:");
//   PrintArray(array);
//   double number = InputDouble("Введите число, позицию которого хотите найти: ");
//   SearchElementPos(array, number);
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ------------------------------------------

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// -------------------- Код задачи 52 ----------------------

// int InputInt32(string message)
// {
//   Console.WriteLine(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       Console.Write($"{array[i, j],2} \t");
//     Console.WriteLine();
//   }
// }

// void FillArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       array[i, j] = new Random().Next(0, 10);
//   }
// }

// void ColumnMean(int[,] array)
// {
//   string result = string.Empty;
//   for (int j = 0; j < array.GetLength(1); j++)
//   {
//     double mean = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//       mean += array[i, j];
//     mean /= array.GetLength(0);
//     result+=$"{Math.Round(mean,1)}; ";
//   }
//   Console.WriteLine("Среднее арифметическое в каждом столбце: " + result);
// }

// try
// {
//   int row = InputInt32("Введите количество строк массива: ");
//   int column = InputInt32("Введите количество столбцов массива: ");
//   int[,] array = new int[row, column];
//   FillArray(array);
//   Console.WriteLine("Полученный массив:");
//   PrintArray(array);
//   ColumnMean(array);
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ------------------------------------------

// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// -------------------- Код задачи HARD SORT ----------------------

// int InputInt32(string message)
// {
//   Console.WriteLine(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       Console.Write($"{array[i, j],2} \t");
//     Console.WriteLine();
//   }
// }

// void FillArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       array[i, j] = new Random().Next(0, 100);
//   }
// }

// void SortArray(int[,] array)
// {
//   int nextRow = 0;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       nextRow = j;
//       for (int row = i; row < array.GetLength(0); row++)
//       {
//         for (int col = nextRow; col < array.GetLength(1); col++)
//         {
//           if (array[i, j] > array[row, col])
//             (array[i, j], array[row, col]) = (array[row, col], array[i, j]);
//         }
//         nextRow = 0;
//       }
//     }
//   }
// }

// try
// {
//   int row = InputInt32("Введите количество строк массива: ");
//   int column = InputInt32("Введите количество столбцов массива: ");
//   int[,] array = new int[row, column];
//   FillArray(array);
//   Console.WriteLine("Полученный массив:");
//   PrintArray(array);
//   Console.WriteLine("Отсортированный массив:");
//   SortArray(array);
//   PrintArray(array);
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ------------------------------------------

// задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна с будущего семинара
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , причем чтоб количество элементов было четное. 
// Вывести на экран красивенько таблицей. 
// Перемешать случайным образом элементы массива, причем чтобы каждый элемент гарантированно и только один раз переместился на другое место и выполнить перемешивание за m*n / 2 итераций. 
// То есть если массив три на четыре, то надо выполнить за 6 итераций. И далее в конце опять вывести на экран как таблицу.

// -------------------- Код задачи 2 HARD ----------------------

// int InputInt32(string message)
// {
//   Console.WriteLine(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       Console.Write($"{array[i, j],2} \t");
//     Console.WriteLine();
//   }
// }

// void FillArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       array[i, j] = new Random().Next(0, 100);
//   }
// }

// void HardRandArray(int[,] array)
// {
//   int[,] dejavuTable = new int[array.GetLength(0), array.GetLength(1)];
//   int iterations = 0;
//   int maxIterations = (array.GetLength(0) * array.GetLength(1)) / 2;
//   while (iterations < maxIterations)
//   {
//     int rndRow1 = new Random().Next(0, array.GetLength(0));
//     int rndColumn1 = new Random().Next(0, array.GetLength(1));
//     int rndRow2 = new Random().Next(0, array.GetLength(0));
//     int rndColumn2 = new Random().Next(0, array.GetLength(1));
//     if (dejavuTable[rndRow1, rndColumn1] == 0
//     && dejavuTable[rndRow2, rndColumn2] == 0
//     && (rndRow1 != rndRow2 || rndColumn1 != rndColumn2))
//     {
//       (array[rndRow1, rndColumn1], array[rndRow2, rndColumn2]) = (array[rndRow2, rndColumn2], array[rndRow1, rndColumn1]);
//       dejavuTable[rndRow1, rndColumn1] = dejavuTable[rndRow2, rndColumn2] = 1;
//       iterations++;
//       Console.WriteLine($"Итерация {iterations}: [{rndRow1},{rndColumn1}]<--->[{rndRow2},{rndColumn2}]");
//     }
//   }
// }

// try
// {
//   int row = InputInt32("Введите количество строк массива: ");
//   int column = InputInt32("Введите количество столбцов массива: ");
//   if ((row * column) % 2 == 0)
//   {
//     int[,] array = new int[row, column];
//     FillArray(array);
//     Console.WriteLine("Полученный массив:");
//     PrintArray(array);
//     Console.WriteLine("Журнал итераций:");
//     HardRandArray(array);
//     Console.WriteLine("Массив после рандомного перемешивания:");
//     PrintArray(array);
//   }
//   else
//     Console.WriteLine("Массив такой размерности содержит нечётное количество элементов!");
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ------------------------------------------