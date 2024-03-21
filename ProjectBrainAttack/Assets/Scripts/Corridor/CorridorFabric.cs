using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorFabric : MonoBehaviour
{
    private readonly Vector3 _corridorTransform = new Vector3(180, 0, 0);
    [SerializeField] private CorridorSO _corridorSO;
    [SerializeField] private MyObjectPool _corridorPool;
    private List<GameObject> _corridorList;
    private int _corridorPoolSize = 2;


    private void Start()
    {
        CorridorTrigger.OnCreateCorridor += HandleCorridorCreating;

        //_corridorList = _corridorPool.InitializePoolFromList(_corridorSO.corridorMathMultiplication, _corridorPoolSize);
        _corridorList = _corridorPool.InitializePoolFromList(_corridorSO.corridorColor, _corridorPoolSize);
    }

    private void OnDisable()
    {
        CorridorTrigger.OnCreateCorridor -= HandleCorridorCreating;
    }

    private void HandleCorridorCreating()
    {
        GameObject _corridor = _corridorPool.GetPooledObject(_corridorList);
        _corridor.SetActive(true);
        _corridor.transform.position = _corridorTransform;
        Debug.Log("CorridorCreated");
    }
}
