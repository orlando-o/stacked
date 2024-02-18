using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPCameraController : MonoBehaviour
{
    [SerializeField] private RawImage fp;
    private bool showCamera = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift)) {
            showCamera = true;

        }
        else
        {
            showCamera = false;
           
        }

        fp.gameObject.SetActive(showCamera);
    }
}
