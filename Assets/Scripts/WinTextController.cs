using UnityEngine;
using TMPro;

public class WinTextController : MonoBehaviour
{
    private TextMeshProUGUI winText;

    private void Awake()
    {
        winText = GetComponent<TextMeshProUGUI>();
        EventBroker.PlayerWin += SetVisible;
    }

    private void Start()
    {
        winText.enabled = false;
    }

    private void SetVisible()
    {
        winText.enabled = true;
    }
}
