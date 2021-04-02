using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levitator : MonoBehaviour
{
    public float yMax;
    public float yMin;
    public float levitationSpeed;

    private Vector3 direction;

    private void Start()
    {
        direction = Vector3.zero;
    }
    private void Update()
    {
        if(transform.position.y >= yMax)
        {
            direction = Vector3.down;
        }
        if(transform.position.y <= yMin)
        {
            direction = Vector3.up;
        }
        transform.Translate(direction * Time.deltaTime * levitationSpeed, Space.World);
    }
}
