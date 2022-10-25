//12. Напишите программу, которая будет принимать на вход два числа
//и выводить, является ли второе число кратно первому. Если число 2 не кратно числу 1,
//то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.Clear();
int num1;
int num2;
int result;
Console.Write("Введите, пожалуйста первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите, пожалуйста второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());
if (num2 == 0) Console.WriteLine("Задайте пожалуйста второе число отлично от нуля!");
else
{
    result = num1 % num2;
    if (result == 0)
        {
            Console.WriteLine("Число кратно!");
        }
    else
        {
            Console.WriteLine("Число не кратно, остаток: " + result);
        }
}