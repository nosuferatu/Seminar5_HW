﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Например:
// [345, 897, 568, 234] -> 2


Console.Clear();

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Заданный массив: ");
PrintArray(numbers);

int count = 0;

for (int t = 0; t < numbers.Length; t++)
if (numbers[t] % 2 == 0)
count++;

Console.WriteLine($"Количество четных чисел = {count}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// Например:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Clear();

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Заданный массив: ");
PrintArray(numbers);

int sum = 0;

for (int t = 1; t < numbers.Length; t+=2)
    sum = sum + numbers[t];

    Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(-100,100);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Например:
// [3 7 22 2 78] -> 76


Console.Clear();

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Заданный массив: ");
PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int t = 0; t < numbers.Length; t++)
{
    if (numbers[t] > max)
        {
            max = numbers[t];
        }
    if (numbers[t] < min)
        {
            min = numbers[t];
        }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением элементов массива = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}