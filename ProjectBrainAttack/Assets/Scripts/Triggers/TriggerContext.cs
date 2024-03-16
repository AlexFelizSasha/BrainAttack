using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerContext
{
    private Dictionary<string, IPlayerTrigger> _playerTriggerContext = new Dictionary<string, IPlayerTrigger>();

    private const string TRUE_GATE = "TrueGate";
    private const string FALSE_GATE_1 = "FalseGate1";
    private const string FALSE_GATE_2 = "FalseGate2";
    private const string FALSE_GATE_3 = "FalseGate3";
    private const string START_GATE = "StartGate";
    private const string CORRIDOR_TRIGGER = "CorridorTrigger";
    private const string TASK_UI_TRIGGER = "TaskUITrigger";

    public TriggerContext()
    {
        _playerTriggerContext.Add(TRUE_GATE, new TrueGateTrigger());
        _playerTriggerContext.Add(FALSE_GATE_1, new FalseGateTrigger());
        _playerTriggerContext.Add(FALSE_GATE_2, new FalseGateTrigger());
        _playerTriggerContext.Add(FALSE_GATE_3, new FalseGateTrigger());
        _playerTriggerContext.Add(START_GATE, new StartGateTrigger());
        _playerTriggerContext.Add(CORRIDOR_TRIGGER, new CorridorTrigger());
        _playerTriggerContext.Add(TASK_UI_TRIGGER, new TaskUItrigger());
    }
    public void CollideWithPlayer(string name)
    {
        _playerTriggerContext[name].CollideWithPlayer();
    }
}
