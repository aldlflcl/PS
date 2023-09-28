string[] input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int k = int.Parse(input[1]);
int[] male = new int[7];
int[] female = new int[7];
for (int i = 0; i < n; i++)
{
    string[] student = Console.ReadLine().Split();
    if (student[0] == "0") female[int.Parse(student[1])]++;
    else male[int.Parse(student[1])]++;
}
int solve = 0;
for (int i = 1; i < 7; i++)
{
    if (male[i] > k)
    {
        solve += male[i] / k + male[i] % k;
    } else if (male[i] > 0) solve++;

    if (female[i] > k)
    {
        solve += female[i] / k + female[i] % k;
    } else if (female[i] > 0) solve++;
}
Console.WriteLine(solve);