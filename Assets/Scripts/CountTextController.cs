using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountTextController : MonoBehaviour
{
    private TextMeshProUGUI countText;

    private void Awake()
    {
        countText = GetComponent<TextMeshProUGUI>();
        EventBroker.PlayerPickUp += SetCountText;
    }

    private void Start()
    {
        SetCountText(0);
    }

    private void SetCountText(int count)
    {
        countText.text = "Count: " + count.ToString();
    }
}
