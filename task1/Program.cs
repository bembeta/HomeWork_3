/* Напишите программу, которая принимает
   на вход пятизначное число и проверяет, является ли оно палиндромом.
*/
int GetNumber()
{
Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;    
}
int n = GetNumber();
int na = 0;
int nb = 0;
int nc = n;
while(n > 0)
{
    na = n % 10;
    nb = nb * 10 + na;
    n = n / 10;
}
if(nb == nc)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("число не является палиндромом");
}