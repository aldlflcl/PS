int[] arr = new int[100_001];
int N = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i++)
    arr[i] = int.Parse(Console.ReadLine());
Array.Sort(arr, 0, N);
int max = 0;
for (int i = 1; i <= N; i++)
{
    max = Math.Max(max, arr[N - i] * i);
}
Console.WriteLine(max);