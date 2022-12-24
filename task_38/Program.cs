// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
 
double [] arr = new double [7];
double max = 0;
double min = 1;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().NextDouble();
    arr[i] = Math.Round(arr[i], 3);
    Console.Write($"{arr[i]}, ");

    if (arr[i] < min)
    { 
       min = arr[i]; 
    }
    if (arr[i] > max)
    {
        max = arr[i];
    }
}
Console.Write("->" + Math.Round((max - min), 3));


