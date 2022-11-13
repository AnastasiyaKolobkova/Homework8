// Домашняя работа 7.
// Зачада 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void ArrangeTheArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int count = 0; count < array.GetLength(1) - 1; count++)
      {
        if (array[i, count] < array[i, count + 1])
        {
          int temp = array[i, count + 1];
          array[i, count + 1] = array[i, count];
          array[i, count] = temp;
        }
      }
    }
  }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine($"Ordered array: ");
ArrangeTheArray(myArray);
Show2dArray(myArray);

// Задача 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int SumLine(int[,] array)
{
    int lineAmount = SumOfLineElements(array, 0);
    int minLineAmount = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumLine = SumOfLineElements(array, i);
        if (lineAmount > sumLine)
        {
            lineAmount = sumLine;
            minLineAmount = i;
        }
    }
    return minLineAmount;
}

int SumOfLineElements(int[,] array, int i)
{
  int lineAmount = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    lineAmount += array[i,j];
  }
  return lineAmount;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int minLineAmount = SumLine(myArray);
Console.WriteLine($"{minLineAmount + 1} - the row with the smallest sum of elements");

// Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int[,] ProductOfMatrices(int[,] firstMatrix, int[,] secondMatrix)
{
  int firstMatrixRows = firstMatrix.GetLength(0);
  int firstMatrixColumns = firstMatrix.GetLength(1);
  int secondMatrixRows = secondMatrix.GetLength(0);
  int secondMatrixColumns = secondMatrix.GetLength(1);
  int[,] resultMatrix = new int[firstMatrixRows, secondMatrixColumns];
  if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
    for (int matrix1Rows = 0; matrix1Rows < firstMatrixRows; matrix1Rows++)
      for (int matrix2Columns = 0; matrix2Columns < secondMatrixColumns; matrix2Columns++)
        for (int matrix1Columns = 0; matrix1Columns < firstMatrixColumns; matrix1Columns++)
            resultMatrix[matrix1Rows, matrix2Columns] += firstMatrix[matrix1Rows, matrix1Columns] * secondMatrix[matrix1Columns, matrix2Columns];
  return resultMatrix;
}

int[,] arrayFirst = CreateRandom2dArray();
Show2dArray(arrayFirst);
Console.WriteLine();
int[,] arraySecond = CreateRandom2dArray();
Show2dArray(arraySecond);
Console.WriteLine();
int[,] MatrixMultiply = ProductOfMatrices(arrayFirst, arraySecond);
Show2dArray(MatrixMultiply);

// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateRandom3dArray(int rows, int columns, int planes)
{
  int[,,] array3d = new int[rows, columns, planes];
  int[] NonRepeatingArray = new int[rows * columns * planes];
  if (rows * columns * planes < 100)
    for (int x = 0; x < array3d.GetLength(0); x++)
      for (int y = 0; y < array3d.GetLength(1); y++)
        for (int z = 0; z < array3d.GetLength(2); z++)
        {
          int randomNum = 0;
          for (int k = 0; k < NonRepeatingArray.Length; k++)
          {
            randomNum = new Random().Next(10, 100);
            if (randomNum == NonRepeatingArray[k])
              continue;
            NonRepeatingArray[x + y + z] = randomNum;
          }
          array3d[x, y, z] = randomNum;
        }
  else
    Console.WriteLine("You cannot create such an array!");
  return array3d;
}

void Show3dArray(int[,,] array3d)
{
    for (int x = 0; x < array3d.GetLength(0); x++)
    {
        for (int y = 0; y < array3d.GetLength(1); y++)
        {
            for (int z = 0; z < array3d.GetLength(2); z++)
            {
                Console.Write($" {array3d[x, y, z]} ({x},{y},{z}) ");
            }
        }
    Console.WriteLine(" ");
    }
}

int[,,] array3d = CreateRandom3dArray(2, 2, 2);
Show3dArray(array3d);

// Задача . Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] SpiralArray()
{
    int n = 4;
    int[,] spiralArray = new int[n,n];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
    {
        spiralArray[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1)
        {
            j++;
        }
        else
        {
            if (i < j && i + j >= spiralArray.GetLength(0) - 1)
            {
                i++;
            }
            else
            {
                if (i >= j && i + j > spiralArray.GetLength(1) - 1)
                {
                    j--;
                }
                else
                {
                    i--;
                }
            }
        }
    }
    return spiralArray;
}

void Show2dArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

int[,] array = SpiralArray();
Show2dArray(array);