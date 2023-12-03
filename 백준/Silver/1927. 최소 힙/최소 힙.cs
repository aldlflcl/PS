using System.Text;

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
StringBuilder sb = new();
PriorityQueue<int, int> queue = new();
int N = int.Parse(sr.ReadLine());
for (int i = 0; i < N; i++)
{
    int order = int.Parse(sr.ReadLine());
    if (order == 0)
    {
        queue.TryDequeue(out int e, out int p);
        sb.Append(e + "\n");
    }
    else
    {
        queue.Enqueue(order, order);
    }
}
sw.Write(sb);
sw.Close();
sr.Close();