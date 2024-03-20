using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static event Action OnPlayerMoves;

    private float _moveSpeed = 6f;
    private float _oneStepDistance = 8f;
    private float _maxLeftPosition = 12;
    private float _minRightPosition = -12;
    private bool _isMoving = false;
    private Vector3 _positionToMove;
    private Vector3 _playerPosition;
    void Start()
    {
        _positionToMove = transform.position;
        _playerPosition = transform.position;
        PressedKeysReader.OnRightKeyPressed += HandleRightKeyPressed;
        PressedKeysReader.OnLeftKeyPressed += HandleLeftKeyPressed;
    }

    private void Update()
    {
        if (_positionToMove != null)
        {
            MovePlayer(_positionToMove);
        }
    }
    private void OnDisable()
    {
        PressedKeysReader.OnRightKeyPressed -= HandleRightKeyPressed;
        PressedKeysReader.OnLeftKeyPressed -= HandleLeftKeyPressed;
    }

    private void HandleLeftKeyPressed()
    {
        if (_isMoving) return;
        OnPlayerMoves?.Invoke();
        float _zPosition = transform.position.z + _oneStepDistance;
        if (_zPosition > _maxLeftPosition) return;
        Vector3 _leftPositionToMove = new Vector3(_playerPosition.x, _playerPosition.y, _zPosition);
        _positionToMove = _leftPositionToMove;
    }

    private void HandleRightKeyPressed()
    {
        if (_isMoving) return;
        OnPlayerMoves?.Invoke();
        float _zPosition = transform.position.z - _oneStepDistance;
        if (_zPosition < _minRightPosition) return;
        Vector3 _leftPositionToMove = new Vector3(_playerPosition.x, _playerPosition.y, _zPosition);
        _positionToMove = _leftPositionToMove;
    }
    private void MovePlayer(Vector3 movePosition)
    {
        float _moveDistance = _moveSpeed * Time.deltaTime;

        Vector3 _moveDirection = movePosition - transform.position;
        _isMoving = _moveDirection != Vector3.zero;

        transform.position = Vector3.MoveTowards(transform.position, movePosition, _moveDistance);
    }

}
