// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите числа: ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int Numbers(int[] arr)
// {
// int numbers = 0;
 
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0) numbers++;
// }
// return numbers;
// }
// int numbers = Numbers(arr);
// Console.WriteLine($"Количество чисел больше нуля ----> {numbers}");



//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

 double[,] line = new double[2, 2]; 
 double[] crossPoint = new double[2]; 
 
 void InputCoefficients()
 { 
   for (int i = 0; i < line.GetLength(0); i++) 
   { 
     Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n"); 
     for (int j = 0; j < line.GetLength(1); j++) 
     { 
       if(j==0) Console.Write($"Введите коэффициент k: "); 
       else Console.Write($"Введите коэффициент b: "); 
       line[i,j] = Convert.ToInt32(Console.ReadLine()); 
     } 
   } 
 } 
 
 
 double[] Decision(double[,] line) 
 { 
   crossPoint[0] = (line[1,1] - line[0,1]) / (line[0,0] - line[1,0]); 
   crossPoint[1] = crossPoint[0] * line[0,0] + line[0,1]; 
   return crossPoint; 
 } 
 
 void OutputResponse(double[,] line) 
 { 
   if (line[0,0] == line[1,0] && line[0,1] == line[1,1])  
   { 
     Console.Write($"\nПрямые совпадают"); 
   } 
   else if (line[0,0] == line[1,0] && line[0,1] != line[1,1])  
   { 
     Console.Write($"\nПрямые параллельны"); 
   } 
   else  
   { 
     Decision(line); 
     Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})"); 
   } 
 } 
 
 
 InputCoefficients(); 
 OutputResponse(line); 

