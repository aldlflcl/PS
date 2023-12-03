StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
List<int>[] vertex = new List<int>[1004];
bool[] visit = new bool[1004];
Queue<int> queue = new();
int result = 0;
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int N = input[0];
int M = input[1];
for (int i = 0; i <= N; i++)
    vertex[i] = new();
for (int i = 0; i < M; i++)
{
    input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    vertex[input[0]].Add(input[1]);
    vertex[input[1]].Add(input[0]);
}

for (int i = 1; i <= N; i++)
{
    if (visit[i]) continue;
    visit[i] = true;
    queue.Enqueue(i);
    while (queue.Count > 0)
    {
        int cur = queue.Dequeue();
        foreach (int nx in vertex[cur])
        {
            if (visit[nx]) continue;
            visit[nx] = true;
            queue.Enqueue(nx);
        }
    }
    result++;
}
sw.WriteLine(result);
sw.Close();
sr.Close();