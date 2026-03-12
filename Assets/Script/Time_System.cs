using UnityEngine;

public class Time_System : MonoBehaviour
{
    public void TimeStart()
    {
        Time.timeScale = 1;
    }

    public void TimeStop()
    {
        Time.timeScale = 0;
    }
}
