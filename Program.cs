// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

// int[] array = new int [10];
// int count =0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().Next(100,1000);
//     if (array[i]%2==0) count++;
// }

// Console.WriteLine(String.Join(",",array));
// Console.WriteLine($"количество чётных чисел в массиве = {count}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int [5];
// int sum =0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().Next(-100,101);
//     if (i%2!=0) sum+=array[i];
// }

// Console.WriteLine(String.Join(",",array));
// Console.WriteLine($"сумма элементов, стоящих на нечётных позициях = {sum}");

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int [] {3,7,22,2,78};
int max =array[0];
int min =array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    else if (array[i] < min) min = array[i];
}
Console.WriteLine($"разница между максимальным и минимальным элементов массива = {max-min}");