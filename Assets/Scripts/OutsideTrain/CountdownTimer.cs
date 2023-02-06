using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public float timeValue = 120;
    public Text timeText;
    public GameObject gameover;
    public GameObject health;
    public GameObject money;
    public GameObject timer;

    void Update()
    {
        if (timeValue >= 0)
        {
            timeValue -= Time.deltaTime;
        }
            
        if (timeValue <= 31)
        {
            timeText.color = Color.red;
        }
       
        if(timeValue <= 0)
        {
            gameover.SetActive(true);
            health.SetActive(false);
            money.SetActive(false);
            timer.SetActive(false);
        }
            
        DisplayTime(timeValue);
    }
    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes,seconds);
    }
}
