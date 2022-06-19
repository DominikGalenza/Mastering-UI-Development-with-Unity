using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHidePanelsWithAnimation : MonoBehaviour
{
    public Animator inventoryPanelAnimator;
    public Animator pausePanelAnimator;
    public bool inventoryUp = false;
    public bool pauseUp = false;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && pauseUp == false)
        {
            if (inventoryUp == false)
            {
                inventoryUp = true;
                inventoryPanelAnimator.SetTrigger("FadeIn");
            }
            else
            {
                inventoryUp = false;
                inventoryPanelAnimator.SetTrigger("FadeOut");
            }
        }
        if (Input.GetButtonDown("Pause"))
        {
            if (pauseUp == false)
            {
                pauseUp = true;
                Time.timeScale = 0;
                pausePanelAnimator.SetTrigger("FadeIn");
            }
            else
            {
                pauseUp = false;
                Time.timeScale = 1;
                pausePanelAnimator.SetTrigger("FadeOut");
            }
        }
    }
}
