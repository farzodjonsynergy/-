{
    Console.WriteLine("Введите название фигуры (ромб, прямоугольник, прямоугольный треугольник, равносторонний треугольник):");
    string figure = Console.ReadLine()?.ToLower();

    switch (figure)
    {
        case "прямоугольник":
            DrawRectangle();
            break;
        case "ромб":
            DrawRhombus();
            break;
        case "прямоугольный треугольник":
            DrawRightTriangle();
            break;
        case "равносторонний треугольник":
            DrawEquilateralTriangle();
            break;
        default:
            Console.WriteLine("Неизвестная фигура.");
            break;
    }
}

    static void DrawRectangle()
    {
        int width = 10, height = 5;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void DrawRightTriangle()
    {
        int height = 5;
        for (int i = 1; i <= height; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void DrawEquilateralTriangle()
    {
        int height = 5;
        for (int i = 1; i <= height; i++)
        {
            Console.Write(new string(' ', height - i));
            Console.WriteLine(new string('*', i * 2 - 1));
        }
    }

    static void DrawRhombus()
    {
        int height = 5;
        // Верхняя часть ромба
        for (int i = 1; i <= height; i++)
        {
            Console.Write(new string(' ', height - i));
            Console.WriteLine(new string('*', i * 2 - 1));
        }
        // Нижняя часть ромба
        for (int i = height - 1; i > 0; i--)
        {
            Console.Write(new string(' ', height - i));
            Console.WriteLine(new string('*', i * 2 - 1));
        }
    }