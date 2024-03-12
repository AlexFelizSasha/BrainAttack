using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyObjectPool : MonoBehaviour
{
    public List<GameObject> InitializePoolFromList(List<GameObject> gameObjectList, int poolSize)
    {
        List<GameObject> _gameObjectlist = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            for (int j = 0; j < gameObjectList.Count; j++)
            {
                GameObject _poolObject = Instantiate(gameObjectList[j]);
                _poolObject.SetActive(false);
                _gameObjectlist.Add(_poolObject);
            }
        }
        return _gameObjectlist;
    }
    public GameObject GetPooledObject(List<GameObject> gameObjectList)
    {
        GameObject _pooledObject;
        do
            _pooledObject = gameObjectList[Random.Range(0, gameObjectList.Count)];
        while (_pooledObject.activeInHierarchy);
        return _pooledObject;
    }
}
