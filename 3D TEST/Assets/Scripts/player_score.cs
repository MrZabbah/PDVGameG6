using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_score : MonoBehaviour
{
    public int score;
    public Text scoremarker;
    void Start()
    {
        score = 0;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            Destroy(other.gameObject);
            score+=500;
            scoremarker.text = "Score: " + score.ToString();
            Debug.Log(score);
            
        }

    }

    
}
