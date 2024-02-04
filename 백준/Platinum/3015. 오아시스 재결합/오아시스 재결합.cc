#include <bits/stdc++.h>

using namespace std;

struct Fan {
    int height, count;
};
int N;
long long result;
stack<Fan> s;

int main() {
    ios::sync_with_stdio(0);
    cin.tie(0);

    cin >> N;
    while (N--) {
        int num;
        cin >> num;
        int sameValue = 1;
        while (!s.empty() && s.top().height <= num) {
            if (s.top().height == num) sameValue += s.top().count;
            result += s.top().count;
            s.pop();
        }
        if (!s.empty()) result++;
        s.push({num, sameValue});
    }
    cout << result;
}