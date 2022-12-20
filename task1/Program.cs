int Expo(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }
    // int result = Math.Pow(num1, num2);
    return result;
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int exponentiation = Expo(num1, num2);
Console.WriteLine($"Ответ: {exponentiation}");