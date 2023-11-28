using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public TMP_Text displayTimeText;

    public float currentTime=5;

    private float displayTime;

    public UnityEvent gameOverEvent;


    // Update is called once per frame
    void Update()
    {
        currentTime-=Time.deltaTime;
        displayTime=Mathf.Round(currentTime);
        displayTimeText.text=displayTime.ToString() + "s";

        if(currentTime < 0)
        {
            Time.timeScale = 0;
            gameOverEvent.Invoke();
            displayTimeText.text = "Game Over, Try Again";
        }

        
      
    }



}
