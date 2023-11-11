int m;
int[] cards;
int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
m = input[1];
cards = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int answer = int.MinValue;
for (int i = 0; i < cards.Length; i++)
{
    for (int j = i + 1; j < cards.Length; j++)
    {
        for (int k = j + 1; k < cards.Length; k++)
        {
            int calc = cards[i] + cards[j] + cards[k];
            if (calc <= m)
            {
                answer = answer < calc ? calc : answer;
            }
        }
    }
}
Console.WriteLine(answer);