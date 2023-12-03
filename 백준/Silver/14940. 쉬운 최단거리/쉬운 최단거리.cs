using System.Text;

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
StringBuilder sb = new();
int[] dx = { 0, 0, 1, -1 };
int[] dy = { 1, -1, 0, 0 };
Queue<(int x, int y)> queue = new();
int[][] result = new int[1004][];
int[][] board = new int[1004][];
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int N = input[0];
int M = input[1];
for (int i = 0; i < N; i++)
{
    board[i] = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    result[i] = new int[M];
}
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        if (board[i][j] == 2)
        {
            queue.Enqueue((i, j));
            result[i][j] = 0;
            break;
        }
    }
}

while (queue.Count > 0)
{
    (int x, int y) = queue.Dequeue();
    for (int i = 0; i < 4; i++)
    {
        int nx = x + dx[i];
        int ny = y + dy[i];
        if (nx >= N || nx < 0 || ny >= M || ny < 0) continue;
        if (board[nx][ny] != 1 || result[nx][ny] != 0) continue;
        result[nx][ny] = result[x][y] + 1;
        queue.Enqueue((nx, ny));
    }
}
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        if (result[i][j] == 0 && board[i][j] == 1)
            sb.Append("-1 ");
        else
            sb.Append(result[i][j] + " ");
    }
    sb.AppendLine();
}
sw.Write(sb);
sw.Close();
sr.Close();