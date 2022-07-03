// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
namespace Task19;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число: ");
        string number = Console.ReadLine()!;
        char [] numarray = number.ToCharArray();
        // создаем массив и заполняем его цифрами числа в обратном порядке
        char [] numarray2 = new char [numarray.Length];
        int length = number.Length-1;
        for (int i=0; i<number.Length; i++)
        {
            numarray2[length] = numarray[i];
            length = length -1;
        }
        // переводим элементы массива с перевернутым цислом в строку, чтобы можно было сравнить ее с исходной строкой (числом)
        string number2 = string.Empty;
        for (int j=0; j<numarray2.Length; j++)
        {
            number2 = number2 + numarray2[j];
        }
        // сравниваем исходную строку с перевернутой строкой, если они равны, значит число палиндром
        if (number == number2)
        {
            Console.WriteLine($"Число {number} палиндром");
        }
        else
            Console.WriteLine($"Число {number} не является палиндромом");
    }
    
}