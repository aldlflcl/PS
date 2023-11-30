StreamWriter sw = new(Console.OpenStandardOutput());
StreamReader sr = new(Console.OpenStandardInput());
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
    sw.WriteLine(poks[sr.ReadLine()]);
}

sw.Close();
sr.Close();