using System.Text;

StreamWriter sw = new(Console.OpenStandardOutput());
StreamReader sr = new(Console.OpenStandardInput());
StringBuilder sb = new();
Dictionary<string, string> poks = new();
int[] order = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
for (int i = 1; i <= order[0]; i++)
{
    string str = sr.ReadLine();
    poks.Add(str, i.ToString());
    poks.Add(i.ToString(), str);
}

for (int i = 1; i <= order[1]; i++)
{
    sb.AppendLine(poks[sr.ReadLine()]);
}
sw.Write(sb);
sw.Close();
sr.Close();