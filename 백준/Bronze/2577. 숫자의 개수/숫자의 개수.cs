int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
string s = (a * b * c).ToString();
int[] arr = new int[10];
for (int i = 0; i < s.Length; i++)
{
    arr[s[i] - 48]++;
}
foreach (int i in arr)
{
   Console.WriteLine(i); 
}