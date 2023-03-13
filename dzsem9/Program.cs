// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// -------------------- Код задачи 64 --------------------

// int InputInt32(string message)
// {
//   Console.WriteLine(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// string NumbersN(int N)
// {
//   if (N == 1) return $"{N}";
//   return $"{N}, " + $"{NumbersN(N - 1)}";
// }

// try
// {
//   int N = InputInt32("Введите целое положительное число больше нуля:");
//   if (N <= 0)
//   {
//     Console.WriteLine("Введены некорректные данные!");
//   }
//   else
//   {
//     Console.Write($"Натуральные числа в промежутке от {N} до 1: " + '"' + NumbersN(N) + '"');
//   }
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ----------------------------------------

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// -------------------- Код задачи 66 --------------------

// int InputInt32(string message)
// {
//   Console.WriteLine(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int SummNumbers(int M, int N)
// {
//   if (M == N) return N;
//   return M + SummNumbers(M + 1, N);
// }

// try
// {
//   int M = InputInt32("Введите целое число M:");
//   int N = InputInt32("Введите целое число N больше M:");
//   if (M > N)
//     Console.WriteLine("Введены некорректные данные!");
//   else
//     Console.Write($"Сумма натуральных элементов в промежутке от {M} до {N} равна {SummNumbers(M, N)}.");
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ----------------------------------------

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// -------------------- Код задачи 68 --------------------

// int InputInt32(string message)
// {
//   Console.WriteLine(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int Akkerman(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
//   else return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// try
// {
//   int m = InputInt32("Введите целое положительное число m:");
//   int n = InputInt32("Введите целое положительное число n:");
//   if (m < 0 || n < 0)
//     Console.WriteLine("Введены некорректные данные!");
//   else
//     Console.Write($"Функция Аккермана, A({m},{n}) = {Akkerman(m, n)}.");
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ----------------------------------------