using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 targetposition;
    Vector3 lookat;
    Vector3 moveat;
    public Vector3 respawnPoint;

    public GameObject pref;

    public Camera cam;
    public float speed = 6;
    public LayerMask layercolision;
    public LayerMask layeritems;

    public int score;
    public Text scoremarker;

    void Start()
    {
        score = 0;
        targetposition = transform.position;
        respawnPoint = transform.position;
        lookat = Vector3.forward;
        moveat = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 axisdir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (axisdir != Vector2.zero && targetposition == transform.position )
        {
            if (Mathf.Abs(axisdir.x) > Mathf.Abs(axisdir.y))
            {
                if (axisdir.x > 0)
                {
                    lookat = Vector3.right;
                }
                else
                {
                    lookat = Vector3.left;
                }
            }
            else
            {
                if (axisdir.y > 0)
                {
                    lookat = Vector3.forward;
                }
                else
                {
                    lookat = Vector3.back;
                }
            }
            moveat = lookat;
            if (Physics.Raycast(transform.position, lookat, 1.0f, layercolision))
            {
                lookat = Vector3.zero;
            }
            targetposition = transform.position + lookat;
        }
    
        transform.position = Vector3.MoveTowards(transform.position, targetposition, speed * Time.deltaTime);
        cam.transform.position = new Vector3(transform.position.x, transform.position.y+10, transform.position.z - 10);
        if (moveat != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveat, Vector3.up);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 10)
        {
            Scene Currentscene = SceneManager.GetActiveScene();

            if (Currentscene.name == "Nivel 1") { SceneManager.LoadScene(2); }
            if (Currentscene.name == "Nivel 2") { Instantiate(pref); }

        }
        if (other.gameObject.layer == 9)
        {
            Destroy(other.gameObject);
            score += 500;
            scoremarker.text = "Score: " + score.ToString();
            Debug.Log(score);

        }
        
    }

    public void SetCheckpoint(Vector3 newCheckpoint)
    {
        respawnPoint = newCheckpoint;
    }
}
