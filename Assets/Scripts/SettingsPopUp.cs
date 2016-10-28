using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SettingsPopUp : MonoBehaviour {
    [SerializeField]
    private Slider speedSlider;

    void Start()
    {
        speedSlider.value = PlayerPrefs.GetFloat("speed", 1);
    }

    public void Open()
    {
        gameObject.SetActive(true); // Открываем окно
    }

    public void Close()
    {
        gameObject.SetActive(false); // Прячем
    }

    public void OnSubmitName(string name)
    {
        Debug.Log(name);
    }

    public void OnSpeedValue(float speed)
    {
        Messenger<float>.Broadcast(GameEvent.SPEED_CHANGED, speed);
    }
}
