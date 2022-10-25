//14. Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
Console.Clear();
int num;
int num1;
int num2;
Console.Write("Введите пожалуйста число: ");
num = Convert.ToInt32(Console.ReadLine());
num1 = num % 7;
num2 = num % 23;
if ((num1 == 0) && (num2 == 0))
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}