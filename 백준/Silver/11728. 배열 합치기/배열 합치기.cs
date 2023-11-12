using System.Text;

int[] arr1, arr2;
int idx1 = 0, idx2 = 0;
StringBuilder sb = new();
StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
sr.ReadLine();
arr1 = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
arr2 = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
for (int i = 0; i < arr1.Length + arr2.Length; i++)
{
    if (idx1 >= arr1.Length)
    {
        sb.Append($"{arr2[idx2++]} ");
        continue;
    }

    if (idx2 >= arr2.Length)
    {
        sb.Append($"{arr1[idx1++]} ");
        continue;
    }

    int num1 = arr1[idx1];
    int num2 = arr2[idx2];
    int min;
    if (num1 > num2)
    {
        min = num2;
        idx2++;
    }
    else
    {
        min = num1;
        idx1++;
    }

    sb.Append($"{min} ");
}
sw.Write(sb);
sr.Close();
sw.Close();
return;