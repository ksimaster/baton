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
        Debug.Log("������ ������ ������");
        winText.text = "������ ������";
    }

    public void ClickSecondButton()
    {
        Debug.Log("������ ������ ������");
        winText.text = "������ ������";
    }

    public void ClickThirdButton()
    {
        Debug.Log("������ ������ ������");
        winText.text = "������ ������";
    }

    public void RechargeButton()
    {
        Debug.Log("����������� �����������");
        winText.text = "��� ������?";
    }





}
