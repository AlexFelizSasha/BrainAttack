using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneBuilder : MonoBehaviour
{
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private GameObject _corridorFabricPrefab;
    [SerializeField] private GameObject _screenUIPrefab;
    [SerializeField] private GameObject _startCorridorPrefab;
    [SerializeField] private GameObject _corridorDestructorPrefab;
    void Start()
    {
        GameObject _startCorridor = Instantiate(_startCorridorPrefab) as GameObject;
        GameObject _player = Instantiate(_playerPrefab) as GameObject;
        GameObject _corridorFabric = Instantiate(_corridorFabricPrefab) as GameObject;
        GameObject _corridorDestructor = Instantiate(_corridorDestructorPrefab) as GameObject;

        TaskUItrigger.OnStartTask += TaskUItrigger_OnStartTask;
    }

    private void OnDisable()
    {
        TaskUItrigger.OnStartTask -= TaskUItrigger_OnStartTask;
    }

    private void TaskUItrigger_OnStartTask()
    {
        GameObject _screenUI = Instantiate(_screenUIPrefab) as GameObject;
    }
}
