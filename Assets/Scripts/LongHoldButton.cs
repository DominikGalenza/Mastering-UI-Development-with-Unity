using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LongHoldButton : MonoBehaviour
{
    bool buttonPressed = false;
    float  startTime = 0f;
    float holdTime = 0f;
    public float longHoldTime = 1f;
    public Image radialFillImage;

    public void PressAndRelease(bool pressStatus)
    {
        buttonPressed = pressStatus;

        if (buttonPressed == false)
        {
            holdTime = 0;
            radialFillImage.fillAmount = 0;
        }
        else
        {
            startTime = Time.time;
        }
    }

    public void longPressCompleted()
    {
        radialFillImage.fillAmount = 0;
    }

    void Update()
    {
        if (buttonPressed == true)
        {
            holdTime = Time.time - startTime;
            if (holdTime >= longHoldTime)
            {
                buttonPressed = false;
                longPressCompleted();
            }
            else
            {
                radialFillImage.fillAmount = holdTime / longHoldTime;
            }
        }
    }
}
