Console.Write("Введите кол-во строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов  массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m,n];

void mas(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{   
    Console.WriteLine();
    for (j = 0; j < n; j++)
{
    randomArray[i,j] = rand.NextDouble();
    Console.WriteLine($"{randomArray[i,j]:F2}");
}

}

}

mas(m,n);