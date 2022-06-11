using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteUnmute : MonoBehaviour
{
    public Button musicButton;
    public Button soundButton;
    Image musicImage;
    Image soundImage;
    public Sprite musicOn;
    public Sprite musicOff;
    public Sprite soundOn;
    public Sprite soundOff;
    bool musicMuted;
    bool soundMuted;

    void Awake()
    {
        musicImage = musicButton.GetComponent<Image>();
        soundImage = soundButton.GetComponent<Image>();
    }

    public void MuteAndUnmuteMusic()
    {
        if (musicMuted == false)
        {
            musicMuted = true;
            musicImage.sprite = musicOff;
        }
        else
        {
            musicMuted = false;
            musicImage.sprite = musicOn;
        }
    }

    public void MuteAndUnmuteSound()
    {
        if (soundMuted == false)
        {
            soundMuted = true;
            soundImage.sprite = soundOff;
        }
        else
        {
            soundMuted = false;
            soundImage.sprite = soundOn;
        }
    }
}
