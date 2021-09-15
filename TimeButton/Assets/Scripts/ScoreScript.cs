using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text nameTeam_1, nameTeam_2, nameTeam_3;
    public Text inputTeam_1, inputTeam_2, inputTeam_3;
    public Text scoreTeam_1, scoreTeam_2, scoreTeam_3;
    public float resultScore_1, resultScore_2, resultScore_3;
    public float[] results = new float[3];
    public Text winText;

    public void CalcScoreTeam(Text input, float result, Text score)
    {
        result += float.Parse(input.text);
        score.text = result.ToString();
    }

    public void AllCalc()
    {
        /*
        CalcScoreTeam(inputTeam_1, resultScore_1, scoreTeam_1);
        CalcScoreTeam(inputTeam_2, resultScore_2, scoreTeam_2);
        CalcScoreTeam(inputTeam_3, resultScore_3, scoreTeam_3);
        */
        resultScore_1 += float.Parse(inputTeam_1.text);
        scoreTeam_1.text = resultScore_1.ToString();

        resultScore_2 += float.Parse(inputTeam_2.text);
        scoreTeam_2.text = resultScore_2.ToString();

        resultScore_3 += float.Parse(inputTeam_3.text);
        scoreTeam_3.text = resultScore_3.ToString();

    }

    public void WinTeam()
    {
        results[0] = resultScore_1;
        results[1] = resultScore_2;
        results[2] = resultScore_3;
        float maxResult = 0f;

        foreach (float result in results)
        {
            if(maxResult <= result)
            {
                maxResult = result;
            }
        }
        if (maxResult == resultScore_1&& maxResult != resultScore_2 && maxResult != resultScore_3)
        {
            winText.text = "Выигрывает " + nameTeam_1.text + " команда";
        }
        else if (maxResult != resultScore_1 && maxResult == resultScore_2 && maxResult != resultScore_3)
        {
            winText.text = "Выигрывает " + nameTeam_2.text + " команда";
        }
        else if (maxResult != resultScore_1 && maxResult != resultScore_2 && maxResult == resultScore_3)
        {
            winText.text = "Выигрывает " + nameTeam_3.text + " команда";
        }
        else if (maxResult == resultScore_1 && maxResult == resultScore_2 && maxResult != resultScore_3)
        {
            winText.text = "Выигрывает " + nameTeam_1.text + " и " + nameTeam_2.text + " команда";
        }
        else if (maxResult != resultScore_1 && maxResult == resultScore_2 && maxResult == resultScore_3)
        {
            winText.text = "Выигрывает " + nameTeam_2.text + " и " + nameTeam_3.text + " команда";
        }
        else if (maxResult == resultScore_1 && maxResult != resultScore_2 && maxResult == resultScore_3)
        {
            winText.text = "Выигрывает " + nameTeam_1.text + " и " + nameTeam_3.text + " команда";
        }
        else if (maxResult == resultScore_1 && maxResult == resultScore_2 && maxResult == resultScore_3)
        {
            winText.text = "Выигрывают " + "все" + " команды";
        }
    }

}
