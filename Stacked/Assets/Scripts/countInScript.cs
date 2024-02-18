using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class countInScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    private float time;
    public bool countDown;

    private void Start()
    {
        countDown = true;
        time = 3f;
    }

    private void Update()
    {
        if (countDown)
        {

            time -= Time.deltaTime;
                
            if (time > 2) { text.text = "3"; }
            if (time <= 2 && time > 1) { text.text = "2"; }
            if (time <= 1 && time > 0) { text.text = "1"; }
            if (time <= 0 && time > -2) { text.text = "GO!"; }
            if (time < -2) { countDown = false; text.text = string.Empty; }
        }
    }
}
