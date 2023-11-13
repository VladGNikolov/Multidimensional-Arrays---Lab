using System.Linq;
using System;

int numOfRows = int.Parse(Console.ReadLine());

int[][] ints = new int[numOfRows][];

for (int i = 0; i < numOfRows; i++) 
{
    int [] input = Console.ReadLine()
        .Split(" ")
        .Select(int.Parse)
        .ToArray();
    ints[i] = input;
}

string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

while (command[0] != "END")
{
    if (command[0] == "Add")
    {
        int currentRow= int.Parse(command[1]);
        int currentCols = int.Parse(command[2]);
        int num = int.Parse(command[3]);

        if (ints.Length-1>= currentRow && currentRow>=0)
        {
            if (ints[currentRow].Length-1>= currentCols && currentCols>=0)
            {

            ints[currentRow][currentCols] = ints[currentRow][currentCols] + num;
            }
            else
            {
                Console.WriteLine("Invalid coordinates");
                
            }
        }
        else
        {
            Console.WriteLine("Invalid coordinates");
        }
    }
    else if (command[0]== "Subtract")
    {
        int currentRow = int.Parse(command[1]);
        int currentCols = int.Parse(command[2]);
        int num = int.Parse(command[3]);
        if (ints.Length-1 >=currentRow && currentRow >= 0)
        {
            if (ints[currentRow].Length-1 >= currentCols && currentCols >= 0)
            {

                ints[currentRow][currentCols] = ints[currentRow][currentCols] - num;
            }
            else
            {
                Console.WriteLine("Invalid coordinates");
                
            }
        }
        else
        {
            Console.WriteLine("Invalid coordinates");
        }
    }
    command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
}

foreach (int [] item in ints)
{
    Console.Write(String.Join(" ",item));
    Console.WriteLine();
}