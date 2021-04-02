using UnityEngine;
using TMPro;

public class MainTextController : MonoBehaviour
{
    private TextMeshProUGUI mainText;

    private void Awake()
    {
        mainText = GetComponent<TextMeshProUGUI>();
        EventBroker.GameFinished += ShowMessage;
    }

    private void Start()
    {
        mainText.enabled = false;
    }

    private void ShowMessage(string message)
    {
        mainText.text = message;
        mainText.enabled = true;
    }

    private void OnDestroy()
    {
        EventBroker.GameFinished -= ShowMessage;
    }
}
