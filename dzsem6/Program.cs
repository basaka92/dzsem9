// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// -------------------- Код задачи 41 --------------------

// int[] Input (string msg)
// {
//   string numbers = "";
//   Console.WriteLine(msg);
//   numbers = Console.ReadLine();
//   int[] arr = numbers.Split(",").Select(Int32.Parse).ToArray();
//   return arr;
// }

// int NumbersAboveZero (int[] arr)
// {
//   int res = 0;
//   for (int i =0; i<arr.Length; i++)
//   {
//     if (arr[i]>0)
//     res++;
//   }
//   return res;
// }

// try
// {
//   int[] numbersArr = Input("Введите целые числа (через запятую): ");
//   int numbersAbZero = NumbersAboveZero(numbersArr);
//   Console.Write($"Количество чисел больше нуля = {numbersAbZero}");
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ----------------------------------------

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// -------------------- Код задачи 43 --------------------

// double Input (string msg)
// {
//   Console.WriteLine(msg);
//   double result = Double.Parse(Console.ReadLine());
//   return result;
// }

// void IntersectionPoint (double k1,double k2,double b1,double b2)
// {
//   if (k1==k2)
//   {
//     if (b1!=b2)
//     Console.WriteLine("Прямые параллельны");
//     else
//     Console.WriteLine("Прямые совпадают");
//   }
//   else
//   {
//     double x = (b2-b1)/(k1-k2);
//     double y = k1*x+b1;
//     Console.WriteLine($"Точка пересечения: ({x}; {y})");
//   }
// }

// try
// {
//   Console.WriteLine("Прямые заданны уравнениями: y = k1 * x + b1, y = k2 * x + b2;");
//   double k1 = Input("Введите k1: ");
//   double k2 = Input("Введите k2: ");
//   double b1 = Input("Введите b1: ");
//   double b2 = Input("Введите b2: ");
//   IntersectionPoint(k1,k2,b1,b2);
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ----------------------------------------

// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте список чисел НегаФибоначчи, в том числе для отрицательных индексов.

// *Пример:*

// - для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

// -------------------- Код задачи НЕГАФИБОНАЧЧИ --------------------

// int Input(string msg)
// {
//   Console.Write(msg);
//   int result = Int32.Parse(Console.ReadLine());
//   return result;
// }

// void PrintArray(int[] array)
// {
//   foreach (var el in array)
//     Console.Write($"{el} ");
// }

// int[] NegaFibonachi(int n)
// {
//   int[] array = new int[n * 2 + 1];
//   array[n] = 0;
//   array[n - 1] = array[n + 1] = 1;
//   for (int i = n + 2; i < array.Length; i++)
//   {
//     array[i] = array[i - 2] + array[i - 1];
//     array[n*2 - i] = array[n*2 - i + 2] - array[n*2 - i + 1];
//   }
//   return array;
// }


// try
// {
//   int n = Input("Введите целое положительное число: ");
//   int[] array;
//   if (n == 0)
//     array = new int[1] { 0 };
//   else if (n == 1)
//     array = new int[3] { 1, 0, 1 };
//   else
//   {
//     array = NegaFibonachi(n);
//   }
//   PrintArray(array);
// }
// catch
// {
//   Console.WriteLine("Введены некорректные данные!");
// }

// ----------------------------------------

// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. Определить , является ли это сторонами треугольника. Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.

// -------------------- Код задачи 40 --------------------

int Input(string msg)
{
  Console.Write(msg);
  int result = Int32.Parse(Console.ReadLine());
 if (result < 0) 
 {
  Console.WriteLine("Введены некорректные данные!");
  Environment.Exit(0);
 }
  return result;
}

bool Triangle(int side1, int side2, int side3)
{
  bool res = false;
  if (side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 + side2)
    res = true;
  return res;
}

double[] TriangleAngle(double side1, double side2, double side3)
{
  double[] angleArray = new double[3];
  angleArray[0] = (180 / Math.PI) * Math.Acos((Math.Pow(side1, 2) + Math.Pow(side3, 2) - Math.Pow(side2, 2)) / (2 * side1 * side3));
  angleArray[1] = (180 / Math.PI) * Math.Acos((Math.Pow(side1, 2) + Math.Pow(side2, 2) - Math.Pow(side3, 2)) / (2 * side1 * side2));
  angleArray[2] = (180 / Math.PI) * Math.Acos((Math.Pow(side2, 2) + Math.Pow(side3, 2) - Math.Pow(side1, 2)) / (2 * side3 * side2));
  return angleArray;
}

void TrianglePerimeter(int side1, int side2, int side3)
{
  int res = side1 + side2 + side3;
  Console.WriteLine($"Периметр треугольника = {res}");
}

void TriangleSquare(double side1, double side2, double side3)
{
  double polP = (side1 + side2 + side3) / 2;
  double res = Math.Sqrt(polP * (polP - side1) * (polP - side2) * (polP - side3));
  Console.WriteLine($"Периметр треугольника = {res}");
}

void TriangleType(int side1, int side2, int side3, double[] arrayAngle)
{
  if (side1 == side2 && side2 == side3)
  {
    Console.WriteLine("Этот треугольник равносторонний");
  }
  else if (side1 == side2 || side2 == side3 || side1 == side3)
  {
    Console.WriteLine("Этот треугольник равнобедренный");
  }
  for (int i = 0; i < arrayAngle.Length; i++)
  {
    if (arrayAngle[i] == 90)
      Console.WriteLine("Этот треугольник прямоугольный");
  }
}

void PrintAngleArray(double[] array)
{
  Console.Write("Углы треугольника в градусах (alpha, beta gamma): ");
  foreach (var el in array)
    Console.Write($"{Math.Round(el, 2)}; ");
}

try
{
  int side1 = Input("Введите сторону A (целое положительное число): ");
  int side2 = Input("Введите сторону B (целое положительное число): ");
  int side3 = Input("Введите сторону C (целое положительное число): ");
  
  if (Triangle(side1, side2, side3) == true)
  {
    Console.WriteLine("Такой треугольник существует!");
    PrintAngleArray(TriangleAngle(side1, side2, side3));
    Console.WriteLine();
    TrianglePerimeter(side1, side2, side3);
    TriangleSquare(side1, side2, side3);
    TriangleType(side1, side2, side3, TriangleAngle(side1, side2, side3));
  }
  else
    Console.WriteLine("Треугольника с такими сторонами не существует!");
}
catch
{
  Console.WriteLine("Введены некорректные данные!");
}

// ----------------------------------------