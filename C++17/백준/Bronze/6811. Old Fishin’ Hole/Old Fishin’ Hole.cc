#include <bits/stdc++.h>

using namespace std;

int troutPoint, pikePoint, pickerelPoint, totalPoint, maxTrout, maxPike, maxPickerel, result;

int main() {
    ios::sync_with_stdio(0);
    cin.tie(0);

    cin >> troutPoint >> pikePoint >> pickerelPoint >> totalPoint;
    maxTrout = totalPoint / troutPoint;
    maxPike = totalPoint / pikePoint;
    maxPickerel = totalPoint / pickerelPoint;

    for (int i = 0; i <= maxTrout; i++) {
        for (int j = 0; j <= maxPike; j++) {
            for (int k = 0; k <= maxPickerel; k++) {
                if ((i | j | k) < 1) continue;
                int point = i * troutPoint + j * pikePoint + k * pickerelPoint;
                if (point <= totalPoint) {
                    cout << i << " Brown Trout, "
                         << j << " Northern Pike, "
                         << k << " Yellow Pickerel"
                         << '\n';
                    result++;
                }
            }
        }
    }

    cout << "Number of ways to catch fish: " << result;
    return 0;
}