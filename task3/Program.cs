/*  Напишите программу, которая принимает на вход число (N)
    и выдаёт таблицу кубов чисел от 1 до N.
 */

int GetNumber()
{
Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number; 
}
int number = GetNumber();

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i}, ");
}

