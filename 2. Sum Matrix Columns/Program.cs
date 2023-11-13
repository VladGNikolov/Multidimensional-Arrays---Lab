
using System;
using System.Linq;

int[] rowsAndCols = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[,] twoD = new int[rowsAndCols[0], rowsAndCols[1]];

    MethodFortwoD(twoD);
int sum = 0;
for (int i = 0; i < twoD.GetLength(1); i++)
{
    for (int j = 0; j < twoD.GetLength(0); j++)
    {
        sum+= twoD[j,i];
    }
    Console.WriteLine(sum);
    sum=0;
}

void MethodFortwoD(int[,] twoD)
{
    
   for (int i = 0; i < twoD.GetLength(0); i++)
    {
        int[] input = Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        for (int j = 0; j < twoD.GetLength(1); j++) 
        {
            twoD[i,j] = input[j];
        }
    }
}