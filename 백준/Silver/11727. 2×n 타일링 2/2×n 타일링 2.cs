StreamWriter sw = new(Console.OpenStandardOutput());
int[] d = new int[1004];
int mod = 10_007;
int N = int.Parse(Console.ReadLine());
d[1] = 1;
d[2] = 3;
for (int i = 3; i <= N; i++)
{
    d[i] = (d[i - 1] + d[i - 2] * 2) % mod;
}
sw.Write(d[N]);
sw.Close();