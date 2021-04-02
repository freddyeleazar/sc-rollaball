using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
    public void OpenGate()
    {
        transform.position += new Vector3(0, transform.localScale.y, 0);
    }
}
