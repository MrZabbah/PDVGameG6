using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public static bool bEnd = false;
    [SerializeField] RectTransform FxHolder;
    [SerializeField] Image CircleImg;
    [SerializeField] Text txtProgress;

    [SerializeField] [Range(0, 1)] float progress = 0f;
    // Update is called once per frame
    void Update()
    {
        CircleImg.fillAmount = progress;
        txtProgress.text = Mathf.Floor(progress * 100).ToString();
        FxHolder.rotation = Quaternion.Euler(new Vector3(0f, 0f, -progress * 360));

    }

    public void updateProgress()
    {
        if (progress < 1)
            progress += 0.01f;
        else
        {
            print("lo para");
            bEnd = true;
        }
            
    }

    public void resetProgress()
    {
        progress = 0f;
        bEnd = false;
        LevelingUp.GameIsDone = false;
    }

}
