using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateCover : MonoBehaviour
{
    [SerializeField] private GameObject _gateCover;
    private Vector3 _startPosition = new Vector3(-2.8f, -1.8f, 0f);
    private Rigidbody _rigidBody;
    private float _moveSpeed;
    [SerializeField] private bool _taskActivated;
    private void Awake()
    {
        _rigidBody = _gateCover.GetComponent<Rigidbody>();
    }
    private void Start()
    {
        TaskFabric.OnTaskCreated += TaskFabric_OnTaskCreated;
    }
    private void Update()
    {
        if (_taskActivated)
        {
            MoveGate(_moveSpeed);
        }
    }
    private void OnDisable()
    {
        Show();
    }
    private void TaskFabric_OnTaskCreated(object sender, TaskFabric.OnTaskCreatedEventArgs e)
    {
        if (gameObject.activeInHierarchy)
        {
            Hide();
            Debug.Log("Hide Cover");
        }
    }
    public void Show()
    {
        _moveSpeed = 0f;
        _taskActivated = false;
        Debug.Log("Show Cover");
        _rigidBody.velocity = Vector3.zero;
        _gateCover.transform.localPosition = _startPosition;
    }
    public void Hide()
    {
        _moveSpeed = 8f;
        _taskActivated = true;
    }
    private void MoveGate(float speed)
    {
        _rigidBody.velocity = Vector3.down * speed;
    }
}
