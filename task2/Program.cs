Console.Write("Введите число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int res = 0;
while (chislo > 0)
{
    res = chislo % 10;
    sum = sum + res;
    chislo /= 10;
}
Console.WriteLine($"Сумма цифр в числе = {sum}");