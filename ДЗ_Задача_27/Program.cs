// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string text)
{
     System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int Result(int A)
{
    int counter = Convert.ToString(A).Length;
    int sum = 0;
  
    for ( int i = 0; i < counter; i++)
    {
        sum = sum + A % 10;
        A = A / 10;
    }

    return sum;

}
int number = ReadInt("Введите число А: ");
System.Console.WriteLine($"Сумма цифр в числе {number} = { Result (number)}");

// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

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
