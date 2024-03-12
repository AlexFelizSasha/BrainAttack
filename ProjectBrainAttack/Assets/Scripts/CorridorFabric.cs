using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorFabric : MonoBehaviour
{
    private readonly Vector3 _corridorTransform = new Vector3(180, 0, 0);
    [SerializeField] private CorridorSO _corridorSO;
    private MyObjectPool _corridorPool;
    private List<GameObject> _corridorList;

    private void Start()
    {
        PlayerCollisions.OnCreateCorridor += PlayerCollisions_OnCreateCorridor;
        CreateCorridorList();
    }

    private void OnDisable()
    {
        PlayerCollisions.OnCreateCorridor -= PlayerCollisions_OnCreateCorridor;
    }
    private void PlayerCollisions_OnCreateCorridor()
    {
        GameObject _corridor = _corridorPool.GetPooledObject(_corridorList);
        _corridor.SetActive(true);
        _corridor.transform.position = _corridorTransform;
        Debug.Log("CorridorCreated");
    }
    private void CreateCorridorList()
    {
        _corridorPool = new MyObjectPool();
        _corridorList = _corridorPool.InitializePoolFromList(_corridorSO.corridorMath, 2);
    }
}
