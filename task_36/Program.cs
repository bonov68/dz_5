// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0);

int [] arr = new int [7];  
int res = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-10, 20);
    Console.Write($"{arr[i]}, ");
    if (i % 2 != 0) 
{
  res = res + arr[i];
}
}
Console.WriteLine("->" + res);
