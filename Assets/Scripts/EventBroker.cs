using System;
using UnityEngine;

public class EventBroker
{
    public static event Action<string> GameFinished;
    public static event Action<PickUpController> PlayerPickUp;
    public static event Action<int> UpdateScore;

    public static void CallUpdateScore(int score)
    {
        if(UpdateScore != null)
        {
            UpdateScore(score);
        }
    }

    public static void CallGameFinished(string message)
    {
        if(GameFinished!= null)
        {
            GameFinished(message);
        }
    }

    public static void CallPlayerPickUp(PickUpController pickUp)
    {
        if(PlayerPickUp != null)
        {
            PlayerPickUp(pickUp);
        }
    }
}
