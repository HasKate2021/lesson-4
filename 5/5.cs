// Напишите программу, которая перевернёт одномерный массив (последний элемент 
// будет на первом месте, а первый - на последнем и т.д.)
Console.Clear();

int[] GetArray(int size, int min, int max) //метод рандомных чисел
{
    int[] res = new int[size];
    for (int i = 0; i<size; i++)
    {
        res[i] = new Random().Next(min,max+1);
    }
    return res;
}


void ReversArray1(int[] inArray) //метод 1 
{
for (int i = 0; i < inArray.Length / 2; i++) // делим на 2 чтоб доходить только до середины массива при обмене чисел
{
int temp = inArray[i];
inArray[i] = inArray[inArray.Length - 1 - i]; // меняем 1 на последний элемент и тд
inArray[inArray.Length - 1 - i] = temp; // меняем последний на 1 из временной переменной temp
}
}

int[] ReverseArray2(int[] inArray) // метод 2 с каждым элементом, памяти требует больше
{
int[] result = new int[inArray.Length];

for (int i =0; i < inArray.Length; i++)
{
result[i] = inArray[inArray.Length-1-i];
}
return result;
}

int[] array = GetArray(10,0,10);
Console.WriteLine(String.Join(" ", array));

ReversArray1(array);
Console.Write(String.Join(" ", array));

Console.WriteLine(); //для красивого вывода чисел переход на новую строку 

int [] newArray = ReverseArray2( array); //вызываем метод 2 с результатом метода 1
Console.Write(String.Join(" ", newArray));