﻿//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int FindSum (int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

int result = FindSum (9012);
Console.WriteLine ($"Сумма всех цифр числа равна {result}");