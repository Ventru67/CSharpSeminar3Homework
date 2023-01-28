// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Выводит кубы чисел от A до B, заканчивающихся на четную цифру. ");
Console.Write("Введите число A : ");
int userNumberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B : ");
int userNumberB = int.Parse(Console.ReadLine());
int count = userNumberA;
int cub = 0;
if (userNumberA >= 0 && userNumberB >= 0)
{
    while (userNumberA >= 0 && userNumberA <= userNumberB)
    {
        cub = userNumberA * userNumberA * userNumberA;
        if (cub % 10 % 2 == 0)
        {
            Console.WriteLine(cub);
        }
        userNumberA++;
    }
}
else
{
    Console.WriteLine("Числа 'A' и 'B' должны быть положительными ");
}
