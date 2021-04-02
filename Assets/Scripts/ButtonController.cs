using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Events;

public class ButtonController : MonoBehaviour
{
    public UnityEvent OnPressingButton;
    private Transform button;

    private void Awake()
    {
        button = GetComponentsInChildren<Transform>().First(t => t.gameObject.name == "ButtonGraphics");
    }

    private void OnTriggerEnter(Collider other)
    {
        DownButton();
    }

    public void DownButton()
    {
        button.position -= new Vector3(0, 0.15f, 0);
        OnPressingButton.Invoke();
    }
}
