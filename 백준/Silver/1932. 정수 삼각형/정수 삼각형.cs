StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int result = 0;
int[][] board = new int[501][];
int[][] d = new int[501][];
for (int i = 0; i < 501; i++)
{
    board[i] = new int[501];
    d[i] = new int[501];
}
int T = int.Parse(sr.ReadLine());
for (int i = 1; i <= T; i++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    for (int j = 1; j <= i; j++)
        board[i][j] = input[j - 1];
}
d[1][1] = board[1][1];
for (int i = 2; i <= T; i++)
{
    for (int j = 1; j <= i; j++)
    {
        d[i][j] = Math.Max(d[i - 1][j - 1], d[i - 1][j]) + board[i][j];
    }
}
for (int i = 1; i <= T; i++)
{
    result = Math.Max(result, d[T][i]);
}
sw.WriteLine(result);
sw.Close();
sr.Close();