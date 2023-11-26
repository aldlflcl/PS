int[] dx = { 0, 1, 0, -1 };
int[] dy = { 1, 0, -1, 0 };
int[][] board = new int[10][];
int[][] board2 = new int[10][];
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
List<(int x, int y)> cameras = new();
int min = 0;
int[] order = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
for (int i = 0; i < order[0]; i++)
{
    board[i] = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    board2[i] = new int[order[1]];
    for (int j = 0; j < order[1]; j++)
    {
        if (board[i][j] != 0 && board[i][j] != 6)
            cameras.Add((i, j));
        if (board[i][j] == 0)
            min++;
    }
}

for (int tmp = 0; tmp < (1 << (2 * cameras.Count)); tmp++)
{
    for (int i = 0; i < order[0]; i++)
    {
        for (int j = 0; j < order[1]; j++)
            board2[i][j] = board[i][j];
    }

    int brute = tmp;
    for (int i = 0; i < cameras.Count; i++)
    {
        int dir = brute % 4;
        brute /= 4;
        (int x, int y) = cameras[i];
        if (board[x][y] == 1)
            Upd(x, y, dir);
        else if (board[x][y] == 2)
        {
            Upd(x, y, dir);
            Upd(x, y, dir + 2);
        }
        else if (board[x][y] == 3)
        {
            Upd(x, y, dir);
            Upd(x, y, dir + 1);
        }
        else if (board[x][y] == 4)
        {
            Upd(x, y, dir);
            Upd(x, y, dir + 1);
            Upd(x, y, dir + 2);
        }
        else if (board[x][y] == 5)
        {
            Upd(x, y, dir);
            Upd(x, y, dir + 1);
            Upd(x, y, dir + 2);
            Upd(x, y, dir + 3);
        }
    }

    int result = 0;
    for (int i = 0; i < order[0]; i++)
    {
        for (int j = 0; j < order[1]; j++)
            if (board2[i][j] == 0)
                result++;
    }

    if (result < min)
        min = result;
}
sw.WriteLine(min);
sw.Close();
sr.Close();

void Upd(int x, int y, int dir)
{
    dir %= 4;
    for (;;)
    {
        x += dx[dir];
        y += dy[dir];
        if (OOB(x, y) || board2[x][y] == 6) return;
        if (board2[x][y] != 0) continue;
        board2[x][y] = 7;
    }
}

bool OOB(int x, int y)
{
    return (x < 0 || x >= order[0] || y < 0 || y >= order[1]);
}