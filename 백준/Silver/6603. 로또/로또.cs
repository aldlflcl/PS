using System.Text;

StringBuilder sb = new();
int[] input;
int k;
int[] arr;
while (true)
{
    input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    k = input[0];
    if (k == 0) return;
    
    arr = new int[6];
    func(0, 0);
    Console.WriteLine($"{sb}");
    sb.Clear();
}

void func(int index, int level)
{
    if (level == 6)
    {
        for (int i = 0; i < 6; i++)
        {
            sb.Append($"{arr[i]} ");
        }
        sb.AppendLine();
        return;
    }
    for (int i = index; i < k; i++)
    {
        arr[level] = input[i + 1];
        func(i + 1, level + 1);
    }
}