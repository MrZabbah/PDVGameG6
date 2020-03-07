using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    // Start is called before the first frame update
    bool active;
    Canvas canvas;
    void Start()
    {
        active = false;
        canvas = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            active = !active;
            if (active)
            {
                canvas.enabled = true;
                Time.timeScale = 0;
            }
            else
            {
                canvas.enabled = false;
                Time.timeScale = 1;
            }
        }
    }
}
