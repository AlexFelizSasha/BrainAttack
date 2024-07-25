using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorMover : MonoBehaviour
{
    private float _moveSpeed;
    void Start()
    {
        _moveSpeed = 8f;
    }

    void Update()
    {
        MoveWithSpeed(_moveSpeed);
    }

    private void MoveWithSpeed(float speed)
    {
        float _speed = speed*Time.deltaTime;
        Vector3 _nextPosition = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
        //Debug.Log("Corridor speed " + _speed);

        transform.position = Vector3.MoveTowards(transform.position, _nextPosition, _speed);
    }
}
