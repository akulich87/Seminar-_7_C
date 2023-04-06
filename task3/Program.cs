// Задайте двумерный массив. Найдите элементы, у которых оба
 // индекса чётные и замените эти элементы на их квадраты

 // Изначально массив выглядел вот так:

 // 1 4 7 2
 // 5 9 2 3
 // 8 4 2 4

 // Новый массив будет выглядеть вот так:

 // 1 4 49 2
 // 5 9 2 3
 // 64 4 4 4

Console.WriteLine("Введите первое число:");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [rows,columns];

for (int i = 0; i < array.GetLength(0); i++) 
{
  for (int j = 0; j < array.GetLength(1); j++) 
  {
    array[i,j] = new Random().Next(10); 
    Console.Write(array[i,j]+" "); 
  }
  Console.WriteLine(); 
}

Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++) 
{
  for (int j = 0; j < array.GetLength(1); j++) 
  {
    if (( i % 2 == 0 ) && ( j % 2 == 0))
    {
      array[i,j] = array[i,j] * array[i,j]; // array[i,j] *= array[i,j]
    }
    Console.Write(array[i,j]+" "); 
  }
  Console.WriteLine(); 
}




