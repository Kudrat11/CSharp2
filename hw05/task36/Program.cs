// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] arr = new int[6];

int[] array(int[] qwery)
{
    Random rand = new Random();
    int res = 0;

    for (int i = 0; i < qwery.Length; i++)
    {
        qwery[i] = rand.Next(-9, 10);
    }
    for (int i = 1; i < qwery.Length; i += 2)
    {
        res = qwery[i] + res;
    }
    Console.WriteLine(string.Join(", ", qwery));
    Console.WriteLine($"Сумма элементов array[1], [3], [5] = {res}");
    return qwery;
}
System.Console.WriteLine(array(arr));