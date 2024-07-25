using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskTrigger : IPlayerTrigger
{
    public void CollideWithPlayer()
    {
        CreateTask();
    }
    private void CreateTask()
    {
        TaskFabric _taskFabric = new TaskFabric();
        _taskFabric.CreateTask();
    }
}
