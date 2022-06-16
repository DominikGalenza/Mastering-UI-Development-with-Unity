using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerCharacterSwap : MonoBehaviour
{
    public Image characterImage;
    TMP_Dropdown dropdown;
    
    void Awake()
    {
        dropdown = GetComponent<TMP_Dropdown>();
    }

    public void DropdownSelection(int selectionIndex)
    {
        Debug.Log($"Player selected {dropdown.options[selectionIndex].text}");
        characterImage.sprite = dropdown.options[selectionIndex].image;
    }
}
