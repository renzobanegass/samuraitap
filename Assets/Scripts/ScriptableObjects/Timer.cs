using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Timer", fileName = "Timer")]
public class Timer : ScriptableObject
{
    public float Seconds;
    public float Milliseconds;

    void Awake()
    {
        Seconds = 0;
        Milliseconds = 0;
    }
}
