using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        string _name = other.gameObject.name;
        TriggerContext _triggerContext = new TriggerContext();
        _triggerContext.CollideWithPlayer(_name);
    }
}
