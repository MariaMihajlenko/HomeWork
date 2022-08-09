Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());


if ((number % 2) == 0)
{
    Console.WriteLine("Четное");
    Console.WriteLine(number);

}
else
{
    Console.WriteLine("Нечетное");
    Console.WriteLine(number);

}