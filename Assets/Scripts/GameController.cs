using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int incompletedStages;
    public int score;

    private void Awake()
    {
        EventBroker.PlayerPickUp += SetScore;
    }

    private void SetScore(PickUpController pickUp)
    {
        score += pickUp.value;
        EventBroker.CallUpdateScore(score);
    }

    public void CheckStageQuantity()
    {
        if(incompletedStages <= 0)
        {
            EventBroker.CallGameFinished("You Win!");
        }
    }
}
