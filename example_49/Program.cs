/* Задача 46: Задайте двумерный массив. Найдите элементы,
у которых оба индекса четные, и замените эти элемиенты
на их квадраты.

1 4 7 2   1  4 49 2
5 9 2 3   5  9  2 3
8 4 2 4   64 4  4 4
*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) {
    //                       0        1
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) {
        Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

void ReplaceEvenIndexElenSquare(int[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i += 2) {
        for (int j = 0; j < matrix.GetLength(1); j += 2) {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine("");
ReplaceEvenIndexElenSquare(array2d);
PrintMatrix(array2d);