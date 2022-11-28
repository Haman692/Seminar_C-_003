
Console.Clear();

int DataEntryXY (string str)
{
    Console.Write(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FindQvadnrant (int x, int y)
{
    if(x > 0 && y > 0) 
        Console.WriteLine("Это первый квадрант");
    if(x < 0 && y > 0) 
        Console.WriteLine("Это второй квадрант");
    if(x < 0 && y < 0) 
        Console.WriteLine("Это третий квадрант");
    if(x > 0 && y < 0) 
        Console.WriteLine("Это четвертый квадрант");
}



int x =  DataEntryXY("Введите кординаты X = ");
int y =  DataEntryXY("Введите кординаты Y = ");

FindQvadnrant(x,y);