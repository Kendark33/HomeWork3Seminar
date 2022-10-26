/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

void CheckNumber()
{
    Console.Write("Введите пятизначное число: ");
    int number = int.Parse(Console.ReadLine());
    int numberX = number / 10000 % 10;
    int numberY = number / 1000 % 10;
    int revX = number / 10 % 10;
    int revY = number % 10;
    int nul = number / 10000;

    for (int i = 0; i < 10; i++)
    {
        break;
    }
    if (nul < 1 || nul > 9)
    {
        Console.WriteLine(number + " -> " + "Не корректное число, требуется написать пятизначное число, повторите попытку: ");
    }
    else if (numberX == revY && numberY == revX)
    {
        Console.WriteLine(number + " -> Данное число является палиндромом");
    }
    else
    {
        Console.WriteLine(number + " -> Не является палиндромом");
    }
}
CheckNumber();