using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public static event Action OnCreateCorridor;
    public static event Action OnStartTasks;

    private const string TRUE_GATE = "TrueGate";
    private const string FALSE_GATE_1 = "FalseGate1";
    private const string FALSE_GATE_2 = "FalseGate2";
    private const string FALSE_GATE_3 = "FalseGate3";
    private const string START_GATE = "StartGate";
    private const string CORRIDOR_TRIGGER = "CorridorTrigger";
    private const string TASK_UI_TRIGGER = "TaskUITrigger";
    private void OnCollisionEnter(Collision collision)
    {
        string _name = collision.gameObject.name;
        if (_name == FALSE_GATE_1 || _name == FALSE_GATE_2 || _name == FALSE_GATE_3)
        {
            Debug.Log(collision.gameObject.name);
            CreateTask();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        string _name = other.gameObject.name;
        switch (_name)
        {
            case TASK_UI_TRIGGER:
                OnStartTasks?.Invoke();
                break;
            case START_GATE:
                CreateTask();
                break;
            case TRUE_GATE:
                Debug.Log("true");
                CreateTask();
                break;
            case CORRIDOR_TRIGGER:
                Debug.Log("CorridorTrigger");
                OnCreateCorridor?.Invoke();
                break;
        }
    }
    private void CreateTask()
    {
        TaskFabric _taskFabric = new TaskFabric();
        MathMultiplicationTask _mathMultiplicationTask = _taskFabric.CreateMathMultiplicationTask(1, 10);
    }
}
