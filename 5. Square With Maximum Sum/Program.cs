using System;
using System.Linq;

int[] input = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int num1 = int.MinValue;
int num2 = int.MinValue;
int num3 = int.MinValue;
int num4 = int.MinValue;
int currentSum = int.MinValue;
int sum = int.MinValue;

int currentSum1 = int.MinValue;
int currentSum2 = int.MinValue;
int currentSum3 = int.MinValue;
int currentSum4 = int.MinValue;

int[,] twoD = new int[input[0], input[1]];

MethodForTwoD(twoD);

for (int i = 0; i < twoD.GetLength(0)-1; i++)
{
    for (int j = i+1; j <=i+1; j++)
    {
        for (int m = 1; m < twoD.GetLength(1); m++)
        {
            num1 = twoD[i, m - 1];
            num2 = twoD[i, m];
            num3 = twoD[j, m -1];
            num4 = twoD[j, m];

            currentSum=num1+ num2+ num3+ num4;
            if (currentSum> sum)
            {
                currentSum1 = num1;
                currentSum2 = num2;
                currentSum3 = num3;
                currentSum4 = num4;
                sum=currentSum1+ currentSum2+ currentSum3 + currentSum4;
            }
        }
    }
}

Console.WriteLine($"{currentSum1} {currentSum2}");
Console.WriteLine($"{currentSum3} {currentSum4}");
Console.WriteLine(sum);


void MethodForTwoD(int[,] twoD)
{
    for (int i = 0; i < twoD.GetLength(0); i++)
    {
        int[] tokens = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        for (int j = 0; j < twoD.GetLength(1); j++)
        {
            twoD[i, j] = tokens[j];
        }
    }
}