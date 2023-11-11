using System.Text;

int[] arr = new int[1_000_000 * 2 + 1];
StringBuilder sb = new();
int n = int.Parse(Console.ReadLine());
int max = int.MinValue;
for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine()) + 1_000_000;
    max = num > max ? num : max;
    arr[num]++;
}

for (int i = 0; i <= max; i++)
{
    if (arr[i] != 0)
    {
        sb.AppendLine((i - 1_000_000).ToString());
    }
}

Console.WriteLine(sb);