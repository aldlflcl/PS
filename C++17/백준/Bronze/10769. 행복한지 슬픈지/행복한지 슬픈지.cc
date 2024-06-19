#include <bits/stdc++.h>

using namespace std;

string str;
int emotion;
bool hasEmo;

int main() {
    ios::sync_with_stdio(0);
    cin.tie(0);
    getline(cin, str);

    for (int i = 0; i < str.length() - 2; i++) {
        if (str[i] != ':' || str[i + 1] != '-') continue;
        hasEmo = true;
        if (str[i + 2] == ')') emotion++;
        else if (str[i + 2] == '(') emotion--;
    }

    if (!hasEmo) {
        cout << "none";
        return 0;
    }

    if (emotion < 0) cout << "sad";
    else if (emotion == 0) cout << "unsure";
    else cout << "happy";

    return 0;
}