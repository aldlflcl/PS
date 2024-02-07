#include <bits/stdc++.h>

using namespace std;

int T, n;
int arr[100004];
int state[100004];

constexpr int VISITED = 1;
constexpr int NOT_VISITED = 0;
constexpr int HAS_CYCLE = 3;
constexpr int NOT_CYCLE = 4;

void search(int idx) {
    int cur = idx;

    while (true) {
        state[cur] = VISITED;
        cur = arr[cur];

        if (state[cur] == HAS_CYCLE || state[cur] == NOT_CYCLE) {
            cur = idx;
            while (state[cur] == VISITED) {
                state[cur] = NOT_CYCLE;
                cur = arr[cur];
            }
            return;
        }

        if (state[cur] == VISITED && cur == idx) {
            cur = idx;
            while (state[cur] == VISITED) {
                state[cur] = HAS_CYCLE;
                cur = arr[cur];
            }
            return;
        }

        if (state[cur] == VISITED && cur != idx) {
            while (state[cur] == VISITED) {
                state[cur] = HAS_CYCLE;
                cur = arr[cur];
            }
            cur = idx;
            while(state[cur] == VISITED){
                state[cur] = NOT_CYCLE;
                cur = arr[cur];
            }
            return;
        }
    }
}

int main() {
    ios::sync_with_stdio(0);
    cin.tie(0);
    cin >> T;
    while (T--) {
        cin >> n;
        for (int i = 1; i <= n; i++)
            cin >> arr[i];
        fill(state, state + n + 3, NOT_VISITED);
        for (int i = 1; i <= n; i++)
            if (state[i] == NOT_VISITED)
                search(i);
        int result = 0;
        for (int i = 1; i <= n; i++)
            if (state[i] == HAS_CYCLE)
                result++;
        cout << n - result << '\n';
    }
}