using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTimerScript : MonoBehaviour
{
    public Text second;
    public float setSecond = 10;
    public Text playerSetSecond;


    public void SetTime()
    {

        second.text = setSecond.ToString();
    }

    public void SetPlayerTime()
    {

        second.text = playerSetSecond.text;
    }

    public void StartTimer()
    {
        StartCoroutine(Timer(setSecond));
    }

    public void StartPause()
    {
        Time.timeScale = 0;
    }

    public void StopPause()
    {
        Time.timeScale = 1;
    }

    public void StopTimer()
    {
        StopAllCoroutines();
        setSecond = 0f;
    }

    IEnumerator Timer(float timerTime)
    {
        while (timerTime > 0)
        {
            yield return new WaitForSeconds(1f);
            timerTime--;
            second.text = timerTime.ToString();
        }

    }

}
