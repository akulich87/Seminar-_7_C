// Задайте двумерный массив размером m*n,
// заполненный случайными целыми числами

// m = 3, n = 4.

// 1 4 8 1 9
// 5 -2 33 -2
// 77 3 8 1

Console.WriteLine("Введите первое число:");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [rows,columns]; // [,] - показатель двумерного массива. На данном этапе, наш массив нулевой(заполнен нолями)

for (int i = 0; i < array.GetLength(0); i++) // если GetLength(0) - берем количество строчек, если GetLength(1) - количество столбцов
{
  for (int j = 0; j < array.GetLength(1); j++) // цикл заполнения столбцов
  {
    array[i,j] = new Random().Next(0,10); 
    Console.Write(array[i,j]+" "); // вывели массив; +" " - чтобы наши элементы отделялись друг от друга через пробел
  }
  Console.WriteLine(); // для перехода на новую строку
}

