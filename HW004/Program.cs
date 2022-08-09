Console.WriteLine("Введите любое число ");
int N = Convert.ToInt32(Console.ReadLine());
int a =1;

while(a<=N)
{
if ((a % 2) == 0)

{
    Console.WriteLine("Четные числа ряда до N");
    Console.WriteLine(a);

}
a++;
}