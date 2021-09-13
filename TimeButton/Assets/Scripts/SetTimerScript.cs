using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTimerScript : MonoBehaviour
{
    public Text second;
    public float setSecond = 10;
    public Text playerSetSecond;
    private bool runTimer = false;
    public Button setTimerButton;

    private void FixedUpdate()
    {
        if (runTimer) Timer2(setSecond);
    }

    public void OffSetTimerButton()
    {
        setTimerButton.transform.position = new Vector3(2000, 3000, 0);
    }
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
        second.text = setSecond.ToString();
        StartCoroutine(Timer(setSecond));
    }

    public void StartPlayerTimer()
    {
     /*   try
        { */
            setSecond = float.Parse(playerSetSecond.text);
     
            Debug.Log(setSecond);
        /*}
        catch (ArgumentNullException e)
        {
            Debug.Log(e);
            playerSetSecond.text = "Wrong Value";
        } */
       
        second.text = setSecond.ToString();
        //решение без корутины



        //решение с корутиной
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
        second.text = setSecond.ToString();
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

    public void Timer2(float timerTime)
    {
        while (timerTime > 0)
        {
            
            timerTime-=Time.deltaTime;
            second.text = timerTime.ToString();
        }
    }

    public void TrowTimer()
    {
        setSecond = 0;
        Timer2(setSecond);
    }

}
