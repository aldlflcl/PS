using System.Text;

int[] deque = new int[20_001];
int size = 0;
int head = 10_000;
int tail = head;
StringBuilder sb = new();
StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
int N = int.Parse(sr.ReadLine());

for (int i = 0; i < N; i++)
{
    string[] input = sr.ReadLine().Split();
    string order = input[0];
    if (order == "push_front")
    {
      PushFront(int.Parse(input[1]));  
    }
    else if (order == "push_back")
    {
      PushBack(int.Parse(input[1]));  
    }
    else if (order == "pop_front")
    {
       PopFront(); 
    }
    else if (order == "pop_back")
    {
       PopBack(); 
    }
    else if (order == "size")
    {
       Size(); 
    }
    else if (order == "empty")
    {
       Empty(); 
    }
    else if (order == "front")
    {
       Front(); 
    }
    else if (order =="back")
    {
        Back();
    }
}
sw.WriteLine(sb);
sw.Close();
sr.Close();
void PushFront(int n)
{
    size++;
    deque[--head] = n;
}

void PushBack(int n)
{
    size++;
    deque[tail++] = n;
}

void PopFront()
{
    if (size <= 0)
    {
        sb.AppendLine("-1");
        return;
    }
    size--;
    sb.AppendLine(deque[head++].ToString());
}

void PopBack()
{
    if (size <= 0)
    {
        sb.AppendLine("-1");
        return;
    }
    size--;
    sb.AppendLine(deque[--tail].ToString());
}

void Size()
{
    sb.AppendLine(size.ToString());
}

void Empty()
{
    if (size == 0)
        sb.AppendLine("1");
    else
        sb.AppendLine("0");
}

void Front()
{
    if (size <= 0)
        sb.AppendLine("-1");
    else
        sb.AppendLine(deque[head].ToString());
}

void Back()
{
    if (size <= 0)
        sb.AppendLine("-1");
    else
        sb.AppendLine(deque[tail - 1].ToString());
}