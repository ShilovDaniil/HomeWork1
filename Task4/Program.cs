int a;
int b;
int c;

System.Console.WriteLine("Enter a three numbers: ");

if(int.TryParse(Console.ReadLine(), out a) &&
   int.TryParse(Console.ReadLine(), out b) &&
   int.TryParse(Console.ReadLine(), out c))
{
  if(a > b &&  a > c)
  {
    System.Console.WriteLine("max = " + a);
  }
  else if(b > a && b > c)
  {
    System.Console.WriteLine("max = " + b);
  }
  else if(c > a && c > b)
  {
    System.Console.WriteLine("max = " + c);
  }
}
else
{
  System.Console.WriteLine("Error!");
}  