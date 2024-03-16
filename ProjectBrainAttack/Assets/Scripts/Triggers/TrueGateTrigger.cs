using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueGateTrigger : IPlayerTrigger
{
    public static event Action OnTaskAmountAdd;
    public static event Action OnScoreAdd;
    public void CollideWithPlayer()
    {
        OnTaskAmountAdd?.Invoke();
        OnScoreAdd?.Invoke();
        CreateTask();
    }
    private void CreateTask()
    {
        TaskFabric _taskFabric = new TaskFabric();
        MathMultiplicationTask _mathMultiplicationTask = _taskFabric.CreateMathMultiplicationTask(1, 10);
    }
}
