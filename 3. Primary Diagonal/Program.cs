using System;
using System.Linq;

int size =int.Parse(Console.ReadLine());
int[,] cube = new int[size,size];
MethodForCube(cube);
int sum = 0;
for (int i = 0; i < size; i++)
{
    sum += cube[i,i];
}
Console.WriteLine(sum);
void MethodForCube(int[,] cube)
{
   for (int i = 0; i < cube.GetLength(0); i++)
    {
        int[] input = Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        for (int j = 0; j < cube.GetLength(1); j++) 
        {
            cube[i,j] = input[j];
        }
    }
}