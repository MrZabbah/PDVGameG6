using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Ranking
{
    public List<Rank> ranking;
    public Ranking()
    {
        ranking = new List<Rank>();
    }

    public void add(Rank r)
    {
        ranking.Add(r);
    }
    public override string ToString()
    {
        string cad = "";
        for (int i = 1; i <= ranking.Count; i++)
        {
            cad += i + "\t" + ranking[i-1].ToString() + "\n";
        }
        return cad;
    }
}
