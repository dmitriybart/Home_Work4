// Написать программу копирования массива

int [] FillArray(int size, int minimum, int maximum)
{
    int[] array = new int [size];
    int index = 0;
    var random = new Random();
    while (index < array.Length)
    {
        array[index] = random.Next(minimum, maximum+1);
        index++;
    }
    return array;
    }
void PrintArray(int[] collection)
{
    int position = 0;
    while (position < collection.Length)
{
    Console.Write(collection[position] +" ");
    position++;
}
Console.WriteLine();
}
int [] CopyArray(int [] array1, int[]array2)
{
    array1.CopyTo(array2, 0);
    return array2;
}

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальное значение: ");
int minimum = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите максимальное значение: ");
int maximum = int.Parse(Console.ReadLine()?? "0");
int [] array = FillArray(size, minimum, maximum);
PrintArray(array);

Console.Write("Создать копию этого массива? ДА или НЕТ? - ");
string answer = Console.ReadLine();
 
if (answer.ToLower() == "да")
{
    int[] array2 = new int [size];
    CopyArray(array, array2);
    PrintArray(array2);
}
else Console.Write("мы не сделали копию этого массива !");