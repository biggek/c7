Console.Write("Введите кол-во строк массива:");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов  массива: ");
int col = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[row,col];

void mas(int row, int col)
    {
    int i,j;
    Random rand = new Random();
        for (i = 0; i < row; i++)
        {   
            Console.WriteLine();
            for (j = 0; j < col; j++)
                 {
                         randomArray[i,j] = rand.NextDouble();
                        Console.WriteLine($"{randomArray[i,j]:F2}");
                }
        }

    }
mas(row,col);