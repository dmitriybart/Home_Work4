// Написать программу масштабирования фигуры

void PrintCoord (double[] arrayX, double[]arrayY, int position)
{
    for(int i = 0; i < position; i++)
{
 Console.Write($"({arrayX[i]}, {arrayY[i]}) ");
}
Console.WriteLine();
}
Console.Write("Введите количество углов фигуры: ");
int count = int.Parse(Console.ReadLine() ?? "0");
double[] countFigureX = new double [count];
double[] countFigureY = new double [count];
for(int i = 0; i < count; i++)
{
    Console.WriteLine($"Введите {i+1}-ю точку: ");
    Console.Write("Х = ");
    countFigureX[i] = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Y = ");
    countFigureY[i] = double.Parse(Console.ReadLine() ?? "0");
    
}
Console.Write("Координаты вершин фигуры: ");
PrintCoord(countFigureX, countFigureY, count);

Console.Write("Введите коэфицент масштабирования: ");
double koeffMashtab = double.Parse(Console.ReadLine() ?? "0");

for(int i = 0; i < count; i++)
{
    countFigureX[i] = countFigureX[i] * koeffMashtab;
    countFigureY[i] = countFigureY[i] * koeffMashtab;
}
Console.Write("Координаты вершин фигуры в масштабе: ");
PrintCoord(countFigureX, countFigureY, count);