using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // Patrón Singleton:
    public static GameManager instance = null;
    public RankingManager rankingmanager;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
         DontDestroyOnLoad(this);
    }

    public void ChangeScene(int i)
    {
        SceneManager.LoadScene(i);
    }
}
