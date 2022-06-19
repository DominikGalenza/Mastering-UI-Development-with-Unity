using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestStateMachineBehaviour : StateMachineBehaviour
{
    ChestAnimControls theControllerScript;

    public void Awake()
    {
        theControllerScript = FindObjectOfType<ChestAnimControls>();
    }

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       theControllerScript.CheckForParameterSet();
    }
}
