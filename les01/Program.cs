// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Ввелите число 1  ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввелите число 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"большее - {number1}");
    Console.WriteLine($"меньшее - {number2}");

}
else
{
    Console.WriteLine($"большее - {number2}");
    Console.WriteLine($"меньшее - {number1}");
}
