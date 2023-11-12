using System.Text;

int n, m;
StringBuilder sb = new();
int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
n = input[0];
m = input[1];
input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(input);
int[] arr = new int[m];
func(0, 0);
Console.WriteLine(sb);

void func(int k, int index)
{
   if (k == m)
   {
      for (int i = 0; i < m; i++)
      {
         sb.Append($"{input[arr[i]]} ");
      }

      sb.AppendLine();
      return;
   }

   for (int i = index; i < n; i++)
   {
      arr[k] = i;
      func(k + 1, i);
   }
}