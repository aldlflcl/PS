StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
bool[] isInfected = new bool[101];
Queue<int> queue = new();
bool[][] dir = new bool[101][];
for (int i = 0; i < 101; i++)
    dir[i] = new bool[101];
int com = int.Parse(sr.ReadLine());
int N = int.Parse(sr.ReadLine());
for (int i = 0; i < N; i++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    dir[input[0]][input[1]] = true;
    dir[input[1]][input[0]] = true;
}

isInfected[1] = true;
queue.Enqueue(1);
while (queue.Count > 0)
{
    int cur = queue.Dequeue();
    for (int i = 1; i <= com; i++)
    {
        if (dir[cur][i] && !isInfected[i])
        {
            isInfected[i] = true;
            queue.Enqueue(i);
        }
    }
}

int result = 0;
for (int i = 2; i <= com; i++)
    if (isInfected[i])
        result++;
sw.WriteLine(result);
sw.Close();
sr.Close();