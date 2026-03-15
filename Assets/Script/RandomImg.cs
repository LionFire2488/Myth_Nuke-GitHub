using UnityEngine;
using UnityEngine.UI;

public class RandomImg : MonoBehaviour
{
    public Image displayImage;     // ช่องแสดงรูป
    public Sprite[] images;        // รูปทั้งหมด

    public void ShowRandomImage()
    {
        int index = Random.Range(0, images.Length);
        displayImage.sprite = images[index];
    }
}
