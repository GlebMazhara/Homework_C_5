void InputArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    array[i] = new Random().Next(0, 100);
}

void ReleaseArray(int[] array)
{
    int max = 0, min = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if (array[i]>max)
        max = array[i];
        else if(array[i]<min)
        min = array[i];
    }
    Console.WriteLine($"максимум  {max}");
    Console.WriteLine($"минимум  {min}");
    Console.WriteLine($"[{string.Join(", ", array)}]");   
    Console.WriteLine(max-min);
}

Console.Clear();
Console.WriteLine("Введите количество элементов");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
ReleaseArray(array);
