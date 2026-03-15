using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        slider.value = AudioListener.volume;
    }

    public void ChangeVolume(float value)
    {
        AudioListener.volume = value;
    }
}