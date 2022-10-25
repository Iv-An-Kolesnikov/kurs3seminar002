//11. Напишите программу, которая выводит случайное трехзначное число
//и удаляет вторую цифру этого числа.

Console.Clear();
int num = new Random().Next(100, 1000);
int pervoe = num / 100;
int dvaPervih = num / 10;
int tretie = num - dvaPervih*10;

Console.WriteLine(num);
Console.Write(pervoe);
Console.WriteLine(tretie);