

using System;
using System.Linq;

int[] rowsAndCols = Console.ReadLine()
    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int row = rowsAndCols[0];
int col = rowsAndCols[1];
int[] input = new int[col];
int[,] twoD = new int[row, col];

for (int i = 0; i < row; i++) 
{
   input=Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int j = 0; j < col; j++)
    {
        twoD[i, j] = input[j];
    }
}

Console.WriteLine(  row);
Console.WriteLine(  col);
MethodForSum(twoD);
void MethodForSum(int[,] twoD)
{
    
int sum = 0;

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        sum+= twoD[i, j];
    }
}
Console.WriteLine(sum);
}


