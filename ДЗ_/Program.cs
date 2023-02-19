// /Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите степень возведения: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int Deg (int numberA)
{
    int deg = numberA;
    for (int i = 2; i <= numberB; i++)
    {
        deg = deg*numberA; //
    }
    return deg;

}

System.Console.WriteLine($"число {numberA} в степени {numberB} = {Deg(numberA)}");//

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int Sum(int A)
// {
//     int sum = 0;
//     for (int i = 1; i <= A; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// int number = ReadInt("Введите число А: ");
// System.Console.WriteLine($"Сумма чисел от 1 до {number} = {Sum(number)}");

// number = ReadInt("Введите число В: ");
// System.Console.WriteLine($"Сумма чисел от 1 до {number} = {Sum(number)}");

// number = ReadInt("Введите число С: ");
// System.Console.WriteLine($"Сумма чисел от 1 до {number} = {Sum(number)}");
