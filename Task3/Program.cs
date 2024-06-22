namespace Task3
{
    internal class Program
    {
        static int GetPerimeter(int sideLength)
        {
            return 4 * sideLength;
        }

        static int GetPerimeter(int length, int width)
        {
            return 2 * (length + width);
        }
        static void Main(string[] args)
        {
            int squarePerimeter = GetPerimeter(5);
            int rectanglePerimeter = GetPerimeter(3, 4);
            Console.WriteLine($"Периметр квадрата: {squarePerimeter}");
            Console.WriteLine($"Периметр прямоугольника: {rectanglePerimeter}");
        }
    }
}

