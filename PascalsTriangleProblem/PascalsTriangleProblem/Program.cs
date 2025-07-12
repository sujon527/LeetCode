public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        var cache = new Dictionary<(int r, int c), int>();


        int Value(int r, int c)
        {
            if (c == 0 || c == r) return 1;
            if (cache.TryGetValue((r, c), out int v)) return v;

            v = Value(r - 1, c - 1) + Value(r - 1, c);
            cache[(r, c)] = v;
            return v;
        }

        var triangle = new List<IList<int>>(numRows);

        for (int r = 0; r < numRows; r++)
        {
            var row = new int[r + 1];
            for (int c = 0; c <= r; c++)
                row[c] = Value(r, c);

            triangle.Add(row);
        }
        return triangle;
    }
}
