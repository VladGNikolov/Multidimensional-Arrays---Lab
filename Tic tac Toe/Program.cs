using System.Diagnostics.Metrics;
using System.Linq.Expressions;

string[][] jaggedArray = new string[3][];
for (int row = 0; row < jaggedArray.Length; row++) 
{
    jaggedArray[row] = new string[3];

    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        jaggedArray[row][col] = "!!";
    }
}


while (true)
{
    foreach (string [] item in jaggedArray)
    {
        Console.Write(string.Join(" ", item));
        Console.WriteLine();
    }

    Console.WriteLine("Player 1");

    string[] tokens = Console.ReadLine().Split(" ");

    int row = int.Parse(tokens[0])-1;
    int col = int.Parse(tokens[1])-1;

    jaggedArray[row][col] = "X";

    foreach (string[] item in jaggedArray)
    {
        Console.Write(string.Join(" ", item));
        Console.WriteLine();
    }

    if (jaggedArray[0][0] == "X" && jaggedArray[1][0] == "X" && jaggedArray[2][0] == "X")
    {
        Console.WriteLine("Player 1 Win!");
        return;
    }
    else if (jaggedArray[0][0] =="X" && jaggedArray[0][1]=="X" && jaggedArray[0][2]== "X")
    {
        Console.WriteLine("Player 1 Win!");
        return;
    }
    else if (jaggedArray[0][0] == "X" && jaggedArray[1][1] == "X" && jaggedArray[2][2] == "X")
    {
        Console.WriteLine("Player 1 Win!");
        return;
    }
    else if (jaggedArray[0][2] == "X" && jaggedArray[1][2] == "X" && jaggedArray[2][2] == "X")
    {
        Console.WriteLine("Player 1 Win!");
        return;
    }
    else if (jaggedArray[2][0] == "X" && jaggedArray[2][1] == "X" && jaggedArray[2][2] == "X")
    {
        Console.WriteLine("Player 1 Win!");
        return;
    }
    int counter = 0;

    for (int i = 0; i < jaggedArray.Length; i++)
    {
        for (int j = 0; j < jaggedArray[i].Length; j++)
        {

            if (jaggedArray[i][j] == "!!")
            {
                break;
            }
            else
            {
                counter++;
            }
            if (counter == 9)
            {
                Console.WriteLine("No winner!");
                return;
            }
        }
    }
    counter=0;
                Console.WriteLine("Player 2");

    tokens = Console.ReadLine().Split(" ");

    row = int.Parse(tokens[0]) - 1;
    col = int.Parse(tokens[1]) - 1;

    jaggedArray[row][col] = "0";

    if (jaggedArray[0][0] == "0" && jaggedArray[1][0] == "0" && jaggedArray[2][0] == "0")
    {
        Console.WriteLine("Player 2 Win!");
        return;
    }
    else if (jaggedArray[0][0] == "0" && jaggedArray[0][1] == "0" && jaggedArray[0][2] == "0")
    {
        Console.WriteLine("Player 2 Win!");
        return;
    }
    else if (jaggedArray[0][0] == "0" && jaggedArray[1][1] == "0" && jaggedArray[2][2] == "0")
    {
        Console.WriteLine("Player 2 Win!");
        return;
    }
    else if (jaggedArray[0][2] == "0" && jaggedArray[1][2] == "0" && jaggedArray[2][2] == "0")
    {
        Console.WriteLine("Player 2 Win!");
        return;
    }
    else if (jaggedArray[2][0] == "0" && jaggedArray[2][1] == "0" && jaggedArray[2][2] == "0")
    {
        Console.WriteLine("Player 2 Win!");
        return;
    }
    for (int i = 0; i < jaggedArray.Length; i++)
    {
        for (int j = 0; j < jaggedArray[i].Length; j++)
        {
            
            if (jaggedArray[i][j]=="!!")
            {
                break;
            }
            else
            {
                counter++;
            }
            if (counter==9)
            {
                Console.WriteLine("No winner!");
                return;
            }
        }
    }
}
