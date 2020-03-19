using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] panels;

    // Update is called once per frame
    void Start()
    {
        changePanel(0);
    }
    public void changePanel(int num)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            if (i == num)
                panels[i].SetActive(true);
            else
                panels[i].SetActive(false);
        }
    }

    public void closeGame()
    {
        Application.Quit(0);
    }

    public void debugging()
    {
       
    }
}
