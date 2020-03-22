using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    private int score;
    public string nombre;
    public Text scoreText;
    void Start()
    {
        score = 0;
        updateScore();
    }

    // Update is called once per frame
    public void AddScore(int value)
    {
        score += value;
        updateScore();
    }
    void updateScore()
    {
        scoreText.text = "Score: " + score;                                                                                      
    }

    public int getScore()
    {
        return score;
    }
}
