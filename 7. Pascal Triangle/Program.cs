long rows = int.Parse(Console.ReadLine());

long[][] triangel = new long[rows][];

for (long row = 0; row < rows; row++)
{
    triangel[row] = new long[row +1];
    triangel[row][0] = 1;
    triangel[row][triangel[row].Length-1]= 1;

    for (long col = 1; col < triangel[row].Length-1; col++)
    {
        triangel[row][col] = triangel[row-1][col - 1] + triangel[row - 1][col];
    }
}

foreach (long[] item in triangel)
{
    Console.WriteLine(string.Join(" ",item));
}
