using System.Numerics;

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
int N = int.Parse(sr.ReadLine());
BigInteger[] d = new BigInteger[10_001];
d[0] = 0;
d[1] = 1;
for (int i = 2; i <= N; i++)
    d[i] = d[i - 1] + d[i - 2];
sw.WriteLine(d[N]);
sw.Close();
sr.Close();