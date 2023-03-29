System.Console.WriteLine("Enter a number: ");

int a = int.Parse(Console.ReadLine());
int b = 2;

while(b < a)
{
  System.Console.Write(b + " ");
  b = b + 2;
}
