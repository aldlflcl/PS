string input = Console.ReadLine();
int[] arr = new int[10];
for (int i = 0; i < input.Length; i++)
{
   arr[input[i] - 48]++;
}
arr[9] = arr[6] = (arr[6] + arr[9] + 1) / 2;
Console.WriteLine(arr.Max());