StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
int[] d = new int[100_003];
int N = int.Parse(sr.ReadLine());
int M = 100_000;
d[1] = M;
d[2] = 1;
d[3] = M;
d[4] = 2;
d[5] = 1;
for (int i = 6; i <= N; i++)
{
    int two = d[i - 2];
    int five = d[i - 5];
    d[i] = Math.Min(two, five) + 1;
}

if (d[N] >= M)
    sw.WriteLine(-1);
else
    sw.WriteLine(d[N]);
sw.Close();
sr.Close();