string[] input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int k = int.Parse(input[1]);
int[] male = new int[7];
int[] female = new int[7];
int solve = 0;
for (int i = 0; i < n; i++)
{
    string[] student = Console.ReadLine().Split();
    int grade = int.Parse(student[1]);
    if (student[0] == "0")
        female[grade]++;
    else
        male[grade]++;
}

for (int i = 1; i < 7; i++)
{
    if (male[i] > k)
    {
        int rest = male[i] % k;
        solve += male[i] / k + (rest > 0 ? 1 : 0);
    }
    else if (male[i] > 0) solve++;

    if (female[i] > k)
    {
        int rest = female[i] % k;
        solve += female[i] / k + (rest > 0 ? 1 : 0);
    }
    else if (female[i] > 0) solve++;
}

Console.WriteLine(solve);