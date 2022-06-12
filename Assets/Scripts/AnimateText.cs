using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class AnimateText : MonoBehaviour
{
    public List<CanvasGroup> textHolder = new List<CanvasGroup>();
    public List<TMP_Text> textDisplayBox = new List<TMP_Text>();
    public List<string> dialogue = new List<string>();
    public string nextScene;
    int whichText = 0;
    int positionInString = 0;
    Coroutine textPusher;

    IEnumerator WriteTheText()
    {
        for (int i = 0; i <= dialogue[whichText].Length; i++)
        {
            textDisplayBox[whichText].text = dialogue[whichText].Substring(0, i);
            positionInString++;
            yield return new WaitForSeconds(0.1f);
        }
    }

    void Start()
    {
         textPusher = StartCoroutine(WriteTheText());   
    }

    public void ProceedText()
    {
        if (positionInString < dialogue[whichText].Length)
        {
            StopCoroutine(textPusher);
            textDisplayBox[whichText].text = dialogue[whichText];
            positionInString = dialogue[whichText].Length;
        }
        else
        {
            textHolder[whichText].alpha = 0;
            textHolder[whichText].interactable = false;
            textHolder[whichText].blocksRaycasts = false;

            whichText++;

            if (whichText >= textDisplayBox.Count)
            {
                SceneManager.LoadScene(nextScene);
            }
            else
            {
                positionInString = 0;
                textHolder[whichText].alpha = 1;
                textHolder[whichText].interactable = true;
                textHolder[whichText].blocksRaycasts = true;
                textPusher = StartCoroutine(WriteTheText());
            }
        }
    }
}
