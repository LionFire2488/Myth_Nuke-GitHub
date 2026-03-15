using UnityEngine;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour
{
    public Sprite soundOnIcon;
    public Sprite soundOffIcon;

    private Image buttonImage;

    void Start()
    {
        buttonImage = GetComponent<Image>();

        UpdateIcon();
    }

    public void ToggleSound()
    {
        bool currentMute = AudioManager.instance.music.mute;

        AudioManager.instance.music.mute = !currentMute;

        UpdateIcon();
    }

    void UpdateIcon()
    {
        if (AudioManager.instance.music.mute)
            buttonImage.sprite = soundOffIcon;
        else
            buttonImage.sprite = soundOnIcon;
    }
}