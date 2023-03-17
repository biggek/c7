Console.Write("Введите кол-во столбцов массива:");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во строк  массива: ");
int row = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[col,col];

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
        }

    }
mas(col,row);