// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// -------------------- Код задачи 54----------------------

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

// void SortRowArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     int sortCount = 0;
//     while (sortCount < array.GetLength(1) - 1)
//     {
//       sortCount = 0;
//       for (int j = 0; j < array.GetLength(1) - 1; j++)
//       {
//         if (array[i, j] < array[i, j + 1])
//           (array[i, j], array[i, j + 1]) = (array[i, j + 1], array[i, j]);
//         else
//           sortCount++;
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
//   SortRowArray(array);
//   PrintArray(array);
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ------------------------------------------

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// -------------------- Код задачи 56----------------------

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
//       array[i, j] = new Random().Next(0, 5);
//   }
// }

// string ArrayMinSumRow(int[,] array)
// {
//   int minSumRowElem = 0;
//   string MinRow = "1; ";
//   for (int j = 0; j < array.GetLength(1); j++)
//     minSumRowElem += array[0, j];
//   for (int i = 1; i < array.GetLength(0); i++)
//   {
//     int sumRowElem = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       sumRowElem += array[i, j];
//     }
//     if (minSumRowElem > sumRowElem)
//     {
//       minSumRowElem = sumRowElem;
//       MinRow = i + 1 + "; ";
//     }
//     else if (minSumRowElem == sumRowElem)
//       MinRow += i + 1 + "; ";
//   }
//   return MinRow;
// }

// try
// {
//   int row = InputInt32("Введите количество строк массива: ");
//   int column = InputInt32("Введите количество столбцов массива: ");
//   int[,] array = new int[row, column];
//   FillArray(array);
//   Console.WriteLine("Полученный массив:");
//   PrintArray(array);
//   Console.Write($"Строка(и) массива с наименьшей суммой элементов: {ArrayMinSumRow(array)}");
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ------------------------------------------

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// -------------------- Код задачи 58----------------------

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
//       Console.Write($"{array[i, j],3} \t");
//     Console.WriteLine();
//   }
// }

// void FillArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       array[i, j] = new Random().Next(0, 11);
//   }
// }

// int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
// {
//   int[,] resMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
//   for (int p = 0; p < firstMatrix.GetLength(1); p++)
//   {
//     for (int i = 0; i < resMatrix.GetLength(0); i++)
//     {
//       for (int j = 0; j < resMatrix.GetLength(1); j++)
//       {
//         resMatrix[i, j] += firstMatrix[i, p] * secondMatrix[p, j];
//       }
//     }
//   }
//   return resMatrix;
// }

// try
// {
//   int row1 = InputInt32("Введите количество строк первой матрицы: ");
//   int column1 = InputInt32("Введите количество столбцов первой матрицы: ");
//   int row2 = InputInt32("Введите количество строк второй матрицы: ");
//   int column2 = InputInt32("Введите количество столбцов второй матрицы: ");
//   if (column1 == row2)
//   {
//     int[,] firstMatrix = new int[row1, column1];
//     int[,] secondMatrix = new int[row2, column2];
//     FillArray(firstMatrix);
//     FillArray(secondMatrix);
//     Console.WriteLine("Первая матрица:");
//     PrintArray(firstMatrix);
//     Console.WriteLine("Вторая матрица:");
//     PrintArray(secondMatrix);
//     Console.WriteLine("Результат перемножения заданных матриц:");
//     PrintArray(MatrixMultiplication(firstMatrix, secondMatrix));
//   }
//   else
//     Console.WriteLine("Перемножить матрицы такой размерности нельзя!");
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ------------------------------------------

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// -------------------- Код задачи 62----------------------

// void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       Console.Write($"{array[i, j],3} \t");
//     Console.WriteLine();
//   }
// }

// void SpiralFillArray(int[,] array)
// {
//   int wall = 0;
//   int number = 1;
//   while (number < array.Length)
//   {
//     for (int j = wall; j < array.GetLength(1) - wall; j++)
//     {
//       array[wall, j] = number;
//       number++;
//     }
//     for (int i = wall + 1; i < array.GetLength(0) - wall; i++)
//     {
//       array[i, array.GetLength(1) - wall - 1] = number;
//       number++;
//     }
//     for (int j = array.GetLength(1) - wall - 2; j > wall - 1; j--)
//     {
//       array[array.GetLength(0) - wall - 1, j] = number;
//       number++;
//     }
//     for (int i = array.GetLength(0) - wall - 2; i > wall; i--)
//     {
//       array[i, wall] = number;
//       number++;
//     }
//     wall++;
//   }
//   if (array.Length % 2 != 0)
//   {
//     array[(array.GetLength(0) - 1) / 2, (array.GetLength(1) - 1) / 2] = number;
//   }
// }

// int[,] array = new int[5, 5];
// SpiralFillArray(array);
// PrintArray(array);

// ------------------------------------------

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// -------------------- Код задачи 60----------------------

// int InputInt32(string message)
// {
//   Console.WriteLine(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// void PrintArray(int[,,] array)
// {
//   for (int k = 0; k < array.GetLength(2); k++)
//   {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//       for (int j = 0; j < array.GetLength(1); j++)
//         Console.Write($"{array[i, j, k],2}({i},{j},{k}) \t");
//       Console.WriteLine();
//     }
//   }
// }

// void FillArray(int[,,] array)
// {
//   int indexCount = 0;
//   int randomNumber = 0;
//   int[] duplicateNumbersArray = new int[array.Length];
//   duplicateNumbersArray[0] = new Random().Next(10, 100);
//   for (int k = 0; k < array.GetLength(2); k++)
//   {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//         bool check = false;
//         while (check == false)
//         {
//           check = true;
//           randomNumber = new Random().Next(10, 100);
//           foreach (var element in duplicateNumbersArray)
//             if (element == randomNumber) { check = false; }
//         }
//         array[i, j, k] = randomNumber;
//         duplicateNumbersArray[indexCount] = randomNumber;
//         indexCount++;
//       }
//     }
//   }
// }
// try
// {
//   Console.WriteLine("Общее количество элементов массива не должно превышать 90!");
//   int row = InputInt32("Введите количество строк трёхмерного массива: ");
//   int column = InputInt32("Введите количество столбцов трёхмерного массива: ");
//   int depth = InputInt32("Укажите глубину трёхмерного массива: ");
//   int[,,] array = new int[row, column, depth];
//   if (array.Length>90)
//   Console.WriteLine("Введены некорректные данные!");
//   else
//   {
//   FillArray(array);
//   Console.WriteLine("Полученный трёхмерный массив:");
//   PrintArray(array);
//   }
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ------------------------------------------