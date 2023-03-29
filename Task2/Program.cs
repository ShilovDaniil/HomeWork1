int a;
int b;

System.Console.WriteLine("Enter a number: ");

if(int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b))
{
  if(a > b)
  {
    System.Console.WriteLine("max = " + a);
    System.Console.WriteLine("min = " + b);
  }
  else
  {
    System.Console.WriteLine("max = " + b);
    System.Console.WriteLine("min = " + a);
  }
}
else
{
  System.Console.WriteLine("Error!");
}