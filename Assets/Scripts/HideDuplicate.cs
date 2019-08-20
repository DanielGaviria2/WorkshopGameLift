using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideDuplicate : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.gameObject.SetActive(false);
        Debug.Log("cosas");
    }
    
}
