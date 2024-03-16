using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class CorridorDestruction : MonoBehaviour
{
    private const string CORRIDOR_DISTRUCTOR = "CorridorDestructor";
    [SerializeField] GameObject _corridor;

    private void OnTriggerEnter(Collider other)
    {
        string _name = other.name;
        if (_name == CORRIDOR_DISTRUCTOR)
        {
            _corridor.gameObject.SetActive(false);
            Debug.Log("destroying " + _corridor.name);
        }
    }

}
