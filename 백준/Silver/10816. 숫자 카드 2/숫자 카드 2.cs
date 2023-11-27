using System.Text;

int[] cards = new int[20_000_001];
StringBuilder sb = new();
StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
int N = int.Parse(sr.ReadLine());
int[] order = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
for (int i = 0; i < N; i++)
{
    cards[order[i] + 10_000_000]++;
}
N = int.Parse(sr.ReadLine());
order = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
for (int i = 0; i < N; i++)
   sb.Append(cards[order[i] + 10_000_000] + " ");
sw.WriteLine(sb);
sw.Close();
sr.Close();