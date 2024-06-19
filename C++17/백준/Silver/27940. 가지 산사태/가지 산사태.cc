#include <bits/stdc++.h>

using namespace std;

int N, M, K;

int main() {
    ios::sync_with_stdio(0);
    cin.tie(0);

    cin >> N >> M >> K;

    for (int i = 1; i <= M; i++) {
        int t, r;
        cin >> t >> r;
        K -= r;
        if (K < 0) {
            cout << i << " " << 1;
            return 0;
        }
    }
    cout << -1;

    return 0;
}