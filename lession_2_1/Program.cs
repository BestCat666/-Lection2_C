//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98
int num = new Random().Next(100,1000);
int a1 = num / 100;
int a2 = (num - a1 * 100) / 10;
int a3 = (num - a1 * 100 - a2 * 10) % 10;
Console.WriteLine($"Случайное число: {num}");
Console.WriteLine($"Сотни: {a1}");
Console.WriteLine($"Десятки: {a2}");
Console.WriteLine($"Единицы: {a3}");
int num_out = a1 * 10 + a3;
Console.WriteLine($"Итоговое число: {num_out}");

//операция с числом как с текстом
string numstring = num.ToString();
string cutstring = String.Concat(numstring[0], numstring[2]);
Console.WriteLine($"Итоговое число (как строка): {cutstring}");

//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

int a = 10;
int b = 5;
if (a  b == 0)
{
   Console.WriteLine("первое число кратно второму");
}

https://github.com/danilazinin/Seminar-2/tree/main/PrG6
