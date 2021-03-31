using System;
using UnityEngine;

public class EventBroker
{
    public static event Action PlayerInDeathZone;
    public static event Action PlayerWin;
    public static event Action<int> PlayerPickUp;

    public static void CallPlayerInDeathZone()
    {
        if (PlayerInDeathZone != null)
        {
            PlayerInDeathZone();
        }
    }

    public static void CallPlayerWin()
    {
        if(PlayerWin != null)
        {
            PlayerWin();
        }
    }

    public static void CallPlayerPickUp(int count)
    {
        if(PlayerPickUp != null)
        {
            PlayerPickUp(count);
        }
    }
}
