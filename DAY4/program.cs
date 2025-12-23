/*
 * // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int n, count;
n = 15;
count = 1;
while (count <= 20)
{
    Console.WriteLine($"{n}");
    n = n + 3;
    count = count + 1;
}
*/
/*
 Console.WriteLine("Enter a positive number:");
int num = int.Parse(Console.ReadLine());
int divisor = 2;
int maxDivisor = (int)Math.Sqrt(num);
bool Prime = true;
while (Prime && divider <= maxDivisor)
{
    if (num % divisor == 0)
    {
        Prime = false;
      
    }
    divisor++;
}
Console.WriteLine("prime? " + Prime);
*/
/*
Console.WriteLine($"{int15-(15/2)}");
*/
/*
int n;
n = Convert.ToInt32(Console.ReadLine());
int n_number;
n_number = (int)(n/ 2);
int count = 1;
for (int i = 2; i <= n_number;i = i+1)
{
    if (n%i!=0)
    {
        count = count + 1;
    }
}
if (count == n_number)
{
    Console.WriteLine($"{n} is a prime number");
    }
else
    {
    Console.WriteLine($"{n} is not a prime number");
}
*/
/*
int n;
n = Convert.ToInt32(Console.ReadLine());
int n_count = 1;
int number = 2;
int n_number;
while (n_count <= n)
{
    n_number = (int)(number / 2);
    int count = 1;
    for (int i=2;i<=n_number;i=i+1)
    {
        if (number % i != 0)
        {
            count = count + 1;
        }
    }
    if (count == n_number)
    {
        Console.Write($"{number} ");
        n_count = n_count + 1;
    }
    number = number + 1;
}
*/
/*
// Fibonacci sequence to n numbers
ulong n = Convert.ToUInt64(Console.ReadLine());
ulong a , b, c,i;
a = 0;
b = 1;
Console.Write($"{a},{b}, ");
i = 3;
while (i<=n)
{
    c = a + b;
    Console.Write($"{c}, ");
    a = b;
    b = c;
    i = i + 1;
}
*/
// factor
int n = Convert.ToInt32(Console.ReadLine());
int div = 2;
string res = $"{n} = 1";
while (n!=1)
{
    if (n % div == 0)
    {
        n = n / div;
        res = res + $"x{div}";
    }
    else
    {
        div = div + 1;
    }
}
Console.WriteLine(res);
