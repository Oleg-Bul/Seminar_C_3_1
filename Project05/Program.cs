//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения 
//которых лежат в отрезке [10,99].
int ReadData(string msg)
{
    System.Console.Write(msg);
    int number = int.Parse(System.Console.ReadLine() ?? "0");
    return number;
}

int[] CreateArr(int arrLen, int arrLowBord, int arrHighBord)
{
    int[] array = new int[arrLen];
    for (int i = 0; i < arrLen; i++)
    {
        array[i] = new System.Random().Next(arrLowBord, arrHighBord + 1);
    }
    return array;
}
int arrLen = ReadData("Введите длину массива: ");
int arrLowBord = ReadData("Введите нижний предел массива ");
int arrHighBord = ReadData("Введите верхний предел массива ");
int[] arr = CreateArr(arrLen, arrLowBord, arrHighBord);
void SearchDigits(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>9 && arr[i]<100) Console.Write(arr[i] + " ");
    }
    Console.WriteLine(" данные числа лежат в отрезке[10,99]");
} 
SearchDigits(arr);