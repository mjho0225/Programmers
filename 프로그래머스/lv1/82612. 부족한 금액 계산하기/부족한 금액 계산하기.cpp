using namespace std;

long long solution(int price, int money, int count)
{
        long long totalCost = 0;

    for (int i = 1; i <= count; i++) {
        totalCost += static_cast<long long>(price) * i;
    }

    long long shortage = totalCost - money;
    return (shortage > 0) ? shortage : 0;
}