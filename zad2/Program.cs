Console.WriteLine("Введите кол-во столбцов массива:");
int col = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кол-во строк массива:");
int row = int.Parse(Console.ReadLine());
double[,] randomArray = new double[col,row];

Console.WriteLine("Введите позицию столбца:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите позицию строки: ");
int n = int.Parse(Console.ReadLine());

void mas(int col, int row)
    {
        int i,j;
        Random rand = new Random();
        for (i = 0; i < col; i++)
            {
                Console.WriteLine();
                for (j = 0; j < row; j++)
                {
                    randomArray[i,j] = rand.NextDouble();
                    Console.WriteLine($"{randomArray[i,j]:F2}");
                }
                     Console.WriteLine();
            }   
    }
mas(col,row);
if (m<1 || n<1)
Console.WriteLine("Позиции строк не могут быть отрицательными");
else if (m <= col+1 && n <= row+1)
Console.WriteLine($"Значение элемента равно {randomArray[m-1,n-1]:F2}");
else Console.WriteLine("Такого элемента нет в массиве");