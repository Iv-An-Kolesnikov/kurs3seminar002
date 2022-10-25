//9. Напишите программу, которая выводит случайное число 
//из отрезка [10; 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8
Console.Clear();
//Console.Write();
int num = new Random().Next(10, 100);
Console.Write(num + " ");
int num1 = num % 10;
int num2 = num / 10;
if (num1 > num2)
{
    Console.Write(num1);
}
else
{
    Console.Write(num2);
}