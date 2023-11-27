StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
int N = int.Parse(sr.ReadLine());
int[] d = new int[N + 1];
int[] board = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
d[1] = board[0];
int result = d[1];
for (int i = 2; i <= N; i++)
{
    d[i] = Math.Max(d[i - 1] + board[i - 1], board[i - 1]);
    result = Math.Max(d[i], result);
}
sw.WriteLine(result);
sw.Close();
sr.Close();