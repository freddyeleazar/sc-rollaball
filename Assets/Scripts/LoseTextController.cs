using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTextController : MonoBehaviour
{
    private void Awake()
    {
        EventBroker.PlayerInDeathZone += SetActive;
    }
    private void Start()
    {
        gameObject.SetActive(false);
    }

    private void SetActive()
    {
        gameObject.SetActive(true);
    }
}
