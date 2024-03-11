using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private GameObject _corridorFabricPrefab;
    [SerializeField] private GameObject _screenUIPrefab;
    [SerializeField] private GameObject _startCorridorPrefab;
    void Start()
    {
        GameObject _startCorridor = Instantiate(_startCorridorPrefab) as GameObject;
        GameObject _player = Instantiate(_playerPrefab) as GameObject;
        GameObject _corridorFabric = Instantiate(_corridorFabricPrefab) as GameObject;
        //GameObject _screenUI = Instantiate(_screenUIPrefab) as GameObject;

        PlayerCollisions.OnStartTasks += PlayerCollisions_OnStartTasks;
    }

    private void PlayerCollisions_OnStartTasks()
    {
        GameObject _screenUI = Instantiate(_screenUIPrefab) as GameObject;
    }
}
