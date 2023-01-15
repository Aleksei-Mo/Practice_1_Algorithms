// Найти n-ое число Фибоначчи за O(n).
Console.Clear();
Console.Write("Enter lenght of fibbonachi series: ");
int fibLen = Convert.ToInt32(Console.ReadLine());
if (fibLen<0)
   {
     Console.WriteLine("The lenght should be more then ZERO!");
   }
else {
    int i = 1;
    int nextNum = 1;
    int prevNum= 1;
    int newNum= 0;
    while (i < fibLen ) {
        newNum = prevNum + nextNum;
        nextNum= prevNum;
        prevNum=newNum;
        i++;
    }
    Console.WriteLine($"The desired number is {newNum}.");
}
