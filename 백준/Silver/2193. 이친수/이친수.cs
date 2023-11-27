StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
long[] d = new long[91];
int N = int.Parse(sr.ReadLine());
d[1] = 1;
d[2] = 1;
for (int i = 3; i <= N; i++)
    d[i] = d[i - 1] + d[i - 2];
sw.WriteLine(d[N]);
sw.Close();
sr.Close();