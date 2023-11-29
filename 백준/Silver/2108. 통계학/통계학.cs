StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
int N = int.Parse(sr.ReadLine());
int[] arr = new int[N];
int[] count = new int[8001];
int sum = 0;
int maxCount = 0;
for (int i = 0; i < N; i++)
{
    arr[i] = int.Parse(sr.ReadLine());
    sum += arr[i];
    maxCount = Math.Max(++count[arr[i] + 4000], maxCount);
}
Array.Sort(arr);
int freq = 0;
bool flag = false;
for (int i = 0; i < 8001; i++)
{
    if (count[i] == maxCount)
    {
        if (flag)
        {
            freq = i - 4000;
            break;
        }
        freq = i - 4000;
        flag = true;
    }
}
int avg = (int)Math.Round((double)sum / N);
int mid = arr[N / 2];
int range = arr[N - 1] - arr[0];
sw.WriteLine(avg);
sw.WriteLine(mid);
sw.WriteLine(freq);
sw.WriteLine(range);
sw.Close();
sr.Close();