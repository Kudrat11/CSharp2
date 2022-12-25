// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] arr = new int[5];

int[] array(int[] qwery)
{
    Random rand = new Random();
    int count = 0;

    for (int i = 0; i < qwery.Length; i++)
    {
        qwery[i] = rand.Next(100, 1000);
        if (qwery[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.Write(string.Join(", ", qwery));
    System.Console.Write(" -> ");
    Console.WriteLine(count);
    System.Console.WriteLine();
    return qwery;
}
System.Console.WriteLine(array(arr));