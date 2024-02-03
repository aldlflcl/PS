#include <bits/stdc++.h>

using namespace std;

int T;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(0);

    cin >> T;
    while (T--) {
        deque<int> dq;
        string s;
        string a;
        int temp;
        bool isReverse = false;
        bool isError = false;
        cin >> s;
        cin >> temp;
        cin >> a;
        int counter = 0;
        for (char c: a) {
            if (c >= '0' && c <= '9') {
                counter *= 10;
                counter += (c - '0');
            }
            else if (counter != 0){
                dq.push_back(counter);
                counter = 0;
            }
        }
        for (char c: s) {
            if (c == 'R')
                isReverse = !isReverse;
            else {
                if (dq.empty()) {
                    isError = true;
                    break;
                }

                if (isReverse)
                    dq.pop_back();
                else
                    dq.pop_front();
            }
        }

        if (isError) {
            cout << "error\n";
            continue;
        }

        string result;

        if (isReverse) {
            for (int i = dq.size() - 1; i >= 0; i--) {
                if (i == 0) result += to_string(dq[i]);
                else result += to_string(dq[i]) + ",";
            }
        } else {
            for (int i = 0; i < dq.size(); i++) {
                if (i == dq.size() - 1) result += to_string(dq[i]);
                else result += to_string(dq[i]) + ",";
            }
        }
        cout << "[" << result << "]\n";
    }

    return 0;
}