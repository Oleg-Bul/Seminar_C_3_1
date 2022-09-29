// Напишите программу замена элементов: положительные 
// элементы замените на отрицательно и тд с положительными
int[] CreatorArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min,max);
    }
    return array;
}
int[] NumberArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]*=-1;
    }
    return array;
}
int[] array = CreatorArray(8,-10,11);
Console.WriteLine(String.Join(" ",array));
NumberArray(array);
Console.WriteLine(String.Join(" ",array));
