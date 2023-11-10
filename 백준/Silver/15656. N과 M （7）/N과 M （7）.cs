using System.Text;

StringBuilder sb = new();
StreamWriter sw = new(Console.OpenStandardOutput());
StreamReader sr = new(Console.OpenStandardInput());
int[] arr = new int[10];
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int n = input[0];
int m = input[1];
input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
Array.Sort(input);
func(0);
sw.WriteLine(sb);
sw.Close();
sr.Close();

void func(int depth)
{
    if (depth == m)
    {
        for (int i = 0; i < m; i++)
        {
            sb.Append(input[arr[i]] + " ");
        }
        sb.AppendLine();
        return;
    }

    for (int i = 0; i < n; i++)
    {
        arr[depth] = i;
        func(depth + 1);
    }
}