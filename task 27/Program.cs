// Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());


int result = 0;


int Sum(int number)
{
    while (num>0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

int digitsSum = Sum(num);
Console.WriteLine($"Сумма цифр в числе = {digitsSum}");