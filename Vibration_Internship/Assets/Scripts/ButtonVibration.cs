using UnityEngine;
using CandyCoded.HapticFeedback;
using UnityEngine.UI;

public class ButtonVibration : MonoBehaviour
{
    [SerializeField] private Button defaultVibrationButton;
    [SerializeField] private Button lightVibrationButton;
    [SerializeField] private Button mediumVibrationButton;
    [SerializeField] private Button highVibrationButton;

    private void OnEnable()
    {
        defaultVibrationButton.onClick.AddListener(DefaultVibration);
        lightVibrationButton.onClick.AddListener(LightVibration);
        mediumVibrationButton.onClick.AddListener(MediumVibration);
        highVibrationButton.onClick.AddListener(HighVibration);
    }

    private void OnDisable()
    {
        defaultVibrationButton.onClick.RemoveListener(DefaultVibration);
        lightVibrationButton.onClick.RemoveListener(LightVibration);
        mediumVibrationButton.onClick.RemoveListener(MediumVibration);
        highVibrationButton.onClick.RemoveListener(HighVibration);
    }

    public void DefaultVibration()
    {
        Handheld.Vibrate();
    }

    public void LightVibration()
    {
        HapticFeedback.LightFeedback();
        Debug.Log("Light");
    }

    public void MediumVibration()
    {
        HapticFeedback.MediumFeedback();
        Debug.Log("Medium");
    }

    public void HighVibration()
    {
        HapticFeedback.HeavyFeedback();
        Debug.Log("High");
    }
}
