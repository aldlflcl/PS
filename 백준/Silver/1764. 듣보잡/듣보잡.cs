using System.Text;

class P1764
{
    private static StreamReader sr = new(Console.OpenStandardInput());
    private static StreamWriter sw = new(Console.OpenStandardOutput());
    private static StringBuilder sb = new();
    private static HashSet<string> hear = new(); 
    private static HashSet<string> see = new(); 
    private static int N, M;
    static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        N = input[0];
        M = input[1];
        for (int i = 0; i < N; i++)
        {
            hear.Add(sr.ReadLine());
        }
        for (int i = 0; i < M; i++)
        {
            see.Add(sr.ReadLine());
        }
        var intersect = hear.Intersect(see).OrderBy(name => name).ToList();
        sb.AppendLine(intersect.Count.ToString());
        intersect.ForEach(s => sb.AppendLine(s));
        sw.WriteLine(sb);
        sw.Close();
        sr.Close();
    } 
}