﻿// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите первое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = Enumerable.Range(1, N).ToArray();
int Langht = array.Length;
int index = 0;

while (index < Langht)
{
    if (array[index] % 2 == 0)
        Console.Write(array[index] + " ");
    index++;
    
}