Console.WriteLine("Сделайте выбор task:");
bool isWork = true;
while (isWork)
{
	string command = Console.ReadLine()!;
	switch (command)
	{
		case "task54": Task54(); break;
		case "task56": Task56(); break;
		case "task58": Task58(); break;
        case "task60": Task60(); break;
		case "task62": Task62(); break;
		case "exit": isWork = false; break;
	}
}

int ReadLineInt(string p) // Ввод числа int
{
    Console.WriteLine($"Введите {p}");
    int n = int.Parse(Console.ReadLine()!);
    return n;
}
int [,] Made2ArrayInt(int length, int height) // Создание двумерного массива int
{
    int [,] array = new int [length,height];
    return array;
}
int [, ,] Made3ArrayInt(int first, int second, int therd) // Создание трехмерного массива int
{
    int [, ,] array = new int [first, second, therd];
    return array;
}

void FillDimensionInt(int [,] massiv) //Заполнение массива int
{  Random r = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
     for (int j = 0; j < massiv.GetLength(1); j++) 
        massiv[i, j ] = (r.Next(1,100));
    }
}

void CreateArray(int[,,] array, int minNumber, int maxNumber)//Заполнение трехмерного массива рандом int
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while (array[i, j, k] == 0)
                {
                    int number = random.Next(minNumber, maxNumber + 1);

                    if (FindNumberInArray(array, number) == false)
                    {
                        array[i, j, k] = number;
                    }
                }

            }
        }
    }
}

bool FindNumberInArray(int[,,] array, int number)//Проверка на повторение при заполнении
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number) return true;
            }
        }
    }

    return false;
}

void GetArray3AsStringInt(int[,,] array)//Вывод трехмерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k]);
                Console.Write("({0},{1},{2})\t", i, j, k);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

void GetArrayAsStringInt(int [,] massive)//Вывод трехмерного массива с индексами int
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for( int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i,j]} ");
        }
        Console.WriteLine();
    }
}
int [] MadeArrayInt(int length) // Создание одномерного массива массива int
{
    int [] array = new int [length];
    return array;
}

void GetArrayAsString(int [] massive)//Вывод массива int
{
    for (int i = 0; i < massive.Length; i++)
    {
        Console.Write($"{massive[i]} ");

    }
}



void Task54() //Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

{
    int [,] array = Made2ArrayInt(ReadLineInt("высоту массива"),ReadLineInt("длинну массива"));
    FillDimensionInt(array);
    GetArrayAsStringInt(array);
    SortArray(array);
    System.Console.WriteLine();
    GetArrayAsStringInt(array);
    
   void SortArray(int [,] array)
    {   
      for(int i = 0; i < array.GetLength(0); i++)
      {
        for(int j = 0; j < array.GetLength(1); j++)
        { 
            for(int n = 0; n < array.GetLength(1)-1; n++ )
            {
                if(array[i,n] < array[i,n+1])
                {
             int temp = array[i,n];
             array[i,n] = array[i,n+1];
             array[i,n+1] = temp;
                }
            }
        }
      } 
    }
}

void Task56() //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
{
  int [,] array = Made2ArrayInt(ReadLineInt("высоту массива"),ReadLineInt("длинну массива"));
    FillDimensionInt(array);
    GetArrayAsStringInt(array);
    Console.WriteLine();
    int [] massiv = SumStrArray(array);
    GetArrayAsString(massiv);
    Console.WriteLine();
    Console.WriteLine($"Строка с наименьшей суммой элементов {SearchIndexMin(massiv)+1}");

    int [] SumStrArray (int [,] array)//Поиск сумм строк элементов двумерного массива
    { 
      int [] sum = new int [array.GetLength(0)];
      for(int j = 0; j < array.GetLength(1); j++)
        {
           for(int i = 0; i < array.GetLength(0); i++)
           {
            sum[i] = sum[i] + array[i,j];
           }
        }
       return sum;
     }

     int SearchIndexMin (int [] massiv)// Выбор индекса массива с наименьшим числом
     { int str = 0;
       for(int i = 0; i < massiv.Length;  i ++)
       {
        if (massiv[i] < massiv[massiv.Length - i - 1])
        {   
            str = i;
        }
       }
        return str;
     }  
}

void Task58() //Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

{
    int [,] array1 = Made2ArrayInt(ReadLineInt("высоту первой матрицы"),ReadLineInt("длинну первой матрицы"));
    int [,] array2 = Made2ArrayInt(ReadLineInt("высоту второй матрицы"),ReadLineInt("длинну второй матрицы"));
    FillDimensionInt(array1);
    FillDimensionInt(array2);
    GetArrayAsStringInt(array1);
    Console.WriteLine();
    GetArrayAsStringInt(array2);
    Console.WriteLine();
   
    if (array1.GetLength(0) == array2.GetLength(1))
    { 
       int [,] result = Composition(array1,array2); 
       GetArrayAsStringInt(result);
    }
    
    else Console.WriteLine("Данные матрицы не соответствуют друг другу и не могут быть перемножены");
     

    
  int [,] Composition(int [,] array1, int [,] array2)
    {
        int [,] composition = Made2ArrayInt(array1.GetLength(1),array2.GetLength(0));
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for(int j = 0; j < array2.GetLength(1); j++)
            {
                composition[i,j] = array1[i,j]*array2[i,j];
            }
            
        }
        return composition;
    }
}

void Task60() //Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

{
   int [,,] array = Made3ArrayInt( 2, 2, 2);
   int minNum = 1;
   int maxNum = 10;
CreateArray(array, minNum, maxNum);
GetArray3AsStringInt(array);

}

void Task62() //Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

{
   
GetArrayAsStringInt(Spiral(4));

int[,] Spiral(int n)
 {
    int[,] result = new int[n,n];
    int temp = 1;
    int i = 0;
    int j = 0;
        while(temp <= result.GetLength(0) * result.GetLength(1))
        {
            result [i,j] = temp;
            temp++;
            if(i <= j + 1 && i + j < result.GetLength(1)-1)
            j++;
            else if(i < j && i + j >= result.GetLength(0)-1)
            i++;
            else if (i >= j && i + j > result.GetLength(1) - 1)
            j--;
            else
            i--;
        }

    return result;
 }

}