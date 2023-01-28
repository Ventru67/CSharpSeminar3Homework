// Возведите число А в натуральную степень B используя цикл
int numberA = new Random().Next(1,11);
int numberB = new Random().Next(1,6);

static int Exponent(int numA, int numB)
{
  int result = 1;
  for(int ind = 0; ind < numB; ind++)
  {
    result = result * numA;
  }
  return result;
}
System.Console.WriteLine($"{numberA} ^ {numberB} -> {Exponent(numberA, numberB)}");
