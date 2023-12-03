StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
Dictionary<int, int> map = new();
int N = int.Parse(sr.ReadLine());
int rank = 0;
int[] sorted = new int[N];
int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
for (int i = 0; i < N; i++)
{
    sorted[i] = arr[i];
}
Array.Sort(sorted);
for (int i = 0; i < N; i++)
{
    if (!map.ContainsKey(sorted[i]))
        map[sorted[i]] = rank++;
}
for (int i = 0; i < N; i++)
{
    sw.Write(map[arr[i]] + " ");
}
sw.Close();
sr.Close();