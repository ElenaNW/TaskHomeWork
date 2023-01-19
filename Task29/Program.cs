//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] array = CreateArray(8);
PrintArray(array);


int[] CreateArray(int size)
{
    int min = 0;
    int max = 100;
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write(arr[i] + ", ");
        }
        else Console.Write(arr[i]);
    }
    Console.Write(" -> ");
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

/*
void PrintArray(int[] arr)
{
  int count = arr.Length;
  int i = 0;
  Console.Write("[");
  while(i < count)
  {
    Console.Write(arr[i]);
    i++;
    if (i < count)
    {
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 
*/