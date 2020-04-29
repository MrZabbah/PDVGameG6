using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public player player;
    private bool tryingGetRespawn = false;
    private bool doIt = false;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && doIt)
        {
            player.SetCheckpoint(transform.position);
            doIt = false;
        }

        if (player.transform.position == transform.position)
            doIt = true;
        else
            doIt = false;
    }

    
}
