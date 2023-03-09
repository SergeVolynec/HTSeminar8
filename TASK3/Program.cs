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
/// Функция умножает 2 матрицы
/// </summary>
/// <param name="firstMatrix">Первая матрица</param>
/// <param name="secondMatrix">Вторая матрица</param>
/// <returns></returns>
int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int firstRows = firstMatrix.GetLength(0);
    int firstCols = firstMatrix.GetLength(1);
    int secondRows = secondMatrix.GetLength(0);
    int secondCols = secondMatrix.GetLength(1);
    int[,] resultMatrix = new int[firstRows, secondCols];
    for (int i = 0; i < firstRows; i++)
    {
        for (int j = 0; j < secondCols; j++)
        {
            int sum = 0;
            for (int m = 0; m < firstCols; m++)
            {
                sum += firstMatrix[i, m] * secondMatrix[m, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}

int[,] firstMatr = GetMatrix(3, 4, 1, 9);
PrintMatrix(firstMatr);
Console.WriteLine();

int[,] secondMatr = GetMatrix(4, 3, 1, 9);
PrintMatrix(secondMatr);
Console.WriteLine();

if (firstMatr.GetLength(0) != secondMatr.GetLength(1) || firstMatr.GetLength(1) != secondMatr.GetLength(0))
{
    Console.WriteLine("Данные матрицы нельзя перемножить");
}
else
{
    int[,] resultMatr = MultiplyMatrix(firstMatr, secondMatr);
    Console.WriteLine("Результат умножения 1-ой и 2-ой матриц:");
    PrintMatrix(resultMatr);
}