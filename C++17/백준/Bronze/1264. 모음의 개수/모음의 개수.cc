#include <bits/stdc++.h>

using namespace std;


int main() {
    ios::sync_with_stdio(0);
    cin.tie(0);

    while (true) {
        int count = 0;
        string str;
        getline(cin, str);
        if (str.length() == 1 && str[0] == '#') break;
        for (auto &c: str) {
            if (c == 'a' || c == 'A' || c == 'e' || c == 'E'
                || c == 'I' || c == 'i' || c == 'o' || c == 'O' || c == 'U' || c == 'u')
                count++;
        }
        cout << count << '\n';
    }

    return 0;
}