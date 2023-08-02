#include <string>
#include <vector>

using namespace std;

int solution(int n) {
    int x = 1;
    
    while (n % x != 1) {
        x++;
    }

    return x;
}