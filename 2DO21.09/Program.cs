Console.WriteLine("x1 = ");
string input = Console.ReadLine();
if (int.TryParse(input, out int x1))
{
    Console.WriteLine("y1 = ");
    input = Console.ReadLine();
    if (int.TryParse(input, out int y1))
    {
        Console.WriteLine("x2 = ");
        input = Console.ReadLine();
        if (int.TryParse(input, out int x2))
        {
            Console.WriteLine("y2 = ");
            input = Console.ReadLine();
            if (int.TryParse(input, out int y2))
            {
                Console.WriteLine("Координаты первой точки: " + "(" + x1 + ";" + y1 + ")");
                Console.WriteLine("Координаты второй точки: " + "(" + x2 + ";" + y2 + ")");

                Double k = (y1 - y2) / (x1 - x2);

                Double b = y2 - k * x2;

                Console.WriteLine(k);
                Console.WriteLine(b);

                Console.WriteLine($"Уравнение прямой: y = {k}x + {b}");

            }
            else
            {
                Console.WriteLine("Вы ввели некорректное значение для y2");
            }
        }
        else
        {
            Console.WriteLine("Вы ввели некорректное значение для x2");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение для y1");
    }
}
else
{
    Console.WriteLine("Вы ввели некорректное значение для x1");
}