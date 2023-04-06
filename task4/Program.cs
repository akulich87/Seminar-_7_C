// Задайте двумерный массив. Найдите сумму элементов, находящихся 
// на главной диагонали(с индексами (0,0); (1,1) и т.д.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Сумма элементов главной диагонали: 1 + 9 + 2 = 12

// Console.WriteLine("Введите первое число:");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число:");
// int columns = Convert.ToInt32(Console.ReadLine());

// int sum = 0;

// int[,] array = new int [rows,columns];

// for (int i = 0; i < array.GetLength(0); i++) 
// {
//   for (int j = 0; j < array.GetLength(1); j++) 
//   {
//     array[i,j] = new Random().Next(10);
//     if( i == j )
//     {
//       sum = sum + array[i,j]; // sum += array[i,j]
//     }
//     Console.Write(array[i,j]+" "); 
//   }
//   Console.WriteLine(); 
// }

// Console.WriteLine("Сумма элементов главной диагонали: " +sum);



// Решение с полным ответом - Сумма элементов главной диагонали: 1 + 9 + 2 = 12

Console.WriteLine("Введите первое число:");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int columns = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int arrayLength = 0; // размер нашего одномерного массива

int[,] array = new int [rows,columns];

if (rows >= columns) // мы определяем какая из наших размерностей меньше, и это будет размер нашего массива
{
  arrayLength = columns;
}
else
{
  arrayLength = rows;
}

int[] array2 = new int[arrayLength]; // размер второго одномерного  массива

for (int i = 0; i < array.GetLength(0); i++) 
{
  for (int j = 0; j < array.GetLength(1); j++) 
  {
    array[i,j] = new Random().Next(10);
    if ( i == j )  // если элемент находится на главной диагонали
    {
      sum = sum + array[i,j]; // sum += array[i,j]
      array2[j] = array[i,j]; // записываем элементы диагонали в новый массив
    }
    Console.Write(array[i,j]+" "); 
  }
  Console.WriteLine(); 
}

Console.WriteLine("Сумма элементов главной диагонали: ");

for (int i = 0; i < array2.Length; i++)
{
  Console.Write(array2[i] + "+"); // выводим подряд все элементы одномерного массива и указываем знак +
}

Console.WriteLine("=" +sum);

