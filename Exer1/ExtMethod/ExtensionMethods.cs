namespace Exer1.ExtMethod;

static class ExtensionMethods
{
    public static void ChangeColor<T>(this T item, params ConsoleColor[] color)
    {
        Console.BackgroundColor = color[0];
        Console.ForegroundColor = color[1];
    }
}