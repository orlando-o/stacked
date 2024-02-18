using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class levelController : MonoBehaviour
{
    public List<GameObject> racks;
    private int points;

    public int oneStarPointThreshold;
    public int twoStarPointThreshold;
    public int threeStarPointThreshold;

    [SerializeField] GameObject UIElements;
    [SerializeField] TextMeshProUGUI pointText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (UIElements.GetComponent<countDownTimer>().timeleft > 0)
        {
            points = 0;
            foreach (var rack in racks)
            {
                points += rack.GetComponent<objectCounter>().counter;
            }
            pointText.text = string.Format("Points: {0}", points);
        }
        else
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.Escape)) { SceneManager.LoadScene(0); }

    }
}
