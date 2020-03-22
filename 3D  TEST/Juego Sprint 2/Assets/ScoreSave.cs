using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
public class ScoreSave : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    public Text text;
    public InputField namefield;
    Rank rank;
    Ranking ranking;
    int pscore;

    string filepath;
    string jsonstring;
    void Start()
    {
        rank = new Rank("",0);
        ranking = new Ranking();
        player = GameObject.Find("Player");
        pscore = player.GetComponent<player>().score;
        text.text = "SCORE: "+pscore;
    }
    public void saveRank()
    {
        if (namefield.text != "")
        {
            filepath = Application.dataPath + "/Rankinglist.json";
            jsonstring = File.ReadAllText(filepath);

            if (jsonstring != null)
            {
                ranking = JsonUtility.FromJson<Ranking>(jsonstring);
            }
            if (ranking == null)
                ranking = new Ranking();
            rank = new Rank(namefield.text, pscore);
            ranking.add(rank);

            jsonstring = JsonUtility.ToJson(ranking);
            File.WriteAllText(filepath, jsonstring);

            SceneManager.LoadScene(0);
        }
        
    }

}
