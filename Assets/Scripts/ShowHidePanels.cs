using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHidePanels : MonoBehaviour
{
    public CanvasGroup inventoryPanel;
    public CanvasGroup pausePanel;
    public bool inventoryUp = false;
    public bool pauseUp = false;
    
    void Start()
    {
        inventoryPanel.alpha = 0;
        inventoryPanel.interactable = false;
        inventoryPanel.blocksRaycasts = false;

        pausePanel.alpha = 0;
        pausePanel.interactable = false;
        pausePanel.blocksRaycasts = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && pauseUp == false)
        {
            if (inventoryUp == false)
            {
                inventoryUp = true;
                inventoryPanel.alpha = 1;
                inventoryPanel.interactable = true;
                inventoryPanel.blocksRaycasts = true;
            }
            else
            {
                inventoryUp = false;
                inventoryPanel.alpha = 0;
                inventoryPanel.interactable = false;
                inventoryPanel.blocksRaycasts = false;
            }
        }
        if (Input.GetButtonDown("Pause"))
        {
            if (pauseUp == false)
            {
                pauseUp = true;
                pausePanel.alpha = 1;
                pausePanel.interactable = true;
                pausePanel.blocksRaycasts = true;
                Time.timeScale = 0;
            }
            else
            {
                pauseUp = false;
                pausePanel.alpha = 1;
                pausePanel.interactable = false;
                pausePanel.blocksRaycasts = false;
                Time.timeScale = 1;
            }
        }
    }
}
