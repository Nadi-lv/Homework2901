void PrintArray(double[] array)
{
    System.Console.Write($"[{String.Join(",", array)}]\n");
}


double [] FillArray(int n){
    double[] array = new double[n];
    Random rand = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = rand.Next(-10,10);
    }
    return array;
}
double minAndMax (double[] arr){
double min = arr[0];
double max = arr[0];
for (int i = 0; i < arr.Length - 1; i++){
    
    for (int j = i+1; j < arr.Length; j++){
        if (arr[j]<min) min = arr[j];
        if (arr[j]>max ) max = arr[j];
    }
}
double razn = max - min;
return razn; 
}

System.Console.WriteLine("Введите размерность массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(n);
PrintArray(array);
double x = minAndMax(array);
Console.WriteLine($"Разность максимального и минимального элементов = {x}");


