// Написать программу масштабирования фигуры

void PrintCoord (int[] arrayX, int[]arrayY, int position)
{
    for(int i = 0; i < position; i++)
{
 Console.Write($"({arrayX[i]}, {arrayY[i]}) ");
}
Console.WriteLine();
}
Console.Write("Введите количество углов фигуры: ");
int count = int.Parse(Console.ReadLine() ?? "0");
int[] countFigureX = new int [count];
int[] countFigureY = new int [count];
for(int i = 0; i < count; i++)
{
    Console.WriteLine($"Введите {i+1}-ю точку: ");
    Console.Write("Х = ");
    countFigureX[i] = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Y = ");
    countFigureY[i] = int.Parse(Console.ReadLine() ?? "0");
    
}
Console.Write("Координаты вершин фигуры: ");
PrintCoord(countFigureX, countFigureY, count);

Console.Write("Введите коэфицент масштабирования: ");
int koeffMashtab = int.Parse(Console.ReadLine() ?? "0");

for(int i = 0; i < count; i++)
{
    countFigureX[i] = countFigureX[i] * koeffMashtab;
    countFigureY[i] = countFigureY[i] * koeffMashtab;
}
Console.Write("Координаты вершин фигуры в масштабе: ");
PrintCoord(countFigureX, countFigureY, count);