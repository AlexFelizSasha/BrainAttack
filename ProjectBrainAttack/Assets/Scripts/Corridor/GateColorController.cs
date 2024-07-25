using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateColorController : MonoBehaviour
{
    [SerializeField] private GameObject _trueGate;
    [SerializeField] private GameObject _firstFalseGate;
    [SerializeField] private GameObject _secondFalseGate;
    [SerializeField] private GameObject _thirdFalseGate;

    private void Start()
    {
        TaskFabric.OnTaskCreated += TaskFabric_OnTaskCreated;
    }

    private void TaskFabric_OnTaskCreated(object sender, TaskFabric.OnTaskCreatedEventArgs e)
    {
        SetGateColor(_trueGate, (Color)e.trueResult);
        SetGateColor(_firstFalseGate, (Color)e.firstFalseResult);
        SetGateColor(_secondFalseGate, (Color)e.secondFalseResult);
        SetGateColor(_thirdFalseGate, (Color)e.thirdFalseResult);
    }
    private void SetGateColor(GameObject gate, Color color)
    {
        Renderer _renderer = gate.GetComponent<Renderer>();
        if (_renderer != null)
        {
            _renderer.material.color = color;
        }
    }
}
