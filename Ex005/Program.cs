// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Выводит произведения чисел от 1 до N. ");
Console.Write("Введите число N : ");
int userNumber = int.Parse(Console.ReadLine());
int count = 1;
int pro = 1;

while (count <= userNumber)
{
    pro = pro * count;
    count++;
}
Console.WriteLine("произведения чисел от 1 до " + userNumber + " = " + pro );
