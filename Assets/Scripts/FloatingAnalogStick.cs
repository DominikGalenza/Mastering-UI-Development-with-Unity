using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingAnalogStick : MonoBehaviour
{
    public RectTransform theStick;
    public RectTransform theBase;
    CanvasGroup theBaseVisibility;
    Vector2 mouseStartPosition;
    Vector2 mouseCurrentPosition;
    public int dragPadding = 30;
    public int stickMoveDistance = 30;
    public bool stickAdded = false;

    public void MovingLeft()
    {
        Debug.Log("move left");
    }

    public void MovingRight()
    {
        Debug.Log("move right");
    }

    public void MovingUp()
    {
        Debug.Log("move up");
    }

    public void MovingDown()
    {
        Debug.Log("moving down");
    }
    
    public void StartDragging()
    {
        mouseStartPosition = Input.mousePosition;
    }

    void Awake()
    {
        theBaseVisibility = theBase.GetComponent<CanvasGroup>();
    }

    void Update()
    {
        if (stickAdded == true)
        {
            Dragging();

            if (Input.GetMouseButtonUp(0))
            {
                stickAdded = false;
                StoppedDragging();

                theBaseVisibility.alpha = 0;
                theBaseVisibility.interactable = false;
                theBaseVisibility.blocksRaycasts = false;
            }    
        }
    }
    public void Dragging()
    {
        float xPos;
        float yPos;
        mouseCurrentPosition = Input.mousePosition;

        if (mouseCurrentPosition.x < mouseStartPosition.x - dragPadding)
        {
            MovingLeft();
            xPos =- 10;
        }
        else if (mouseCurrentPosition.x > mouseStartPosition.x + dragPadding)
        {
            MovingRight();
            xPos = +10;
        }
        else
        {
            xPos = 0;
        }

        if (mouseCurrentPosition.y < mouseStartPosition.y - dragPadding)
        {
            MovingDown();
            yPos = -10;
        }
        else if (mouseCurrentPosition.y > mouseStartPosition.y + dragPadding)
        {
            MovingUp();
            yPos =+ 10;
        }
        else
        {
            yPos = 0;
        }

        theStick.anchoredPosition = new Vector2(xPos, yPos);
    }

    public void StoppedDragging()
    {
        theStick.anchoredPosition = Vector2.zero;
    }

    public void AddTheStick()
    {
        theBaseVisibility.alpha = 1;
        theBaseVisibility.interactable = true;
        theBaseVisibility.blocksRaycasts = true;

        theBase.anchoredPosition = Input.mousePosition;
        theStick.anchoredPosition = Vector2.zero;
        mouseStartPosition = Input.mousePosition;
        stickAdded = true;
    }
}