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
        string cad = "Ranking: \n";
        for (int i = 0; i < ranking.Count; i++)
        {
            cad += ranking[i].ToString() + ", ";
        }
        return cad;
    }
}
