using System.Text;

StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StringBuilder sb = new();
int n = int.Parse(sr.ReadLine());
int[] arr = new int[1001];
int[] tmp = new int[1001];
for (int i = 0; i < n; i++)
{
   arr[i] = int.Parse(sr.ReadLine());
}
MergeSort(0, n);
for (int i = 0; i < n; i++)
    sb.AppendLine(arr[i].ToString());
sw.WriteLine(sb);
sw.Close();
sr.Close();
return;

void Merge(int start, int end)
{
    int mid = (start + end) / 2;
    int leftIndex = start;
    int rightIndex = mid;

    for (int i = start; i < end; i++)
    {
        if (leftIndex == mid) tmp[i] = arr[rightIndex++];
        else if (rightIndex == end) tmp[i] = arr[leftIndex++];
        else if (arr[leftIndex] <= arr[rightIndex]) tmp[i] = arr[leftIndex++];
        else tmp[i] = arr[rightIndex++];
    }

    for (int i = start; i < end; i++)
        arr[i] = tmp[i];
}

void MergeSort(int start, int end)
{
    if (end == start + 1) return;
    int mid = (start + end) / 2;
    MergeSort(start, mid);
    MergeSort(mid, end);

    Merge(start, end);
}