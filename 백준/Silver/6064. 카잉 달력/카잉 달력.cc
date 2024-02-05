#include <bits/stdc++.h>

using namespace std;

int T, M, N, x, y;

int gcd(int a, int b) {
    if (b == 0)
        return a;
    return gcd(b, a % b);
}

int lcm(int a, int b){
    return a * b / gcd(a, b);
}

int main() {
    ios::sync_with_stdio(0);
    cin.tie(0);

    cin >> T;
    while (T--) {
       cin >> M >> N >> x >> y;
       int lm = lcm(M, N);
       int result = -1;
       for (int i = x; i <= lm; i += M) {
           if (i % N == y) {
              result = i;
              break;
           }
           else if (i % N == 0 && N == y) {
              result = i;
              break;
           }
       }
       cout << result << '\n';
    }
}