﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] arr = new int [5];
int count = 0;
 for (int i = 0; i < arr.Length; i++)
 {
  arr[i] = new Random().Next(100, 1000);
  if (arr[i] % 2 == 0)
  {
    count++;
  }
  Console.Write($"{arr[i]}, ");
 }
 Console.WriteLine("->" + count);
 
