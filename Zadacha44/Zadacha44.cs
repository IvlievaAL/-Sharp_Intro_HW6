/*Задача 44:выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5
--> 0 1 1 2 3
Если N = 3
--> 0 1 1
Если N = 7
--> 0 1 1 2 3 5 8*/
System.Console.WriteLine("Enter N"); 
int N = Int32.Parse(System.Console.ReadLine());
MassiveAsString (Fibonachi(N));
int[] Fibonachi (int N)
{
    int[] FibonachiArray = new int [N];
    int N1=0;
    int N2=1;
    if (N==1)
    {
     FibonachiArray[0]=N1;
    }
    else if (N==2)
    {
        FibonachiArray[0]=N1;
        FibonachiArray[1]=N2;
    }
    else if (N>2)
    {
        FibonachiArray[0]=N1;
        FibonachiArray[1]=N2;
        for (int i=2; i<=N-1;i++)
        {
          FibonachiArray[i]=FibonachiArray[i-1]+FibonachiArray[i-2];
        }
    }
    return FibonachiArray;
}
void MassiveAsString (int [] FibonachiArray)
{
    string ArrayAsString = string.Join(" , ", FibonachiArray); 
    System.Console.WriteLine(ArrayAsString);
}