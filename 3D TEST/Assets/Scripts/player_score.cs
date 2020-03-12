using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_score : MonoBehaviour
{
    public Score score;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            Destroy(other.gameObject);
            score.AddScore(500);
        }

    }
}
