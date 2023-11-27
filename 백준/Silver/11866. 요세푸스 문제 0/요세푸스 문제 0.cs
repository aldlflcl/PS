Queue<int> queue = new();
StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
sw.Write('<');
int[] order = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
for (int i = 1; i <= order[0]; i++)
    queue.Enqueue(i);

while (queue.Count > 0)
{
    for (int i = 1; i < order[1]; i++)
    {
        queue.Enqueue(queue.Dequeue());
    }
    sw.Write(queue.Dequeue());
    if (queue.Count > 0) sw.Write(", ");
}
sw.Write('>');
sw.Close();
sr.Close();