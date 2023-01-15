Console.Clear();
int [,] Array = { { 1, 2,3,4,5 }, { 1, 2,3,4,5  },{ 1, 2,3,4,5 }, { 1, 2,3,4,5  }, { 1, 2,3,4,5 } };
int mainDiagSum = 0;
int slaveDiagSum = 0;
int len=Array.GetLength(0);
PrintArray(Array);
for (int i = 0; i <len; i++)
{
    mainDiagSum=mainDiagSum + Array[i,i];
    slaveDiagSum=slaveDiagSum + Array[i,len-i-1];
}
Console.WriteLine();
Console.WriteLine($"Sum of the main diagonal is {mainDiagSum}.");
Console.WriteLine();
Console.WriteLine($"Sum of the slave diagonal is {slaveDiagSum}.");
Console.WriteLine();

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

