using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TImeManager : MonoBehaviour
{
    public static Action OnMinuteChanged;
    public static Action OnHourChanged;

    public static int Minute { get; private set; } = 0;

    public static int Hour { get; private set; } = 10;

    private float minuteToRealTime = 0.5f;
    private float timer;
    
    // Start is called before the first frame update
    void Start()
    {

        timer = minuteToRealTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <=0)
        {
            Minute++;
            OnMinuteChanged?.Invoke();

            if(Minute >= 60)
            {
                Hour++;
                OnHourChanged?.Invoke();
                Minute = 0;
            }

            timer = minuteToRealTime;
        }
    }
}
