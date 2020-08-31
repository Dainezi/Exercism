using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private readonly List<int> myList = new List<int>();
    public HighScores(List<int> list)
    {
        myList = list;
    }

    public List<int> Scores()
    {
        return myList;
    }

    public int Latest()
    {
        return myList.Last();
    }

    public int PersonalBest()
    {
        return myList.Max();
    }

    public List<int> PersonalTopThree()
    {
        return myList.OrderByDescending(q => q).Take(3).ToList();
    }
}