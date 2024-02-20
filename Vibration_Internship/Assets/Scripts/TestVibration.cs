using UnityEngine;
using UnityEngine.UI;

public class TestVibration : MonoBehaviour
{
    public void defaultVibration()
    {
        Vibrator.Vibrate();
        Debug.Log("Vibrating");
    }

    public void lightVibration()
    {
        Vibrator.Vibrate(100);
        Debug.Log("light");
    }

    public void mediumVibration()
    {
        Vibrator.Vibrate(600);
        Debug.Log("medium");
    }

    public void highVibration()
    {
        Vibrator.Vibrate(1000);
        Debug.Log("high");
    }

}
