using System.Text;

StringBuilder sb = new();
int N = int.Parse(Console.ReadLine());
sb.AppendLine("어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.");

string[] before =
{
    "\"재귀함수가 뭔가요?\"",
    "\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.",
    "마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.",
    "그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"",
};
string dash = "____";
string after = "라고 답변하였지.";

void Rec(int l, int depth)
{
    string tmp = "";

    for (int i = 0; i < depth; i++)
        tmp += dash;

    if (l == 0)
    {
        sb.Append(tmp);
        sb.AppendLine(before[0]);
        sb.Append(tmp);
        sb.AppendLine("\"재귀함수는 자기 자신을 호출하는 함수라네\"");
        sb.Append(tmp);
        sb.AppendLine(after);
        return;
    }

    
    for (int i = 0; i < 4; i++)
    {
        sb.Append(tmp);
        sb.AppendLine(before[i]);
    }

    Rec(l - 1, depth + 1);
    sb.Append(tmp);
    sb.AppendLine(after);
}
Rec(N, 0);
Console.WriteLine(sb);