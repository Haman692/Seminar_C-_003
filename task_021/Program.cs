// (X2 - X1)(X2 - X1) + (Y2 - Y1)(Y2 - Y1) Math.Sqrt
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


int DataEntryXY (string str)
{
    Console.Write(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


void PrintDistance (int x1, int x2, int y1, int y2)
{
    double distance = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
    Console.WriteLine("Растояние между точками" + distance);
}


int x1 =  DataEntryXY("Введите X1 = ");
int y1 =  DataEntryXY("Введите Y1 = ");
int x2 =  DataEntryXY("Введите X2 = ");
int y2 =  DataEntryXY("Введите Y2 = ");

PrintDistance(x1, x2, y1, y2);
