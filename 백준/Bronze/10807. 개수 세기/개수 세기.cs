string[] arr = new String[int.Parse(Console.ReadLine())];
string[] str = Console.ReadLine().Split(" ");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = str[i];
}
string s = Console.ReadLine();
int cnt = 0;
foreach (string ss in str)
{
    if (ss == s) cnt++;
}
Console.WriteLine(cnt);
