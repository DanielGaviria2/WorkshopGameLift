using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnClick : MonoBehaviour
{ 
    private void OnMouseDown()
    {
        if(this.gameObject.GetComponent<Renderer>().enabled) this.gameObject.GetComponent<Renderer>().enabled = false;
        else this.gameObject.GetComponent<Renderer>().enabled = true;

    }
}
