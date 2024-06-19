#include <bits/stdc++.h>

using namespace std;

int N, M;
int arr[104];

void swapInt(const int &st, const int &ed) {
    int temp = arr[st];
    arr[st] = arr[ed];
    arr[ed] = temp;
}

int main() {
    ios::sync_with_stdio(0);
    cin.tie(0);

    cin >> N >> M;
    for (int i = 1; i <= N; i++) arr[i] = i;

    while (M--) {
        int st, ed;
        cin >> st >> ed;
        swapInt(st, ed);
    }

    for (int i = 1; i <= N; i++) cout << arr[i] << " ";

    return 0;
}