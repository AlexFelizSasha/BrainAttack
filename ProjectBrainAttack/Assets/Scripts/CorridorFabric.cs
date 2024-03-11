using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorFabric : MonoBehaviour
{
    private readonly Vector3 _corridorTransform = new Vector3(180, 0, 0);
    [SerializeField] private CorridorSO _corridorSO;

    private void Start()
    {
        PlayerCollisions.OnCreateCorridor += PlayerCollisions_OnCreateCorridor;
    }

    private void OnDisable()
    {
        PlayerCollisions.OnCreateCorridor -= PlayerCollisions_OnCreateCorridor;
    }
    private void PlayerCollisions_OnCreateCorridor()
    {
        GameObject _corridorPrefab = _corridorSO.corridorMath[Random.Range(0, 4)];
        Instantiate(_corridorPrefab, _corridorTransform, Quaternion.identity);
        Debug.Log("CorridorCreated");
    }
}
