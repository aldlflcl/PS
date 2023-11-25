using System.Text;

StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StringBuilder sb = new();
int[] order = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
char[] chars = sr.ReadLine().Replace(" " , "").ToCharArray();
int[] arr = new int[order[0]];
Array.Sort(chars);
Func(0);
Console.WriteLine(sb);

void Func(int level)
{
    if (level == order[0])
    {
        if (!Check())
            return;

        for (int i = 0; i < order[0]; i++)
        {
            sb.Append(chars[arr[i]]);
        }

        sb.AppendLine();
        return;
    }

    int st = 0;
    if (level != 0)
        st = arr[level - 1] + 1;

    for (int i = st; i < order[1]; i++)
    {
        arr[level] = i;
        Func(level + 1);
    }
}

bool Check()
{
    int vowel = 0;
    int consonant = 0;

    for (int i = 0; i < order[0]; i++)
    {
        char c = chars[arr[i]];
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            vowel++;
        else
            consonant++;
    }

    if (vowel >= 1 && consonant >= 2)
        return true;
    return false;
}