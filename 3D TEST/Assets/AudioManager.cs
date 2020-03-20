using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    bool music;
    void Awake()
    {
        music = true;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void togglesound()
    {
        music = !music;
        if (music == true)
            this.GetComponent<AudioSource>().Stop();
        else
            this.GetComponent<AudioSource>().Play();
    }
}
