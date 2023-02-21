/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/
System.Console.WriteLine("How many numbers you want to enter: "); 
int M = Int32.Parse(System.Console.ReadLine());
ToCountPositiveNumbersInMArray (M);

void ToCountPositiveNumbersInMArray (int M)
{
    int [] MArray= new int [M];
    int count=0;
    for (int i=0; i<M; i++)
    {
     System.Console.WriteLine("Enter number: ");
     MArray[i]=Int32.Parse(System.Console.ReadLine());
     if (MArray[i]>0)
     {
        count++;
     }
    }
    System.Console.WriteLine(count);
}