/// <summary>
/// Этот метод заполняет трехмерный массив
/// числами от min до max 
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">Количество строк</param>
/// <param name="depth">Глубина матрицы</param>
/// <param name="min">Минимальное число для рандома</param>
/// <param name="max">Максимальное число для рандома</param>
/// <returns></returns>
int[,,] GetMatrix(int rows, int cols, int depth, int min, int max) // параметры (4)
{
    int[,,] matrix = new int[rows, cols, depth];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int m = 0; m < depth; m++)
            {
                int number = new Random().Next(min, max + 1);
                while (ContainsNumber(matrix, number))
                {
                    number = new Random().Next(min, max + 1);
                }
                matrix[i, j, m] = number;
            }
        }
    }
    return matrix;
}

/// <summary>
/// Печатает трехмерную матрицу
/// </summary>
/// <param name="inputMatrix">Матрица для печати</param>
void PrintMatrix(int[,,] inputMatrix)
{
    for (int m = 0; m < inputMatrix.GetLength(2); m++)
    {

        for (int i = 0; i < inputMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < inputMatrix.GetLength(1); j++)
            {
                Console.Write($"{inputMatrix[i, j, m]}({i},{j},{m}) \t");
            }
            Console.WriteLine();
        }
    }
}

/// <summary>
/// Проверяет содержится ли в массиве передаваемый элемент
/// </summary>
/// <param name="matrix">Проверяемый массив</param>
/// <param name="number">Искомая цифра</param>
/// <returns></returns>
bool ContainsNumber(int[,,] matrix, int number)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int m = 0; m < matrix.GetLength(2); m++)
            {
                if (matrix[i, j, m] == number) return true;
            }
        }
    }
    return false;
}

int[,,] resultMatrix = GetMatrix(2, 2, 2, 1, 9);
PrintMatrix(resultMatrix);