int InputInt(string message)
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}


int Degree(int num1, int num2)
{
    int degree = num1;
    for (int i = 1; i < num2; i++)
    {
        degree *= num1;
    }
    return degree;
}

int num1 = InputInt("введите число ");
int num2 = InputInt("введите степень ");
int degree = Degree(num1, num2);
System.Console.WriteLine($"число {num1} в степеги {num2} = {degree}");


