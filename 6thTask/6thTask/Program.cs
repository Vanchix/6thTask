using CircleArea;
using SquareArea;
using System.Net.Http.Headers;
using TriangleArea;
char c;
Console.WriteLine("Введите номер необходимой операции.\n" +
    "Введите 1 если хотите посчитать площадь окружности\n" +
    "Введите 2 если хотите посчитать площадь квадрата\n" +
    "Введите 3 если хотите посчитать площадь треугольника");
do
{
    Console.WriteLine("Если хотите увидеть список возможных операций введите 6. Иначе введите номер операции.");
    var input = Convert.ToInt32(Console.ReadLine());
    switch (input)
    {
        case (1):
            var circle = new Circle();
            Console.WriteLine("Введите радиус окружности");
            circle.CircleRadius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Площадь окружности равна {circle.AreaCalculating()}");
            break;
        case (2):
            var square = new Square();
            Console.WriteLine("Введите сторону квадрата");
            square.Side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Площадь квадрата равна {square.AreaCalculating()}");
            break;
        case (3):
            var triangle = new Triangle();
            Console.WriteLine("Введите сторону треугольника");
            triangle.Side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту опущенную на сторону треугольника");
            triangle.Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Площадь треугольника равна {triangle.AreaCalculating()}");
            break;
        case (4):
            Console.WriteLine("Введите 1 если хотите посчитать площадь окружности\n" +
    "Введите 2 если хотите посчитать площадь квадрата\n" +
    "Введите 3 если хотите посчитать площадь треугольника");
            break;
        default:
            Console.WriteLine("Ошибка!");
            break;
    }
    Console.WriteLine("Введите f если хотите закончить, если хотите продолжить действия с данным инвентарем нажмите другую клавишу");
    c = Convert.ToChar(Console.ReadLine());
} while (c != 'f');