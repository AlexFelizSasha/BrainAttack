using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskUItrigger : IPlayerTrigger
{
    public static event Action OnStartTask;
    public void CollideWithPlayer()
    {
        OnStartTask?.Invoke();
    }
}
