using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    public int value;

    private StageController stage;

    private void Awake()
    {
        stage = GetComponentInParent<StageController>();
        stage.pickUpQuantity++;
        value = 1;
    }


    private void OnDestroy()
    {
        stage.pickUpQuantity--;
        stage.CheckPickUpQuantity();
    }
}
