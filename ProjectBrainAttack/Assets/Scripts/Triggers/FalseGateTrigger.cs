using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseGateTrigger : IPlayerTrigger
{
    public static event Action OnTaskAmountAdd;
    public void CollideWithPlayer()
    {
        OnTaskAmountAdd?.Invoke();
        CreateTask();
    }
    private void CreateTask()
    {
        TaskFabric _taskFabric = new TaskFabric();
        _taskFabric.CreateTask();
    }
}
