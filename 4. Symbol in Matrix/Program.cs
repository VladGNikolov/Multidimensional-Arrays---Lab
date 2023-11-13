using System;
using System.Linq;

int matrixParamether = int.Parse(Console.ReadLine());
char[,] cube = new char[matrixParamether, matrixParamether];
MethodForCube(cube);
char symbol = char.Parse(Console.ReadLine());

for (int i = 0; i < cube.GetLength(0); i++)
{
    for (int j = 0; j < cube.GetLength(1); j++)
    {
        char currentChar = cube[i, j];
        if (currentChar == symbol)
        {
            Console.WriteLine($"({i}, {j})");
            return;
        }
    }
}
Console.WriteLine($"{symbol} does not occur in the matrix");
void MethodForCube(char[,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        string input = Console.ReadLine();
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            cube[i, j] = input[j];
        }
    }
}