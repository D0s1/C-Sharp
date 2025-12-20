// <copyright file="Quicksort.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

public static class Quicksort
{
    public static List<int> SortAndReturnList(List<int> list)
    {
        if (list.Count < 2)
        {
            return list;
        }

        int compareElem = list.First();
        List<int> smallerElems = list.Where(x => x < compareElem).ToList();
        List<int> biggerElems = list.Where(x => x > compareElem).ToList();
        List<int> sameElem = list.Where(x => x == compareElem).ToList();
        return SortAndReturnList(smallerElems)
            .Concat(sameElem)
            .Concat(SortAndReturnList(biggerElems))
            .ToList();
    }
}