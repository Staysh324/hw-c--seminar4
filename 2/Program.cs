int InputInt(string message)
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int SumNumber(int num1)
{
int count = 1;
int sum =0;
while (count<=num1)
{
   int remainder = num1%10;
   num1/=10;
   sum+=remainder;
}
return sum;
}

int num1 = InputInt("введите число");
int sum = SumNumber(num1);
System.Console.WriteLine($"сумма чисел из {num1} = {sum}");