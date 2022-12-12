// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите число для проверки : ");
int nums = Convert.ToInt32(Console.ReadLine());

int Politest(int num)
{
    int pal = 0;
    int number = num;
    while (number > 0)
    {
        pal = pal * 10 + number % 10;
        number = number / 10;
    }
    if (num == pal)
    {
        System.Console.WriteLine("Полидром");
    }
    else
    {
        System.Console.WriteLine("Не полидром");
    }
    return num;
}
Console.WriteLine(Politest(nums));