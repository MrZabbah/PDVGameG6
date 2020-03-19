using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PedirNombre : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField nametext;
    public Canvas display;
    
   public void InputName()
    {
        string nombre = nametext.text;
        this.GetComponent<Score>().nombre = nombre;
        display.enabled = false;
        Debug.Log("Nombre: " + nombre);
    }
}
