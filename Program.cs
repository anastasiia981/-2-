// : Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());


int [] array = new int[num];

void CreateArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
        Console.WriteLine(array[i]+ " ");
    }
}

int FindNumber()
{

    int countNum= 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (num % 2 == 0)
        {
        countNum = countNum+1;
        }
    }
    return countNum;
}

CreateArray();
int newNum = FindNumber();

Console.WriteLine();
Console.WriteLine($"Количество четных чисел: {num}");

