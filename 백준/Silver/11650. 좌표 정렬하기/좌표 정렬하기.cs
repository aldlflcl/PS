using System.Text;

int n;
StringBuilder sb = new();
StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
n = int.Parse(sr.ReadLine());
(int x, int y)[] arr = new (int x, int y)[n];
for (int i = 0; i < n; i++)
{
    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    arr[i] = (input[0], input[1]);
}

Array.Sort(arr, (first, second) =>
{
    if (first.x == second.x) return first.y - second.y;
    return first.x - second.x;
});
for (int i = 0; i < arr.Length; i++)
{
    (int x, int y) = arr[i];
    sb.AppendLine($"{x} {y}");
}
sw.WriteLine(sb);
sw.Close();
sr.Close();