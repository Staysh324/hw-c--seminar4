int InputInt(string message)
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

void MassIn(int[] arr, int max, int min, int length)
{
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(min, max);
        System.Console.Write(arr[i] + ", ");
    }
}


int length = InputInt("введите размер массива");
int min = InputInt("введите минимальное число для заполнения ячейки массива");
int max = InputInt("введите максимальное число для заполнения ячейки массива");
int[] arr = new int[length];
MassIn(arr, max, min, length);









