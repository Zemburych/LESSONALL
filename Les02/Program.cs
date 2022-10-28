// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Ввелите число 1  ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввелите число 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввелите число 2 ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{   
    if (number1 > number3)
    {
        Console.WriteLine($"большее - {number1}");
    }
    else
    {
        Console.WriteLine($"большее - {number3}");
    }
}
else
{
    if (number2 > number3)
    {
        Console.WriteLine($"большее - {number2}");
    }
    else
    {
        Console.WriteLine($"большее - {number3}");
    }
}