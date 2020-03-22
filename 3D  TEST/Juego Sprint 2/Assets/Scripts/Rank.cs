using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Rank
{
    // Start is called before the first frame update
    public string playername;
    public int points;

    // Update is called once per frame
    public Rank(string s, int p)
    {
        playername = s;
        points = p;
    }

    public override string ToString()
    {
        return string.Format("{0}\t{1}", points, playername);
    }
}
