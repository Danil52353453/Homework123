//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Введите количество столбцов : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк : ");
int m = Convert.ToInt32(Console.ReadLine());
int [,]array=new int [n, m];
int []sum=new int [m];

for (int i=0; i<n; i++)
{
    for(int j=0; j<m; j++)
    {
        array [i, j] = Convert.ToInt32(new Random().Next(0,10));  
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i=0; i<n; i++)
{
    for(int j=0; j<m; j++)
    {
        sum[i] += array[j, i];
    }
}

for (int i=0; i<m; i++)
{
    Console.Write((sum[i] / n)  + " ");
}
Console.ReadLine();

//Подскажите где ошибка не могу чтобы выводилось дробью, когда пытаюсь сделать через dooble он выдает ошибку ,
//Где мне исправить код ? С