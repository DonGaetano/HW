// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число N");

string num1 = Console.ReadLine()!;
int parsed1 = int.Parse(num1);

int count = 0;
int number = 1;
number = number++;

while (number <= parsed1)
{
    for (int i = 1; i % 2 == 0; i++)
    {
        count = count++;
    }
}
Console.WriteLine("От 1 до " + parsed1 + " всего " + count + " четных чисел");


