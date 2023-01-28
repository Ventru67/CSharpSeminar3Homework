// Найти сумму чисел от 1 до А
Console.WriteLine("Найти сумму чисел от 1 до А ");
Console.Write("Введите число A : ");
int userNumber = int.Parse(Console.ReadLine());
int count = 1;
int sum = 0;
if(userNumber>0)
{
    while (count <= userNumber)
    {
    sum = (sum + count);
    count++;
    }
Console.WriteLine("Сумма чисел от 1 до " + userNumber + " = " + sum);
}
else
{
    Console.WriteLine("Введите число больше '0' ");
}
