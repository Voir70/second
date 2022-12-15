/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7
*/
(int, int) Min(int[,] array)
            {
                int min = array[0, 0];
                int minrow = 0;
                int minColumn = 0;
                for(int i = 0; i < array.GetLength(0); i++)
                {
                    for(int j = 0; j < array.GetLength(1); j++)
                    {
                        if(array[i,j] < min)
                        {
                            min = array[i, j];
                            minrow = i;
                            minColumn = j;
                        }
                    }
                }
                return (minrow, minColumn);
            }
int[,] Delete (int[,] array, int minRow, int minColumn)
            {
                int countI = 0;
                int countJ = 0;
                int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (i != minRow && j != minColumn)
                        {
                            result[countI, countJ] = array[i, j];
                            
                            countJ++;
                        }
                    }
                    countJ = 0;
                    if (i != minRow)
                    {
                        countI++;
                    }
                }
                return result;
            }
