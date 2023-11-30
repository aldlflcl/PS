using System.Text;

StreamReader sr  = new(Console.OpenStandardInput());
StreamWriter sw  = new(Console.OpenStandardOutput());
StringBuilder sb = new();
int N = int.Parse(sr.ReadLine());
int[][] arr = new int[N][];
for (int i = 0; i < N; i++)
    arr[i] = new int[N * 2 - 1];

Func(N, 0, (N * 2 - 1) / 2);
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N * 2 - 1; j++)
    {
        if (arr[i][j] == 1)
            sb.Append('*');
        else 
            sb.Append(' ');
    }
    sb.AppendLine();
}
sw.Write(sb);
sw.Close();
sr.Close();

void Func(int n, int x, int y)
{
    if (n == 3)
    {
        Draw(x, y);
        return;
    }

    int third = n / 3;
    int half = n / 2;
    Func(half, x, y);
    Func(half, x + half, y - half);
    Func(half, x + half, y + half);
}

void Draw(int x, int y)
{
    arr[x][y] = 1;
    arr[x + 1][y - 1] = arr[x + 1][y + 1] = 1;
    for (int i = y - 2; i <= y + 2; i++)
        arr[x + 2][i] = 1;
}