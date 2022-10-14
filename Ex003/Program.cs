// Задача 30. Напишите программу которая выводит массив из
// 8 элементов заполненный нулями и единицами в случайном порядке
Console.Clear();
int[] array = new int[8]; // это значит что в массиве должно находится 8 элементов
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 2);
Console.WriteLine($"[{string.Join(", ", array)}]");