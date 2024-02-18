using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class countDownTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    private countInScript cd;
    public float timeleft = 180;

    private void Start()
    {
        timerText.text = "3:00";
        cd = gameObject.GetComponent<countInScript>();
    }
    // Update is called once per frame
    void Update()
    {
        if (!cd.countDown) {
            timeleft -= Time.deltaTime;

            int minutes = Mathf.FloorToInt(timeleft / 60);
            int seconds = Mathf.FloorToInt(timeleft % 60);

            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}
