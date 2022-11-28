// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int DataQudrant(string str)
{
    Console.Write(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintXY (int nuber)
{
    if(nuber < 1 || nuber > 4) Console.WriteLine("Не подходящее число");
    else
    {        
        if(nuber == 1) Console.WriteLine("x > 0 и y > 0");
        if(nuber == 2) Console.WriteLine("x < 0 и y > 0");
        if(nuber == 3) Console.WriteLine("x < 0 и y < 0");
        if(nuber == 4) Console.WriteLine("x > 0 и y < 0");
    }
}

int Qudrant = DataQudrant("Напишите номер четверти ");

PrintXY(Qudrant);