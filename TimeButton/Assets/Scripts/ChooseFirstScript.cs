using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseFirstScript : MonoBehaviour
{
    [SerializeField]
    private Text winText;

    public void ClickFirstButton()
    {
        Debug.Log("Нажата первая кнопка");
        winText.text = "Первая кнопка";
    }

    public void ClickSecondButton()
    {
        Debug.Log("Нажата вторая кнопка");
        winText.text = "Вторая кнопка";
    }

    public void ClickThirdButton()
    {
        Debug.Log("Нажата третья кнопка");
        winText.text = "Третья кнопка";
    }

    public void RechargeButton()
    {
        Debug.Log("Произведена перезарядка");
        winText.text = "Кто первый?";
    }





}
