/// <summary>
/// Этот метод заполняет двумерный массив
/// числами от min до max (общее описание)
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">Количество столбцов</param>
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
/// Проверяет, является ли матрица прямоугольной
/// </summary>
/// <param name="matrix">Матрица для проверки</param>
/// <returns></returns>
bool IsRectangle(int[,] matrix)
{
    if (matrix.GetLength(0) != matrix.GetLength(1)) return true;
    else
    {
        Console.WriteLine("Матрица не является прямоугольной");
        return false;
    }
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
/// Ищет строку с минимальной суммой элементов
/// </summary>
/// <param name="matr">Матрица, в которой ищется строка с минимальной суммой элементов</param>
void FindMinRow(int[,] matr)
{
    int rows = matr.GetLength(0);
    int cols = matr.GetLength(1);
    int minSumInRow = int.MaxValue;
    int minRow = 0;
    //Обходим все строки
    for (int i = 0; i < rows; i++)
    {
        //Суммируем элементы в строке
        int sumInRow = 0;
        for (int j = 0; j < cols; j++)
        {
            sumInRow += matr[i, j];
        }
        //Если сумма меньше, фиксируем минимальную строку
        if (sumInRow < minSumInRow)
        {
            minSumInRow = sumInRow;
            minRow = i + 1;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов {minSumInRow} в строке {minRow}");
}


int[,] resultMatrix = GetMatrix(5, 4, 1, 9);
if (IsRectangle(resultMatrix))
{
    PrintMatrix(resultMatrix);
    FindMinRow(resultMatrix);
}