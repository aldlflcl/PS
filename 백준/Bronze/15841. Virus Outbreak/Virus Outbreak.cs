using System.Numerics;

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
BigInteger[] d = new BigInteger[491];
d[1] = 1;
d[2] = 1;
for (int i = 3; i <= 490; i++)
    d[i] = d[i - 1] + d[i - 2];
for (;;)
{
    int n = int.Parse(sr.ReadLine());
    if (n == -1)
        break;
    sw.WriteLine($"Hour {n}: {d[n]} cow(s) affected");
}
sw.Close();
sr.Close();