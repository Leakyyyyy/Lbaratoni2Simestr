/*******************************************************
* Степанов Артём Андреевич,ПИ-231
* Share-Link:https://https://onlinegdb.com/CzkaXUPZp
* Тема:  Базовые понятия языка С#, задание №2                             
********************************************************/
using System;

class Program
{
    static void Main(string[] args)
    {
        // Вводим значение числа x с клавиатуры
        Console.Write("Введите число x (x >= 100): ");
        int x = int.Parse(Console.ReadLine());

        // Получаем вторую цифру числа x
        int secondDigit = (x / 10) % 10;

        // Зачеркиваем вторую цифру числа x
        int newX = x / 100 * 10 + x % 10;

        // Получаем число n, добавляя зачеркнутую вторую цифру x в конец числа newX
        int n = newX * 10 + secondDigit;

        // Выводим полученное значение числа n
        Console.WriteLine("n = " + n);
    }
}
