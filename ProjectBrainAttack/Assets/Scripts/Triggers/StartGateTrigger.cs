using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGateTrigger : IPlayerTrigger
{
    public void CollideWithPlayer()
    {
        CreateTask();
    }
    private void CreateTask()
    {
        TaskFabric _taskFabric = new TaskFabric();
        MathMultiplicationTask _mathMultiplicationTask = _taskFabric.CreateMathMultiplicationTask(1, 10);
    }
}
