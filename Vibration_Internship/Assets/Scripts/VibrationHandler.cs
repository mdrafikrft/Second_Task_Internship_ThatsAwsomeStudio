using UnityEngine;
using UnityEngine.UI;

public class VibrationHandler : MonoBehaviour
{
    [SerializeField] private Button defaultVibrationButton;

    private void OnEnable()
    {
        defaultVibrationButton.onClick.AddListener(DefaultVibration);
    }

    private void OnDisable()
    {
        defaultVibrationButton.onClick.RemoveListener(DefaultVibration);
    }

    private void DefaultVibration()
    {
        Debug.Log("Default Vibration Performed!");
        Handheld.Vibrate();
        
    }
}

