using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectCounter : MonoBehaviour
{
    public int counter;
    void Start()
    {
        counter = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item") { counter++; }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Item") { counter--; }
    }
}
