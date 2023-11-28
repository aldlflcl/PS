StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
int[] d = new int[46];
int N = int.Parse(sr.ReadLine());
d[0] = 1;
d[1] = 1;
for (int i = 2; i < 46; i++)
    d[i] = d[i - 1] + d[i - 2];
for (int i = 0; i < N; i++)
{
    sw.WriteLine(d[int.Parse(sr.ReadLine())]);
}
sw.Close();
sr.Close();