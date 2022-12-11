/*Задача 39:Напишите программу которая перевернет ондномерный массив.
(последний элемент будет на первом месте,а первый на последнем и т.д.)
[1 2 3 4 5]->[5 4 3 2 1]
[6 7 3 6]->[6 3 7 6]
*/

/*
 1.Метод, который будет выдавать заполненный массив случайными числами
 2.Метод, который будет печатать массив
 3.Метод, который будет переворачивать массив
 4.Получение числа с консоли, для того ,чтобы задать размерность массива
*/

//Метод, который будет выдавать заполненный массив случайными числами
int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next[1, 9];
    }
    return array;
}
//Метод, который будет печатать массив
void PrintArray(int[] array);
{
    for (int i = 0; i < array.Length; i++)
    {
      Console.Write($"{array[i]} ");  
    }
    Console.WriteLine();
}

//Получение числа с консоли, для того ,чтобы задать размерность массива
int CetNumberFromConsole(string message)
{
  bool isCorrect = false;
  int result = 0;

  while (!isCorrect)
  {
    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out result))
    {
        isCorrect = true;
    }
    else
    {
     Console.WriteLine("Ввели не число.Введите число");   
    }
  }
   return result; 
}

//Метод, который будет переворачивать массив
int[]ReverseArray(int[]array)
{
    int[]result = new int[array.Length];
    int count = 0;

    for (int i - array.Length -1; i >= 0; i--)
    {
      result[count] = array[1];
      count++;
    }
    
     return result;   
}

int dimension = GetNumberFromConsole("Введите размерность массива");
int[] startArray = InitArray(dimension);
PrintArray(startArray);
int[] resultArray = ReverseArray(startArray);
PrintArray(resultArray);