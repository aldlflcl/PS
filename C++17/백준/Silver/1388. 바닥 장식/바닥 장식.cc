#include <bits/stdc++.h>

using namespace std;

int N, M;
string a[55];

int main() {
    ios::sync_with_stdio(0);
    cin.tie(0);

    cin >> N >> M;
    cin.clear();

    for (int i = 0; i < N; i++) {
        cin >> a[i];
    }

    int count = 0;

    for (int i = 0; i < N; i++) {
        bool hor = false;
        for (int j = 0; j < M; j++) {
            if (a[i][j] == '-' && !hor) {
                hor = true;
                count++;
            } else if (a[i][j] != '-') {
                hor = false;
            }
        }
    }

    for (int i = 0; i < M; i++) {
        bool ver = false;
        for (int j = 0; j < N; j++) {
            if (a[j][i] == '|' && !ver) {
                ver = true;
                count++;
            } else if (a[j][i] != '|') {
                ver = false;
            }
        }
    }

    cout << count;

    return 0;
}