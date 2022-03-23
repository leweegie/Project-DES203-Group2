using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeUI : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    private void OnEnable()
    {
        TImeManager.OnMinuteChanged += UpdateTime;
        TImeManager.OnHourChanged += UpdateTime;
    }

    private void OnDisable()
    {
        TImeManager.OnMinuteChanged -= UpdateTime;
        TImeManager.OnHourChanged -= UpdateTime;
    }

    private void UpdateTime()
    {
        timeText.text = $"{TImeManager.Hour:00}:{TImeManager.Minute:00}";
    }
}
