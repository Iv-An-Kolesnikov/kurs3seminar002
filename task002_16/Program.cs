//16. Напишите программу, которая принимает на вход два числа и проверяет,
//является ли одно число квадратом второго.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет
Console.Clear();
int num1;
int num2;
int max;
int result;
Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2) 
{
    max = num1;
    result = num2 * num2;
    if (result == max) Console.Write("Да");
    else Console.Write("Нет");
}
else 
{
    max = num2;
    result = num1 * num1;
    if (result == max) Console.Write("Да");
    else Console.Write("Нет");
}