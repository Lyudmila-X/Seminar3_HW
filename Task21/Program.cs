// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
namespace task21;
class Program
{
    // Метод, который возвращает квадрат разницы двух чисел
    static int diffSquared (string first, string second)
    {
        // сначала конвертируем строку в число
        int acoord = Convert.ToInt32(first);
        int bcoord = Convert.ToInt32(second);
        int result = (acoord-bcoord)*(acoord-bcoord);
        return result;
    }
    static void Main()
    {
        Console.Write("Введите через пробел координаты точки А (x, y, z): ");
        // разбиваем строку на элементы используя пробел как разделитель, записываем каждую координату как элемент массива
        string [] arrayA= Console.ReadLine().Split();
        Console.WriteLine();
        Console.Write("Введите через пробел координаты точки B (x, y, z): ");
        string [] arrayB = Console.ReadLine().Split();
        // находим сумму квадратов разностей координат используя метод diffSquared, в качестве аргументов передаем текущий (i) элемент массива
        double sum = 0;
        for (int i=0; i<arrayA.Length; i++)
        {
            sum = sum + diffSquared(arrayA[i], arrayB[i]);
        }
        // находим корень квадратный из полученной суммы квадратов разностей координат
        double distance = Math.Round(Math.Sqrt(sum), 2);
        Console.WriteLine(distance);
    }
}