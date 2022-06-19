using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestAnimControls : MonoBehaviour
{
    Animator theStateMachine;
    public enum TypesOfParameters { floatParameter, intParameter, boolParameter, triggerParameter };

    public List<AnimatorProperties> animatedItems;

    void Awake()
    {
        theStateMachine = GetComponent<Animator>();
    }

    public void CheckForParameterSet()
    {
        foreach (AnimatorProperties animatorProperties in animatedItems)
        {
            foreach (ParameterProperties parameter in animatorProperties.animatorParameters)
            {
                if (theStateMachine.GetCurrentAnimatorStateInfo(0).IsName(parameter.whichState))
                {
                    if (parameter.typeOfParameter == TypesOfParameters.floatParameter)
                    {
                        animatorProperties.theAnimator.SetFloat(parameter.stringParameter, parameter.floatValue);
                    }
                    else if (parameter.typeOfParameter == TypesOfParameters.intParameter)
                    {
                        animatorProperties.theAnimator.SetInteger(parameter.stringParameter, parameter.intValue);
                    }
                    else if (parameter.typeOfParameter == TypesOfParameters.boolParameter)
                    {
                        animatorProperties.theAnimator.SetBool(parameter.stringParameter, parameter.boolValue);
                    }
                    else
                    {
                        animatorProperties.theAnimator.SetTrigger(parameter.stringParameter);
                    }
                }
            }
        }
    }

    public void PlayerInputTrigger(string triggerString)
    {
        theStateMachine.SetTrigger(triggerString);
    }

    [System.Serializable]
    public class ParameterProperties
    {
        public string stringParameter;
        public string whichState;
        public TypesOfParameters typeOfParameter;
        public float floatValue;
        public int intValue;
        public bool boolValue;
    }

    [System.Serializable]
    public class AnimatorProperties
    {
        public string name;
        public Animator theAnimator;
        public List<ParameterProperties> animatorParameters;
    }
}
