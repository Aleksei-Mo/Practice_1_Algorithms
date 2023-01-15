// Рекурсивно найти n-ое число Фибоначчи. Определить сложность.
Console.Clear();
Console.Write("Enter lenght of fibbonachi series: ");
int fibLen = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Fiban(fibLen));

int Fiban(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fiban(n - 1) + Fiban(n - 2);
}

