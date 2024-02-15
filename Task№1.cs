/*******************************************************
* Степанов Артём Андреевич,ПИ-231
* Share-Link:https://https://onlinegdb.com/CzkaXUPZp
* Тема:  Базовые понятия языка С#, задание №1                             
********************************************************/
using System;

class Program
{
  public static int Main()
  {
    //число, которое нужно возвести в степень
    Console.Write("Введите число   : ");
    int num = int.Parse(Console.ReadLine());
    //степень числа
    Console.Write("Введите степень : ");
    int nam = int.Parse(Console.ReadLine());
    //число, возведенное в степень
    int num_n = 1;
    for (int per = 0; i < nam; ++per)
    {
      num_n *= num;
    }
    Console.WriteLine("{0} ^ {1} = {2}", num, nam, num_n);
    Console.ReadKey();
    return 0;
  }
}
