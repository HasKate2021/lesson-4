//двухмерные массивы

//пример 1
string[,] table = new string[2, 5];//масссив из 2 строк и 5 столбцов
// table[0,0]  table[0,1]  table[0,2]  table[0,3] table[0,4]
// table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]
table[1, 2] = "слово";//в строку 1 столбец 2 вводим данные

for (int rows = 0; rows < 2; rows++) //rows счетчик, кол*во строк<2
{
    for (int columns = 0; columns < 5; columns++)//внутренний счетчик и кол-во столбцов<5
    {
        Console.WriteLine($"--{table[rows, columns]}--");
    }
}

//пример2
int[,] matrix = new int[3, 4]; // массив с числами
for (int i = 0; i < 3; i++)//вмсето i<3 можно i<matrix.GetLength(0)
{
    for (int j = 0; j < matrix.GetLength(1); j++)//j<matrix.GetLength(1) вставляет кол-во столбцов (4)
    {
        Console.Write($"{matrix[i, j]} ");//через пробел
    }
    Console.WriteLine();//для красивого вывода чисел переход на новую строку 
}

// int[,,] arr = new int[3,4,5]; -трехмерный
// int[,,,,] brr = new int[3,4,5,7,8]; -пятимерный
