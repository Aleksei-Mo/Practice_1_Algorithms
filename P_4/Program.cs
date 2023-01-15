// Реализовать сдвиг элементов в массиве на n влево или вправо.
Console.Clear();
Console.Write("Enter offset: ");
int offset = Convert.ToInt32(Console.ReadLine());
int [] array = {1,2,3,4,5,6,7};
int len=array.Length;
Console.Write("Current array: ");
PrintArray(array);
Console.WriteLine();
for (int i = 0; i <offset; i++)
{
 int temp = array[0];
    for (int j = 1; j <len; j++)
    {
     array[j-1]=array[j];
    }
 array[len-1] =temp; 
PrintArray(array);
Console.WriteLine();
}


void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}