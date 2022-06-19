using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControls : MonoBehaviour
{
    Animator chestAnimController;
    void Awake()
    {
        chestAnimController = Camera.main.GetComponent<Animator>();
    }

    public void ProceedStateMachine()
    {
        chestAnimController.SetTrigger("AnimationComplete");
    }
}
