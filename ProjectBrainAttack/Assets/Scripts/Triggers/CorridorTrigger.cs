using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorTrigger : IPlayerTrigger
{
    public static event Action OnCreateCorridor;
    public void CollideWithPlayer()
    {
        OnCreateCorridor?.Invoke();
    }
}
