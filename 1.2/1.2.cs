// теперь с методом заполняем таблицу рандомными числами

void PrintArray(int[,] matr) //  в аргументе прямоугольная таблица чисел
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine(); //для красивого вывода чисел переход на новую строку 
    }
}

// метод для заполнения матрицы рандомными числами
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);// полуинтервал [1;10)
        }

    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix); // убеждаемся в нулях
FillArray(matrix);  //заполняем
Console.WriteLine(); // для красивого разделения таблиц
PrintArray(matrix); //печатаем