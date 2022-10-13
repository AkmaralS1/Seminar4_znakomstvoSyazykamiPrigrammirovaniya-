// ЗАдача 24. Напишите прогармму которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А
Console.Clear();
Console.Write("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1, result = 0;
while (i <= n)
{
    result += i;
    i++;
}
Console.WriteLine(result);
// Можно записать код иначе:
// Console.WriteLine((1 + n) / 2 * n);