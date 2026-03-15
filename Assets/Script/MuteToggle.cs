using UnityEngine;
using UnityEngine.UI;

public class MuteToggle : MonoBehaviour
{
    public Sprite soundOn;
    public Sprite soundOff;

    public Image buttonImage;

    bool isMuted = false;

    public void ToggleSound()
    {
        isMuted = !isMuted;

        if (isMuted)
        {
            AudioListener.volume = 0;
            buttonImage.sprite = soundOff;
        }
        else
        {
            AudioListener.volume = 1;
            buttonImage.sprite = soundOn;
        }
    }
}