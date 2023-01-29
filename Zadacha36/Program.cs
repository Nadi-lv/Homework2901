
void PrintArray(int[] array)
{
    System.Console.Write($"[{String.Join(",", array)}]\n");
}

int[] GenerateArr(int n)
{
    int[] arr = new int[n];

    for (int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(1,10);
    }

    return arr;
}

int SumNaNechetn(int[] array) {
    int sum = 0;

    for (int i = 0; i < array.Length; i++) {
        if ((i % 2) != 0)
       sum = sum + array[i];
    }
    return sum;
}

System.Console.WriteLine("Введите размерность массива:");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = GenerateArr(n);
PrintArray(array);
int summa = SumNaNechetn(array);
Console.WriteLine($"Сумма элементов на нечетных позициях: {summa}");