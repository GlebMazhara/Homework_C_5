void InputArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    array[i] = new Random().Next(0, 10);
}

void ReleaseArray(int[] array) 
{
    int sum = 0;
   for(int i = 1; i<array.Length; i=i+2)
   sum=array[i]+sum;
   Console.Write($"Сумма всех нечётных элементов: {sum}");
 
}

Console.Clear();
Console.WriteLine("Введите количество элементов");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];   
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");  
ReleaseArray(array);
