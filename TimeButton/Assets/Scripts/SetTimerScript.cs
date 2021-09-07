using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTimerScript : MonoBehaviour
{
    public Text second;
    public int setSecond = 0;
    public Text playerSetSecond;


    public void SetTime()
    {

        second.text = setSecond.ToString();
    }

    public void SetPlayerTime()
    {

        second.text = playerSetSecond.text;
    }

}
