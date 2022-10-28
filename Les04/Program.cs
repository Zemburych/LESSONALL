// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Ввелите число 1  ");
int number1 = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= number1)
{
    if (number1 % 2 == 0)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
    else
        {
            Console.WriteLine(i);
            i = i + 2;
        }
}