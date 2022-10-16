﻿// картинка с закрашенными и не закрашенными пикселями
// 0-закрашенный, 1-нет

int[,] pic = new int[,] //необязательно указывать строки и столбцы ес есть фиксированные данные:
{
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
    {0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0 },
    {0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0 },
    {0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0 },
    {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0 },
    {0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0 },
    {0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0 },
    {0,0,0,0,0,0,0,1,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0 },
    {0,0,0,0,0,1,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0 },
    {0,0,1,1,1,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,0 },
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0 },
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0 },
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0 },
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0 }, 
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0 },
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0 },
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0 },
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0 },
    {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0 },
    {0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0 },
    {0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0 },
    {0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0,0 },
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
};


//массив выведения картинки
void PrintImage(int[,] img) //  в аргументе прямоугольная таблица чисел
{
    for (int i = 0; i < img.GetLength(0); i++)
    {
        for (int j = 0; j < img.GetLength(1); j++)
        {
            if(img[i,j]==0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine(); //для красивого вывода чисел переход на новую строку 
    }
}

//массив закрашивания картинки
void FillImg(int row, int col ) // в аргументах позиции строки и пикселя с которого начинаем закраску
{
    if(pic [row,col]==0) //ес пиксель с позицией row не закрашен (=0) 
    {
        pic[row,col] = 1; //красим единицей (можн другим числом)
        // метод вызывает сам себя и устанавливает правила:
        FillImg (row-1,col); // вверх
        FillImg (row,col-1); // влево
        FillImg (row+1,col); // вниз
        FillImg (row,col+1); // вправо
    }
}

PrintImage(pic);
FillImg(13, 13); // начальная точка внутри изображения
PrintImage(pic);