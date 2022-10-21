// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// функция заполнения массива из строки
int[] Mas(string arr)
{
    int size = 1;
    for (int i = 0; i < arr.Length; i++) 
    {
        if (arr[i] == ',') 
        {
            size++;
        }
    }

    int[] rez = new int[size]; 
    int j = 0; 

    for (int i = 0; i < arr.Length; i++) 
    {
        string t = "";

        while (arr[i] != ',') 
        {
            if (i != arr.Length - 1) 
            {
                t = t + arr[i].ToString(); 
                i++;
            }
            else
            {
                t = t + arr[i].ToString();  
                break;
            }
        }
        rez[j] = Convert.ToInt32(t);
        j++;
    }
    return rez;
}

//счетчик нулей 
int NullCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите число через запятую: ");
string? text = Console.ReadLine(); 

int[] Ch = Mas(text);
int nul = NullCount(Ch);
Console.WriteLine($"количество чисел больше нуля: {nul}");

