StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
int N = int.Parse(sr.ReadLine());
int[] budgets = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int M = int.Parse(sr.ReadLine());
int st = 0;
int en = budgets.Max();

while (st < en)
{
   int mid = (st + en + 1) / 2;
   if (Solve(mid) <= M) st = mid;
   else en = mid - 1;
}
sw.WriteLine(st);
sw.Close();
sr.Close();

int Solve(int money)
{
   int count = 0;
   for (int i = 0; i < N; i++)
   {
      if (budgets[i] > money) count += money;
      else count += budgets[i];
   }
   return count;
}