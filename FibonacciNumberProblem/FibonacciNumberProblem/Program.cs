public class Solution
{
    private readonly int[] _dp;

    public Solution()
    {

        _dp = Enumerable.Repeat(-1, 31).ToArray();
        _dp[0] = 0;
        _dp[1] = 1;
    }

    public int Fib(int n)
    {
        if (_dp[n] != -1)
            return _dp[n];

        _dp[n] = Fib(n - 1) + Fib(n - 2);
        return _dp[n];
    }
}