void PrintArray(int[] array)
{
    System.Console.Write($"[{String.Join(",", array)}]\n");
}

int[] GenerateArr(int n)
{
    int[] arr = new int[n];

    for (int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(100,1000);
    }

    return arr;
}

int CountChetn(int[] array) {
    int count = 0;

    for (int i = 0; i < array.Length; i++) {
        if ((array[i] % 2) == 0)
       count++;
    }
    return count;
}

System.Console.WriteLine("Введите размерность массива:");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = GenerateArr(n);
PrintArray(array);
int count = CountChetn(array);
Console.WriteLine($"Количество четных элементов: {count}");

