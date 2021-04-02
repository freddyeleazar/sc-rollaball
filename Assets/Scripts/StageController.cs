using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class StageController : MonoBehaviour
{
    public UnityEvent OnStageCompleted;
    public int pickUpQuantity;

    private GameController game;

    private void Awake()
    {
        game = GetComponentInParent<GameController>();
        game.incompletedStages++;
    }

    public void CheckPickUpQuantity()
    {
        if(pickUpQuantity <= 0)
        {
            if(OnStageCompleted != null)
            {
                OnStageCompleted.Invoke();
            }
            game.incompletedStages--;
            game.CheckStageQuantity();
        }
    }
}
