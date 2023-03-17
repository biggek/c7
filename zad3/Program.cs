Console.WriteLine("Введите кол-во строк массива:");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов массива:");
int col = int.Parse(Console.ReadLine());
int[,] randomArray = new int[row,col];

void mas(int row, int col)
{
int i,j;
Random rand = new Random();
for (i = 0; i < row; i++)
{
Console.WriteLine();
for (j = 0; j < col; j++)
{
randomArray[i,j] = rand.Next(1,9);
Console.WriteLine($"{randomArray[i,j]} ");
}
Console.WriteLine();
}
}

void arif(int row, int col)
{
Console.WriteLine("Среднее арифметическое каждого столбца:");
int i,j;
Random rand = new Random();
for (j = 0; j < col; j++)
{
double sum = 0;
for (i = 0; i < row; i++)
{
sum = sum + randomArray[i,j];
}
Console.WriteLine($"{sum/(i):F1};");
}
}
mas(row,col);
arif(row,col);