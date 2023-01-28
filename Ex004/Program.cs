// Подсчитать сумму цифр в числе
static int DigitSum(int num)
{
  int sum = 0;
  for (int n = num; num > 0; num /= 10)
  {
    sum = num % 10 + sum;
  }
  return sum;
}
int number = new Random().Next(100, 10000);
Console.WriteLine($"{number} -> {DigitSum(number)}");