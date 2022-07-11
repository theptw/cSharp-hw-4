Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = num1;

for (int i = 2; i <= num2; i++)
{
    result = result * num1;
}

Console.WriteLine($"Результат возведения {num1} в степень {num2} = {result} ");
