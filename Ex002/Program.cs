// Задача 26. Напишите программу которая принимает на вход число
// и выдаёт колличество цифр в числе
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int resault = 0;
while (n > 0)
{
    n = n / 10;
    resault++;
}
Console.WriteLine(resault);