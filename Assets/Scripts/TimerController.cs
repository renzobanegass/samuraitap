using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using System;

public class TimerController : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private Timer timer;

    private float time;
    private float seconds;
    private float milliseconds;
    void Awake()
    {
        timer.Seconds = 0;
        timer.Milliseconds = 0;
    }
    IEnumerator StopWatch()
    {
        while (true)
        {
            time += Time.deltaTime;
            milliseconds = (int)((time - (int)time) * 1000);
            seconds = (int)(time % 60);

            timerText.text = string.Format("{0:00}.{1:000}", seconds, milliseconds);

            yield return null;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        StopTimer(eventData.pointerCurrentRaycast.gameObject);
    }

    private void StopTimer(GameObject panel)
    {
        if (panel.tag == "LeftPanel" || panel.tag == "RightPanel")
        {
            StopTimer();
        }
    }

    private void StopTimer()
    {
        StopWatchStop();

        timer.Milliseconds = milliseconds;
        timer.Seconds = seconds;
    }

    public void StopWatchStop()
    {
        StopCoroutine("StopWatch");
    }

    void Start()
    {
        StartCoroutine("StopWatch");
    }
}
