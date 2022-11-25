// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите первое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
//int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9 ,10};
//int Langht = array.Length;
//int index = 0;

while (i <= N)
{
    if (i % 2 == 0)
        Console.Write(i + ", ");
    i++;    
}


