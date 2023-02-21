/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
System.Console.WriteLine("Enter b1: "); 
double b1 = Double.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter k1: "); 
double k1 = Double.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter b2: "); 
double b2 = Double.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter k2: "); 
double k2 = Double.Parse(System.Console.ReadLine());
int y