using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToComplete = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    public bool isAnsweringQuestion = false;
    public bool loadNextQuestion = false;
    // Image timer;
    float timerValue;
    public float fillAmount;

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;
        if(isAnsweringQuestion)
        {
            if(timerValue > 0)
            {
                fillAmount = timerValue / timeToComplete;
            }
            else
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if(timerValue > 0)
            {
                fillAmount = timerValue / timeToShowCorrectAnswer;
            }
            else
            {
                timerValue = timeToComplete;
                isAnsweringQuestion = true;
                loadNextQuestion = true;
            }
        }
    }
}
