using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelingUp : MonoBehaviour
{

    public static bool GameIsDone = false;
    public GameObject oPlayer;
    public GameObject levelMenuUI;

    [SerializeField] RectTransform FxHolder;
    [SerializeField] Image CircleImg;
    [SerializeField] Text txtProgress;

    [SerializeField] [Range(0, 1)] float progress = 1f;
    // Update is called once per frame
    void Update()
    {
        CircleImg.fillAmount = progress;
        txtProgress.text = "1," + Mathf.Floor(progress * 99).ToString();
        FxHolder.rotation = Quaternion.Euler(new Vector3(0f, 0f, -progress * 360));

        if (GameIsDone == false && oPlayer.GetComponent<player_score>().score.getScore() == 1500)
        {
            levelMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsDone = true;
        }
        if (GameIsDone)
        {
            if (progress < 1)
                progress += 0.006f;
            else
            {
                txtProgress.text = "2";
                GameIsDone = false;
            }
                
        }
        
    }

  
}
