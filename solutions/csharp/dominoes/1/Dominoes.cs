public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        var set = dominoes.ToList();
        if (set.Count == 0) return true;
        return Solve(set, new List<(int, int)>());
    }


    public static bool Solve(List<(int, int)> remaining, List<(int, int)> current)
    {
        if (remaining.Count == 0) return current[0].Item1 == current[^1].Item2;
        for (int i = 0; i < remaining.Count; i++)
        {
            var stone = remaining[i];
            var nextRemaining = remaining.Where((_, index) => index != i).ToList();

            if (current.Count == 0 || current[^1].Item2 == stone.Item1)
            {
                current.Add(stone);
                if (Solve(nextRemaining, current)) return true;
                current.RemoveAt(current.Count-1);
            }
            else if (current.Count == 0 || current[^1].Item2 == stone.Item2)
            {
                current.Add((stone.Item2, stone.Item1));
                if (Solve(nextRemaining, current)) return true;
                current.RemoveAt(current.Count-1);
            }
        }
        return false;
    }
}