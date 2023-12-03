StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
int mod = 10_007;
int[] d = new int[1001];
int N = int.Parse(sr.ReadLine());
d[1] = 1;
d[2] = 2;
for (int i = 3; i <= N; i++)
{
   d[i] = (d[i - 1] + d[i - 2]) % mod;
}
sw.WriteLine(d[N]);
sw.Close();
sr.Close();