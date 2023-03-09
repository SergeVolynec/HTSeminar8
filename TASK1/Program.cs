/// <summary>
/// Этот метод заполняет двумерный массив
/// числами от min до max 
/// </summary>
/// <param name="rows">Количество строк </param>
/// <param name="cols">Количество столбцов </param>
/// <param name="min">Минимальное число для рандома</param>
/// <param name="max">Максимальное число для рандома</param>
/// <returns>Заполненный двумерный массив целых чисел</returns>
int[,] GetMatrix(int rows, int cols, int min, int max) // параметры (4)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
/// <summary>
/// Вывод матрицы в консоль
/// </summary>
/// <param name="inputMatrix">Матрица для печати</param>
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) 
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++) 
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Упорядочивает элементы в строках двоичной матрицы по убыванию
/// </summary>
/// <param name="matr">Матрица для сортировки</param>
void SortArray(int[,] matr)
{
    int rows = matr.GetLength(0);
    int cols = matr.GetLength(1);
    //вначале идем циклом по строкам
    for (int i = 0; i < rows; i++)
    {
        //упорядочивание по убыванию в строке
        int temp;
        for (int j = 0; j < cols - 1; j++)
        {
            for (int m = j + 1; m < cols; m++)
            {
                if (matr[i, j] < matr[i, m])
                {
                    temp = matr[i, j];
                    matr[i, j] = matr[i, m];
                    matr[i, m] = temp;
                }
            }
        }
    }
}

int [,] resultMatrix = GetMatrix(4, 4, 1, 9);
PrintMatrix (resultMatrix);
SortArray (resultMatrix);
Console.WriteLine ("Результирующая матрица, упорядоченная по убыванию:");
PrintMatrix (resultMatrix);