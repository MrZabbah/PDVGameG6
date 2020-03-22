using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class RankingManager : MonoBehaviour
{
    // Start is called before the first frame update
    string playername;
    int score;
    Ranking ranking;
    public Text rankingtable;

    string filepath;
    string jsonstring;

    void Awake()
    {
        ranking = new Ranking();
        score = 0;
        name = "";
    }

    // Update is called once per frame
    private void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex != 0)
        {

        }
    }
    void updateScore()
    {

    }

    public void addScore(int value)
    {
        score += value;
        updateScore();
    }

    public string ToStringRanking()
    {
        filepath = Application.dataPath + "/Rankinglist.json";
        jsonstring = File.ReadAllText(filepath);

        if (jsonstring != null)
        {
            ranking = JsonUtility.FromJson<Ranking>(jsonstring);
        }
        if (ranking == null)
            ranking = new Ranking();
        return ranking.ToString();
    }
    public void updateranking()
    {
        rankingtable.text = ToStringRanking();
    }
}
