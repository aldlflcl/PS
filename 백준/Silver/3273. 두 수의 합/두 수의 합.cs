int n = int.Parse(Console.ReadLine());
int[] arr = new int[1000001];
int[] seq = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
for (int i = 0; i < seq.Length; i++)
{
    arr[seq[i]]++;
}
int count = 0;
int x = int.Parse(Console.ReadLine());
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] == 0) continue;
    int diff = x - i;
    if (diff < 0 || diff == i || diff > 100000) continue;
    if (arr[diff] > 0)
    {
        count++;
        arr[diff] = 0;
    }
}
Console.WriteLine(count);